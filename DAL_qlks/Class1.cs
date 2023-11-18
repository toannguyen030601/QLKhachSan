using DTO_qlks;
using Npgsql;
using System.Data;

namespace DAL_qlks
{
    public class Class1 : DBConnect
    {
        public DataTable danhsachnhanvien()
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection= connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from danhsachnhanvien()";
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

        public DataTable timnhanvien(string tennv)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                /*cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from timnhanvien(@txttim)";*/
                string sql = @"select * from timnhanvien(@txttim)";
                cmd = new NpgsqlCommand(sql,connection);
                cmd.Parameters.AddWithValue("@txttim", tennv);
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

        public bool ThemNhanVien(DTO_nhanvien dtonv)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string sql = @"SELECT * from themnhanvien(@socccd, @hoTen, @gioitinh, @chucvu, @ngaysinh, @email, @diachi, @hinhanh, @matkhau, @sodienthoai)";
                /*cmd.CommandText = @"SELECT * from them_nhanvien(p_socccd, p_hoTen, p_gioitinh, p_chucvu, p_ngaysinh, p_email, p_diachi, p_hinhanh, p_matkhau, p_sodienthoai)";*/
                cmd= new NpgsqlCommand(sql,connection);
                cmd.Parameters.AddWithValue("@socccd", dtonv.Socccd);
                cmd.Parameters.AddWithValue("@hoTen", dtonv.Hoten);
                cmd.Parameters.AddWithValue("@gioitinh", dtonv.Gioitinh);
                cmd.Parameters.AddWithValue("@chucvu", dtonv.Chucvu);
                cmd.Parameters.AddWithValue("@ngaysinh", dtonv.Ngaysinh);
                cmd.Parameters.AddWithValue("@email", dtonv.Email);
                cmd.Parameters.AddWithValue("@diachi", dtonv.Diachi);
                cmd.Parameters.AddWithValue("@hinhanh", dtonv.Hinhanh);
                cmd.Parameters.AddWithValue("@matkhau", dtonv.Matkhau);
                cmd.Parameters.AddWithValue("@sodienthoai", dtonv.Sodienthoai);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
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

        public bool XoaNhanVien(string maNhanVien)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from nhanvien where manv = @manv ";
                cmd.Parameters.AddWithValue("@manv", maNhanVien);
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
    }
}