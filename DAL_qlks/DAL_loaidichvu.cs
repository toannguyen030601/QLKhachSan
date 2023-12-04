using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_qlks;
using Npgsql;
using NpgsqlTypes;

namespace DAL_qlks
{
    public class DAL_loaidichvu : DBConnect
    {
        public DataTable DanhSachLoaiDichVu()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM LoaiDichVu";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây nếu cần
                // Ví dụ: throw ex; để ném exception lên lớp gọi
                // hoặc log lỗi
                throw;
            }
        }

        public string TaoMaLoaiDichVu()
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
                    cmd.CommandText = "SELECT Maloaidichvu FROM loaidichvu WHERE substring(maloaidichvu, 4) ~ '^[0-9]+$' ORDER BY substring(maloaidichvu, 4)::int DESC LIMIT 1";
                    object result = cmd.ExecuteScalar();

                    string newLDVid = string.Empty;

                    if (result != null && result != DBNull.Value)
                    {
                        int lastNumber;
                        if (int.TryParse(result.ToString().Substring(3), out lastNumber))
                        {
                            newLDVid = "LDV" + (lastNumber + 1).ToString("000");
                        }
                    }
                    else
                    {
                        // Lấy mã khách hàng mới từ cơ sở dữ liệu
                        cmd.CommandText = "SELECT COALESCE(MAX(CAST(substring(maloaidichvu, 4) AS int)), 0) + 1 FROM loaidichvu WHERE substring(maloaidichvu, 4) ~ '^[0-9]+$'";
                        newLDVid = "LDV" + Convert.ToInt32(cmd.ExecuteScalar()).ToString("000");
                    }

                    return newLDVid;
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

        public bool ThemLoaiDichVu(DTO_loaidichvu dTO_Loaidichvu)
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
                    string newLDVid = TaoMaLoaiDichVu();
                    if (string.IsNullOrEmpty(newLDVid))
                    {
                        // Xử lý khi không thể tạo mã khách hàng mới
                        return false;
                    }
                    
                    cmd.CommandText = "INSERT INTO loaidichvu (Maloaidichvu, TenLoaiDichVu) VALUES (@Maloaidichvu, @Tenloaidichvu)";

                    cmd.Parameters.AddWithValue("@Maloaidichvu", newLDVid);
                    cmd.Parameters.AddWithValue("@Tenloaidichvu", dTO_Loaidichvu.tenLoaiDichVu);

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
        public bool XoaLoaiDichVu(string maLoaidichvu)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "DELETE FROM loaidichvu WHERE maloaidichvu = @maloaidichvu";
                cmd.Parameters.AddWithValue("@maloaidichvu", maLoaidichvu);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // Trả về true nếu xóa thành công, ngược lại trả về false
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable TimLoaiDichVu(DTO_loaidichvu dTO_Loaidichvu)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM loaidichvu WHERE unaccent(lower(tenloaidichvu)) LIKE '%' || unaccent(lower(@tenloaidichvu)) || '%'";
                /*cmd.CommandText = "SELECT * FROM loaidichvu WHERE tenloaidichvu ILIKE '%' || @tenloaidichvu || '%'";*/
                //// unaccent để thực hiện tìm kiếm không phân biệt có dấu, không dấu. 
                //// ILIKE để thực hiện tìm kiếm không phân biệt chữ hoa, chữ thường.
                //// || @HoTen || được sử dụng để nối giá trị của tham số == CONCAT
                cmd.Parameters.AddWithValue("@tenloaidichvu", dTO_Loaidichvu.tenLoaiDichVu);

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
        public bool SuaLoaiDichVu(DTO_loaidichvu dTO_Loaidichvu)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE loaidichvu SET tenloaidichvu = @tenloaidichvu WHERE maloaidichvu = @maloaidichvu"; //

                cmd.Parameters.AddWithValue("@tenloaidichvu", dTO_Loaidichvu.tenLoaiDichVu);
                cmd.Parameters.AddWithValue("@maloaidichvu", dTO_Loaidichvu.maLoaiDichVu);
                

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // Trả về true nếu sửa thành công, ngược lại trả về false
            }
            finally
            {
                connection.Close();
            }
        }
        public string TimMaloaidichvutheoTen(string tenloaidichvu)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT maloaidichvu FROM loaidichvu WHERE tenloaidichvu = @tenloaidichvu";
                cmd.Parameters.AddWithValue("@tenloaidichvu", tenloaidichvu);

                // Sử dụng ExecuteScalar để lấy giá trị duy nhất (mã nhân viên)
                object result = cmd.ExecuteScalar();

                // Kiểm tra nếu kết quả không rỗng và có giá trị
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString(); // Trả về mã nhân viên
                }
                else
                {
                    return "Không tìm thấy mã nhân viên"; // Hoặc thông báo không tìm thấy
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
