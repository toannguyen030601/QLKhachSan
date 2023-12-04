using DTO_qlks;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_qlks
{
    public class DAL_Phong:DBConnect
    {
        public DataTable DanhSachPhong()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Phong";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally { connection.Close(); }
        }
        public bool CheckMaPhong(string maPhong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select COUNT(*) from Phong where maphong=@maphong";
                cmd.Parameters.AddWithValue("@maphong", maPhong);
                int kq=Convert.ToInt16(cmd.ExecuteScalar());
                return kq > 0;
            }
            finally { connection.Close(); }
        }
        public bool LuuPhong(DTO_Phong p)
        {
            try
            {
                connection.Open();

                // Kiểm tra xem phòng đã tồn tại hay chưa
                string checkExistPhong = "SELECT COUNT(*) FROM phong WHERE maphong = @maphong";
                using (NpgsqlCommand checkExistCmd = new NpgsqlCommand(checkExistPhong, connection))
                {
                    checkExistCmd.Parameters.AddWithValue("maphong", p.MaPhong);
                    int existingCount = Convert.ToInt32(checkExistCmd.ExecuteScalar());

                    if (existingCount > 0)
                    {
                        // Phòng đã tồn tại, thực hiện cập nhật
                        string updateQuery = "UPDATE phong SET tenphong = @tenphong, gia = @gia, trangthai = @trangthai, maloaiphong = @maloaiphong WHERE maphong = @maphong";
                        using (NpgsqlCommand updateCmd = new NpgsqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@maphong", p.MaPhong);
                            updateCmd.Parameters.AddWithValue("@tenphong", p.TenPhong);
                            updateCmd.Parameters.AddWithValue("@gia", p.Gia);
                            updateCmd.Parameters.AddWithValue("@trangthai", p.TrangThai);
                            updateCmd.Parameters.AddWithValue("@maloaiphong", p.MaLoaiPhong);

                            int updateResult = updateCmd.ExecuteNonQuery();
                            return updateResult > 0;
                        }
                    }
                    else
                    {
                        // Phòng chưa tồn tại, thực hiện thêm mới
                        string insertQuery = "INSERT INTO phong (maphong, tenphong, gia, trangthai, maloai_phong) VALUES (@maphong, @tenphong, @gia, @trangthai, @maloaiphong)";
                        using (NpgsqlCommand insertCmd = new NpgsqlCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@maphong", p.MaPhong);
                            insertCmd.Parameters.AddWithValue("@tenphong", p.TenPhong);
                            insertCmd.Parameters.AddWithValue("@gia", p.Gia);
                            insertCmd.Parameters.AddWithValue("@trangthai", p.TrangThai);
                            insertCmd.Parameters.AddWithValue("@maloaiphong", p.MaLoaiPhong);

                            int insertResult = insertCmd.ExecuteNonQuery();
                            return insertResult > 0;
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public bool XoaPhong(string maPhong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from phong where maphong=@maphong";
                cmd.Parameters.AddWithValue("@maphong", maPhong);
                int kq = Convert.ToInt16(cmd.ExecuteNonQuery());
                return kq > 0;    
            }
            finally { connection.Close(); }
        }

        public string GetLoaiPhongFromMaLoaiPhong(string maLoaiPhong)
        {
            string tenLoaiPhong = "";

            try
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT tenloaiphong FROM loaiphong WHERE maloaiphong = @maLoaiPhong";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@maLoaiPhong", maLoaiPhong);

                    // Execute the query and get the result
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        tenLoaiPhong = result.ToString();
                    }
                }

                return tenLoaiPhong;
            }
            finally
            {
                connection.Close();
            }
        }


        public string TaoMaKhachHang()
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Tìm mã khách hàng trống nếu có
                cmd.CommandText = "SELECT MaKhachHang FROM KhachHang WHERE substring(MaKhachHang, 3) ~ '^[0-9]+$' ORDER BY substring(MaKhachHang, 3)::int DESC LIMIT 1";
                object result = cmd.ExecuteScalar();

                string newCustomerId = string.Empty;

                if (result != null && result != DBNull.Value)
                {
                    int lastNumber;
                    if (int.TryParse(result.ToString().Substring(2), out lastNumber))
                    {
                        newCustomerId = "KH" + (lastNumber + 1).ToString("000");
                    }
                }
                else
                {
                    // Lấy mã khách hàng mới từ cơ sở dữ liệu
                    cmd.CommandText = "SELECT COALESCE(MAX(CAST(substring(MaKhachHang, 3) AS int)), 0) + 1 FROM KhachHang WHERE substring(MaKhachHang, 3) ~ '^[0-9]+$'";
                    newCustomerId = "KH" + Convert.ToInt32(cmd.ExecuteScalar()).ToString("000");
                }

                return newCustomerId;
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây nếu cần
                // Ví dụ: throw ex; để ném exception lên lớp gọi
                // hoặc log lỗi
                throw;
            }
        }
        public string LayMaNhanVien(string email)
        {
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT manv FROM nhanvien WHERE email = @email";

                    // Tạo tham số và đặt giá trị cho nó
                    cmd.Parameters.AddWithValue("@email", email);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }

        public bool DatPhong(string hoten, string sdt, string cccd, string gioitinh, string email, DateTime ngaynhanphong, string maphong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Lấy mã khách hàng mới từ phương thức tạo mã
                string newCustomerId = TaoMaKhachHang();
                cmd.CommandText = "INSERT INTO KhachHang (MaKhachHang, HoTen, SoDT, SoCCCD, GioiTinh, MaNV) VALUES (@MaKhachHang, @HoTen, @SoDT, @SoCCCD, @GioiTinh, @MaNV)";

                cmd.Parameters.AddWithValue("@MaKhachHang", newCustomerId);
                cmd.Parameters.AddWithValue("@HoTen", hoten);
                cmd.Parameters.AddWithValue("@SoDT", sdt);
                cmd.Parameters.AddWithValue("@SoCCCD", cccd);
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                connection.Close();
                cmd.Parameters.AddWithValue("@MaNV", LayMaNhanVien(email));
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                NpgsqlCommand cmd2 = new NpgsqlCommand();
                cmd2.Connection = connection;
                cmd2.CommandType = CommandType.Text;

                // Lấy mã khách hàng mới từ phương thức tạo mã
                string HDId = TaoMaHoaDon();
                if (string.IsNullOrEmpty(HDId))
                {
                    // Xử lý khi không thể tạo mã khách hàng mới
                    return false;
                }

                cmd2.CommandText = "INSERT INTO hoadonphong (mahoadon,ngaynhanphong,makhachhang,manhanvien,maphong) VALUES (@mahoadon,@ngaynhanphong,@makhachhang,@manhanvien,@maphong)";

                cmd2.Parameters.AddWithValue("@mahoadon", HDId);
                cmd2.Parameters.AddWithValue("@ngaynhanphong", ngaynhanphong);
                cmd2.Parameters.AddWithValue("@makhachhang", newCustomerId);
                connection.Close();
                cmd2.Parameters.AddWithValue("@manhanvien",LayMaNhanVien(email));
                cmd2.Parameters.AddWithValue("@maphong", maphong);
                connection.Open();

                NpgsqlCommand cmd3 = new NpgsqlCommand();
                cmd3.Connection = connection;
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "update phong set trangthai=true where maphong=@maphong";
                cmd3.Parameters.AddWithValue("@maphong",maphong);
                cmd3.ExecuteNonQuery();
                int kq = cmd2.ExecuteNonQuery();
                if (kq > 0 && rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                // Trả về true nếu thêm thành công, ngược lại trả về false
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây nếu cần
                // Ví dụ: throw ex; để ném exception lên lớp gọi
                // hoặc log lỗi
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public string TaoMaHoaDon()
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Tìm mã khách hàng trống nếu có
                cmd.CommandText = "SELECT mahoadon FROM hoadonphong WHERE substring(mahoadon, 3) ~ '^[0-9]+$' ORDER BY substring(mahoadon, 3)::int DESC LIMIT 1";
                object result = cmd.ExecuteScalar();

                string newHoaDonId = string.Empty;

                if (result != null && result != DBNull.Value)
                {
                    int lastNumber;
                    if (int.TryParse(result.ToString().Substring(2), out lastNumber))
                    {
                        newHoaDonId = "HD" + (lastNumber + 1).ToString("000");
                    }
                }
                else
                {
                    // Lấy mã khách hàng mới từ cơ sở dữ liệu
                    cmd.CommandText = "SELECT COALESCE(MAX(CAST(substring(mahoadon, 3) AS int)), 0) + 1 FROM hoadonphong WHERE substring(mahoadon, 3) ~ '^[0-9]+$'";
                    newHoaDonId = "HD" + Convert.ToInt32(cmd.ExecuteScalar()).ToString("000");
                }

                return newHoaDonId;
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây nếu cần
                // Ví dụ: throw ex; để ném exception lên lớp gọi
                // hoặc log lỗi
                throw;
            }
        }
        public string MaHoaDonCuaPhong(string maPhong)
        {
            string maHoaDon = "";

            try
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    // Sử dụng thời điểm cụ thể thay vì null
                    cmd.CommandText = "SELECT mahoadon FROM hoadonphong WHERE maphong=@maphong and ngaytraphong IS NULL";

                    // Sử dụng parameters để tránh SQL injection
                    cmd.Parameters.AddWithValue("@maphong", maPhong);

                    // Thực hiện truy vấn và lấy kết quả
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        maHoaDon = result.ToString();
                    }
                }

                return maHoaDon;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckXoaPhong(string maPhong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from hoadonphong where maphong=@maphong";
                // Thêm tham số đầu vào
                cmd.Parameters.AddWithValue("@maphong", maPhong);
                // Thực thi stored procedure
                int kq = Convert.ToInt16(cmd.ExecuteScalar());
                return kq > 0;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
