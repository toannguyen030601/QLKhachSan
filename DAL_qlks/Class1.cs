using DTO_qlks;
using Npgsql;
using System.Data;

namespace DAL_qlks
{
    public class Class1 : DBConnect
    {
        public bool dangnhap(DTO_nhanvien dtonv)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from nhanvien where @email = email and @matkhau = matkhau";
                cmd.Parameters.AddWithValue("@email", dtonv.Email);
                cmd.Parameters.AddWithValue("@matkhau", dtonv.Matkhau);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool checkemail(string email)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from nhanvien where @email = email";
                cmd.Parameters.AddWithValue("@email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;

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

        public bool updatematkhau(string email, string matkhau)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nhanvien set matkhau = @matkhau where email = @email";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

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
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from timnhanvien(@txttim)";
                /*string sql = @"select * from timnhanvien(@txttim)";
                cmd = new NpgsqlCommand(sql,connection);*/
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
                cmd.CommandText = @"SELECT * from themnhanvien(@p_socccd, @p_hoTen, @p_gioitinh, @p_chucvu, @p_ngaysinh, @p_email, @p_diachi, @p_hinhanh, @p_matkhau, @p_sodienthoai)";
                cmd.Parameters.AddWithValue("@p_socccd", dtonv.Socccd);
                cmd.Parameters.AddWithValue("@p_hoTen", dtonv.Hoten);
                cmd.Parameters.AddWithValue("@p_gioitinh", dtonv.Gioitinh);
                cmd.Parameters.AddWithValue("@p_chucvu", dtonv.Chucvu);
                cmd.Parameters.AddWithValue("@p_ngaysinh", dtonv.Ngaysinh);
                cmd.Parameters.AddWithValue("@p_email", dtonv.Email);
                cmd.Parameters.AddWithValue("@p_diachi", dtonv.Diachi);
                cmd.Parameters.AddWithValue("@p_hinhanh", dtonv.Hinhanh);
                cmd.Parameters.AddWithValue("@p_matkhau", dtonv.Matkhau);
                cmd.Parameters.AddWithValue("@p_sodienthoai", dtonv.Sodienthoai);
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

        public bool SuaNhanVien(DTO_nhanvien dtonv)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * from update_nhanvien(@p_socccd, @p_hoTen, @p_gioitinh, @p_chucvu, @p_ngaysinh, @p_email, @p_diachi, @p_hinhanh, @p_sodienthoai)";
                cmd.Parameters.AddWithValue("@p_socccd", dtonv.Socccd);
                cmd.Parameters.AddWithValue("@p_hoTen", dtonv.Hoten);
                cmd.Parameters.AddWithValue("@p_gioitinh", dtonv.Gioitinh);
                cmd.Parameters.AddWithValue("@p_chucvu", dtonv.Chucvu);
                cmd.Parameters.AddWithValue("@p_ngaysinh", dtonv.Ngaysinh);
                cmd.Parameters.AddWithValue("@p_email", dtonv.Email);
                cmd.Parameters.AddWithValue("@p_diachi", dtonv.Diachi);
                cmd.Parameters.AddWithValue("@p_hinhanh", dtonv.Hinhanh);
                cmd.Parameters.AddWithValue("@p_sodienthoai", dtonv.Sodienthoai);
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

        public DataTable thongtinnhanvien(string email)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from nhanvien where email = @email";
                cmd.Parameters.AddWithValue("@email", email);
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