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
        public void LuuPhong(DTO_Phong p)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "luuphong";
                cmd.Parameters.AddWithValue("@p_maphong",p.MaPhong);
                cmd.Parameters.AddWithValue("@p_tenphong", p.TenPhong);
                cmd.Parameters.AddWithValue("@p_gia", p.Gia);
                cmd.Parameters.AddWithValue("@p_trangthai", p.TrangThai);
                cmd.Parameters.AddWithValue("@p_maloaiphong", p.MaLoaiPhong);
                cmd.ExecuteNonQuery();
            }
            finally { connection.Close(); }
        }
        public void XoaPhong(string maPhong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoaphong";
                cmd.Parameters.AddWithValue("@p_maphong", maPhong);
                cmd.ExecuteNonQuery();
                /*int affectedRows = Convert.ToInt16(cmd.ExecuteNonQuery());*/

               /* if (affectedRows > 0)
                {
                    return true;
                }
                
                else
                {
                    return false;
                }*/
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
                connection.Open();
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
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
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
            finally
            {
                connection.Close();
            }
        }

        public bool ThemKhachHang(string hoten, string sdt, string cccd, bool gioitinh, string email)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Lấy mã khách hàng mới từ phương thức tạo mã
                string newCustomerId = TaoMaKhachHang();
                if (string.IsNullOrEmpty(newCustomerId))
                {
                    // Xử lý khi không thể tạo mã khách hàng mới
                    return false;
                }

                cmd.CommandText = "INSERT INTO KhachHang (MaKhachHang, HoTen, SoDT, SoCCCD, GioiTinh, MaNV) VALUES (@MaKhachHang, @HoTen, @SoDT, @SoCCCD, @GioiTinh, @MaNV)";

                cmd.Parameters.AddWithValue("@MaKhachHang", newCustomerId);
                cmd.Parameters.AddWithValue("@HoTen", hoten);
                cmd.Parameters.AddWithValue("@SoDT", sdt);
                cmd.Parameters.AddWithValue("@SoCCCD", cccd);
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                cmd.Parameters.AddWithValue("@MaNV", LayMaNhanVien(email));

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // Trả về true nếu thêm thành công, ngược lại trả về false
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây nếu cần
                // Ví dụ: throw ex; để ném exception lên lớp gọi
                // hoặc log lỗi
                throw;
            }
        }
    }
}
