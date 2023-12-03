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
    public class DAL_dichvu : DBConnect
    {
        public DataTable Danhsachdvu()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select dv.madichvu,dv.tendichvu,dv.dongia from dichvu dv";//Chỉ hiển thị lên datagrid nếu muốn hiển thị theo combobox thì làm khác
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally { connection.Close(); }
        }
        //
        public DataTable timdvu(string tendv)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from timdichvu(@p_tukhoa)";
                cmd.Parameters.AddWithValue("@p_tukhoa",tendv);
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
        public DataTable danhsachdichvu()
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT dv.MaDichVu, dv.TenDichVu, dv.DonGia, dv.DonViTinh, ldv.TenLoaiDichVu\r\nFROM DichVu dv\r\nINNER JOIN LoaiDichVu ldv ON dv.MaLoaiDichVu = ldv.MaLoaiDichVu;";
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
                    cmd.CommandText = "SELECT MaLoaiDichVu, TenLoaiDichVu FROM LoaiDichVu";
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
        public string TaoMaDichVu()
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
                    cmd.CommandText = "SELECT madichvu FROM dichvu WHERE substring(madichvu, 3) ~ '^[0-9]+$' ORDER BY substring(madichvu, 3)::int DESC LIMIT 1";
                    object result = cmd.ExecuteScalar();

                    string newDVid = string.Empty;

                    if (result != null && result != DBNull.Value)
                    {
                        int lastNumber;
                        if (int.TryParse(result.ToString().Substring(2), out lastNumber))
                        {
                            newDVid = "DV" + (lastNumber + 1).ToString("000");
                        }
                    }
                    else
                    {
                        // Lấy mã khách hàng mới từ cơ sở dữ liệu
                        cmd.CommandText = "SELECT COALESCE(MAX(CAST(substring(madichvu, 3) AS int)), 0) + 1 FROM dichvu WHERE substring(madichvu, 3) ~ '^[0-9]+$'";
                        newDVid = "DV" + Convert.ToInt32(cmd.ExecuteScalar()).ToString("000");
                    }

                    return newDVid;
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
        public bool ThemDichVu(DTO_dichvu dtodichvu)
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
                    string newDVid = TaoMaDichVu();
                    if (string.IsNullOrEmpty(newDVid))
                    {
                        // Xử lý khi không thể tạo mã khách hàng mới
                        return false;
                    }

                    cmd.CommandText = "INSERT INTO dichvu (madichvu, tendichvu, dongia, donvitinh, maloaidichvu) VALUES (@madichvu, @tendichvu, @dongia, @donvitinh, @maloaidichvu)";

                    cmd.Parameters.AddWithValue("@madichvu", newDVid);
                    cmd.Parameters.AddWithValue("@tendichvu", dtodichvu.tenDichVu);
                    cmd.Parameters.AddWithValue("@dongia", dtodichvu.donGia);
                    cmd.Parameters.AddWithValue("@donvitinh", dtodichvu.donViTinh);
                    cmd.Parameters.AddWithValue("@maloaidichvu", dtodichvu.maLoaiDichVu);

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

        public bool XoaDichVu(string madichvu)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "DELETE FROM dichvu WHERE madichvu = @madichvu";
                cmd.Parameters.AddWithValue("@madichvu", madichvu);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // Trả về true nếu xóa thành công, ngược lại trả về false
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable TimDichVu(DTO_dichvu dTO_Dichvu)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM dichvu WHERE tendichvu ILIKE '%' || @tendichvu || '%'";
                ///ILIKE để thực hiện tìm kiếm không phân biệt chữ hoa, chữ thường.
                /// || @HoTen || được sử dụng để nối giá trị của tham số == CONCAT
                cmd.Parameters.AddWithValue("@tendichvu", dTO_Dichvu.tenDichVu);

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
        public bool SuaDichVu(DTO_dichvu dTO_Dichvu)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE DichVu SET TenDichVu = @tendichvu, DonGia = @dongia, DonViTinh = @donvitinh, MaLoaiDichVu = @maloaidichvu WHERE MaDichVu = @madichvu";

                cmd.Parameters.AddWithValue("@madichvu", dTO_Dichvu.maDichVu);
                cmd.Parameters.AddWithValue("@tendichvu", dTO_Dichvu.tenDichVu);
                cmd.Parameters.AddWithValue("@dongia", dTO_Dichvu.donGia);
                cmd.Parameters.AddWithValue("@donvitinh", dTO_Dichvu.donViTinh);
                cmd.Parameters.AddWithValue("@maloaidichvu", dTO_Dichvu.maLoaiDichVu);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // Trả về true nếu sửa thành công, ngược lại trả về false
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SuaDichVu: " + ex.Message);
                // You might want to log the exception details or show a message box with the error.
                return false; // or throw the exception if you want to propagate it further.
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
