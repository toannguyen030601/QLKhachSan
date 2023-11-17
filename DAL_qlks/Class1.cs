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
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from timnhanvien(@txttim)";
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
        public bool XoaNhanVien(int maNhanVien)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from nhanvien where manhanvien = @manv ";
                cmd.Parameters.AddWithValue("@manv", maNhanVien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
    }
}