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
    public class DAL_hoadonchitiet:DBConnect
    {
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
        public bool Luuhdct(DTO_hoadonchitiet hdct)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                try
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    // Check if MaHoaDonChiTiet already exists
                    string kiemtratontai = "SELECT COUNT(*) FROM ChiTietHoaDonPhong WHERE madichvu=@madichvu";
                    cmd.CommandText = kiemtratontai;
                    cmd.Parameters.AddWithValue("@madichvu", hdct.maDichVu);

                    int existingCount = Convert.ToInt32(cmd.ExecuteScalar());
                    int ketQua = 0;
                    if (existingCount > 0) //tồn tại thì update thêm 1
                    {
                        // tồn tại dịch thì update
                        cmd.CommandText = "UPDATE ChiTietHoaDonPhong SET SoLuong = soluong+1 WHERE madichvu = @madichvu";
                        cmd.Parameters.AddWithValue("@madichvu",hdct.maDichVu);
                        ketQua = Convert.ToInt32(cmd.ExecuteNonQuery());
                    }
                    else
                    {//không tồn tại
                        cmd.Parameters.Clear();
                        if (hdct.maHoaDonChiTiet!=null)
                        {
                            cmd.CommandText = "UPDATE ChiTietHoaDonPhong SET soluong = @soluong, mahoadon = @mahoadon, madichvu = @madichvu WHERE mahoadonchitiet = @mahoadonchitiet";
                            cmd.Parameters.AddWithValue("@soluong",hdct.soLuong);
                            cmd.Parameters.AddWithValue("@mahoadon", hdct.maHoaDon);
                            cmd.Parameters.AddWithValue("@madichvu", hdct.maDichVu);
                            cmd.Parameters.AddWithValue("@mahoadonchitiet", hdct.maHoaDonChiTiet);
                            ketQua = Convert.ToInt32(cmd.ExecuteNonQuery());
                        }
                        else
                        {
                            cmd.CommandText = "INSERT INTO ChiTietHoaDonPhong (MaHoaDonChiTiet, SoLuong, MaHoaDon, MaDichVu) VALUES (@MaHoaDonChiTiet, @SoLuong, @MaHoaDon, @MaDichVu)";
                            cmd.Parameters.AddWithValue("@MaHoaDonChiTiet", TaoMaHoaDonChiTiet());
                            cmd.Parameters.AddWithValue("@SoLuong", 1);
                            cmd.Parameters.AddWithValue("@MaHoaDon", hdct.maHoaDon);
                            cmd.Parameters.AddWithValue("@MaDichVu", hdct.maDichVu);
                            ketQua = Convert.ToInt32(cmd.ExecuteNonQuery());
                        }
                    }                            
                    return ketQua > 0; // Return true if the operation was successful
                }
                catch (Exception ex)
                {
                    // Handle exceptions here
                    throw;
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

        public DataTable DichVuDaChon()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ct.mahoadonchitiet,dv.tendichvu,dv.dongia,ct.soluong FROM chitiethoadonphong ct JOIN dichvu dv ON ct.madichvu = dv.madichvu";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally { connection.Close(); }
        }

    }
}
