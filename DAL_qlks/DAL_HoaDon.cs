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
    public class DAL_HoaDon:DBConnect
    {
        public DataTable LayHoaDon(string maHoaDon)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select *from hoadonphong where mahoadon=@mahoadon";

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

    }
}
