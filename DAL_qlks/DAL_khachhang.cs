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
    public class DAL_khachhang : DBConnect
    {

        public DataTable TimKhachHang(DTO_khachhang khachHang)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM KhachHang WHERE HoTen ILIKE '%' || @HoTen || '%'";
                ///ILIKE để thực hiện tìm kiếm không phân biệt chữ hoa, chữ thường.
                /// || @HoTen || được sử dụng để nối giá trị của tham số == CONCAT
                cmd.Parameters.AddWithValue("@HoTen", khachHang.Hoten);

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            finally
            {
                connection.Close();
            }
        }
        public string TaoMaKhachHang()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
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
        }

        public bool ThemKhachHang(DTO_khachhang khachHang)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
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
                    cmd.Parameters.AddWithValue("@HoTen", khachHang.Hoten);
                    cmd.Parameters.AddWithValue("@SoDT", khachHang.Sodt);
                    cmd.Parameters.AddWithValue("@SoCCCD", khachHang.Socccd);
                    cmd.Parameters.AddWithValue("@GioiTinh", khachHang.Gioitinh);
                    cmd.Parameters.AddWithValue("@MaNV", khachHang.Manv);

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
        public bool XoaKhachHang(string maKhachHang)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Kiểm tra xem khách hàng có tồn tại trong bảng HoaDonPhong hay không
                cmd.CommandText = "SELECT COUNT(*) FROM HoaDonPhong WHERE MaKhachHang = @MaKhachHang";
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                int count = Convert.ToInt32(cmd.ExecuteScalar()); ; // Lấy số lượng bản ghi trả về

                if (count > 0)
                {
                    // Nếu khách hàng có trong bảng HoaDonPhong, không cho phép xóa và hiển thị thông báo
                    /*Console.WriteLine("Không thể xóa khách hàng vì đã có thông tin trong bảng HoaDonPhong.");*/
                    return false;
                }
                else
                {
                    // Nếu không có thông tin trong bảng HoaDonPhong, tiến hành xóa khách hàng
                    cmd.CommandText = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; // Trả về true nếu xóa thành công, ngược lại trả về false
                }
            }
            finally
            {
                connection.Close();
            }
        }
        public bool KiemTraTonTaiTrongHoaDon(string maKhachHang)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT COUNT(*) FROM HoaDonPhong WHERE MaKhachHang = @MaKhachHang";
                cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

                int count = Convert.ToInt32(cmd.ExecuteScalar()); ; // Lấy số lượng bản ghi trả về

                return count > 0; // Trả về true nếu tồn tại trong bảng HoaDonPhong, ngược lại trả về false
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable LayDuLieuKhachHang()
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM KhachHang";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);

                return data;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool SuaKhachHang(DTO_khachhang khachHang)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE KhachHang SET HoTen = @HoTen, SoDT = @SoDT, SoCCCD = @SoCCCD, GioiTinh = @GioiTinh WHERE MaKhachHang = @MaKhachHang";

                cmd.Parameters.AddWithValue("@HoTen", khachHang.Hoten);
                cmd.Parameters.AddWithValue("@SoDT", khachHang.Sodt);
                cmd.Parameters.AddWithValue("@SoCCCD", khachHang.Socccd);
                cmd.Parameters.AddWithValue("@GioiTinh", khachHang.Gioitinh);
                cmd.Parameters.AddWithValue("@MaKhachHang", khachHang.Makhachhang);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // Trả về true nếu sửa thành công, ngược lại trả về false
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable danhsachkhachhang()
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from khachhang";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;

            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable thongtinkhachhang(string MaKH)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from khachhang where makhachhang = @makh";
                cmd.Parameters.AddWithValue("@makh", MaKH);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
