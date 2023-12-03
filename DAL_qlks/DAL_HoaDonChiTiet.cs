using DTO_qlks;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_qlks.DAL_HoaDonChiTiet;

namespace DAL_qlks
{
    public class DAL_HoaDonChiTiet:DBConnect
    {
        public bool ThemHoaDonChiTiet(DTO_HoaDonChiTiet hoaDonChiTiet)
        {
            try
            {

                connection.Open();
                string query = "INSERT INTO HoaDonChiTiet (MaxHDCT, SoLuong, MaHoaDon, MaDichVu) VALUES (@MaxHDCT, @SoLuong, @MaHoaDon, @MaDichVu)";

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@MaxHDCT", HDCTtutang()); // Tạo mã HDCT mới
                cmd.Parameters.AddWithValue("@SoLuong", hoaDonChiTiet.Soluong);
                cmd.Parameters.AddWithValue("@MaHoaDon", hoaDonChiTiet.Mahoadon);
                cmd.Parameters.AddWithValue("@MaDichVu", hoaDonChiTiet.Madichvu);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool XoaHoaDonChiTiet(string maHoaDonChiTiet)
        {
            try
            {
                
                connection.Open();
                string query = "DELETE FROM HoaDonChiTiet WHERE MaxHDCT = @MaHoaDonChiTiet";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@MaHoaDonChiTiet", maHoaDonChiTiet);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
                
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool SuaHoaDonChiTiet(DTO_HoaDonChiTiet hoaDonChiTiet)
        {
            try
            {
                connection.Open();
                string query = "UPDATE HoaDonChiTiet SET SoLuong = @SoLuong, MaHoaDon = @MaHoaDon, MaDichVu = @MaDichVu WHERE MaxHDCT = @MaxHDCT";

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Parameters.AddWithValue("@SoLuong", hoaDonChiTiet.Soluong);
                cmd.Parameters.AddWithValue("@MaHoaDon", hoaDonChiTiet.Mahoadon);
                cmd.Parameters.AddWithValue("@MaDichVu", hoaDonChiTiet.Madichvu);
                cmd.Parameters.AddWithValue("@MaxHDCT", hoaDonChiTiet.Mahoadonchitiet); // Sử dụng MaxHDCT để xác định hóa đơn cần sửa

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        private string HDCTtutang()
        {
            try
            {
                connection.Open();

                // Truy vấn để lấy mã 'mahoadonchitiet' lớn nhất từ CSDL
                string query = "SELECT MAX(MaHoaDonChiTiet) FROM HoaDonChiTiet";
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int maxID = Convert.ToInt32(result);
                    maxID++; // Tăng giá trị lên 1 để tạo mã mới
                    return "HDCT" + maxID.ToString("D2"); // Trả về mã mới
                }
                else
                {
                    return "HDCT01"; // Trường hợp không có dữ liệu, trả về mã mặc định
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Error: " + ex.Message);
                return "HDCT01"; // Trả về mã mặc định nếu có lỗi xảy ra
            }
            finally
            {
                connection.Close();
            }
        }

        public string LayTenNhanVien(string manv)
        {
            try
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT hoten FROM nhanvien WHERE manv = @manv";

                    // Tạo tham số và đặt giá trị cho nó
                    NpgsqlParameter parameter = new NpgsqlParameter("@manv", NpgsqlDbType.Text);
                    parameter.Value = manv;
                    cmd.Parameters.Add(parameter);

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

        public string LayTenKhachHang(string makh)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select hoten from khachhang where makhachhang=@makhachhang";
                cmd.Parameters.AddWithValue("@makhachhang", makh);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }
                else return "";
            }
            finally
            {
                connection.Close();
            }
        }
        public double GiaPhong(string maphong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select gia from phong where maphong=@maphong";
                cmd.Parameters.AddWithValue("@maphong", maphong);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    double gia=Convert.ToDouble(result);
                    return gia;
                }
                else return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable DichVuDaSuDung(string maHoaDon)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                // Thực hiện truy vấn kết hợp giữa hai bảng
                cmd.CommandText = @"
                SELECT dv.tendichvu, dv.dongia, ct.soluong, dv.dongia * ct.soluong AS thanhtien
                FROM chitiethoadonphong ct
                JOIN dichvu dv ON ct.madichvu = dv.madichvu
                JOIN hoadonphong hp ON ct.mahoadon = hp.mahoadon
                WHERE ct.mahoadon = @mahoadon AND hp.ngaytraphong IS NULL";
                cmd.Parameters.AddWithValue("@mahoadon",maHoaDon);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                connection.Close();
            }
        }

        public string TaoMaHoaDonChiTiet()
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Tìm mã khách hàng trống nếu có
                cmd.CommandText = "SELECT MaHoaDonChiTiet FROM ChiTietHoaDonPhong WHERE substring(MaHoaDonChiTiet, 3) ~ '^[0-9]+$' ORDER BY substring(MaHoaDonChiTiet, 3)::int DESC LIMIT 1";
                object result = cmd.ExecuteScalar();

                string newCustomerId = string.Empty;

                if (result != null && result != DBNull.Value)
                {
                    int lastNumber;
                    if (int.TryParse(result.ToString().Substring(2), out lastNumber))
                    {
                        newCustomerId = "CT" + (lastNumber + 1).ToString("000");
                    }
                }
                else
                {
                    // Lấy mã khách hàng mới từ cơ sở dữ liệu
                    cmd.CommandText = "SELECT COALESCE(MAX(CAST(substring(MaHoaDonChiTiet, 3) AS int)), 0) + 1 FROM ChiTietHoaDonPhong WHERE substring(MaHoaDonChiTiet, 3) ~ '^[0-9]+$'";
                    newCustomerId = "CT" + Convert.ToInt32(cmd.ExecuteScalar()).ToString("000");
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
        public bool Luuhdct(DTO_HoaDonChiTiet hdct)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                try
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    string kiemtratontai = "SELECT COUNT(*) FROM ChiTietHoaDonPhong WHERE madichvu=@madichvu and mahoadon=@mahoadon";
                    cmd.CommandText = kiemtratontai;
                    cmd.Parameters.AddWithValue("@mahoadon", hdct.Mahoadon);
                    cmd.Parameters.AddWithValue("@madichvu", hdct.Madichvu);

                    int existingCount = Convert.ToInt16(cmd.ExecuteScalar());

                    int ketQua = 0;

                    if (existingCount > 0)
                    {
                        cmd.CommandText = "UPDATE ChiTietHoaDonPhong SET SoLuong = soluong+1 WHERE madichvu = @madichvu";
                        ketQua = Convert.ToInt16(cmd.ExecuteNonQuery());
                    }
                    else
                    {
                        cmd.Parameters.Clear();                    
                        cmd.CommandText = "INSERT INTO ChiTietHoaDonPhong (MaHoaDonChiTiet, SoLuong, MaHoaDon, MaDichVu) VALUES (@MaHoaDonChiTiet, @SoLuong, @MaHoaDon, @MaDichVu)";
                        cmd.Parameters.AddWithValue("@MaHoaDonChiTiet", TaoMaHoaDonChiTiet());
                        cmd.Parameters.AddWithValue("@SoLuong", 1);
                        cmd.Parameters.AddWithValue("@MaHoaDon", hdct.Mahoadon);
                        cmd.Parameters.AddWithValue("@MaDichVu", hdct.Madichvu);
                        ketQua = Convert.ToInt16(cmd.ExecuteNonQuery());
                    }

                    return ketQua > 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public bool XoaHDCT(string mahdct)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from ChiTietHoaDonPhong where MaHoaDonChiTiet = @MaHoaDonChiTiet ";
                cmd.Parameters.AddWithValue("@MaHoaDonChiTiet", mahdct);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public DataTable DanhsachHDCT()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Chitiethoadonphong";//Chỉ hiển thị lên datagrid nếu muốn hiển thị theo combobox thì làm khác
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally { connection.Close(); }
        }

        public DataTable DichVuDaChon(string maHoaDon)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ct.mahoadonchitiet, dv.tendichvu, dv.dongia, ct.soluong,dv.dongia*ct.soluong FROM " +
                                  "chitiethoadonphong ct JOIN dichvu dv ON ct.madichvu = dv.madichvu " +
                                  "WHERE mahoadon = @mahoadon";
                cmd.Parameters.AddWithValue("@mahoadon", maHoaDon);

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool ThanhToanPhong(string mahoadon, DateTime ngaytraphong, bool trangthai, string maphong)
        {
            try
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE hoadonphong " +
                                      "SET ngaytraphong = @NgayTraPhong " +
                                      "WHERE MaHoaDon = @MaHoaDon";
                    cmd.Parameters.AddWithValue("@NgayTraPhong", ngaytraphong);
                    cmd.Parameters.AddWithValue("@MaHoaDon", mahoadon);

                    using (NpgsqlCommand cmd2 = new NpgsqlCommand())
                    {
                        cmd2.Connection = connection;
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "UPDATE phong " +
                                          "SET trangthai = @TrangThai " +
                                          "WHERE MaPhong = @MaPhong";
                        cmd2.Parameters.AddWithValue("@TrangThai", trangthai);
                        cmd2.Parameters.AddWithValue("@MaPhong", maphong);

                        int result1 = cmd.ExecuteNonQuery();
                        int result2 = cmd2.ExecuteNonQuery();

                        if (result1 > 0 && result2 > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }

    }

}
