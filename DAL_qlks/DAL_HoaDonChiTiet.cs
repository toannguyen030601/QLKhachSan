using DTO_qlks;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
