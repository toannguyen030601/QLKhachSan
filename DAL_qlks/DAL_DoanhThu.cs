using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_qlks
{
    public class DAL_DoanhThu:DBConnect
    {
        public DataTable DoanhThuDichVu(DateTime bd, DateTime kt)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT dv.tendichvu,dv.dongia, SUM(ct.soluong) AS soluong, SUM(ct.soluong*dv.dongia) AS tongtien " +
                                  "FROM hoadonphong hd " +
                                  "JOIN chitiethoadonphong ct ON hd.mahoadon = ct.mahoadon " +
                                  "JOIN dichvu dv ON ct.madichvu = dv.madichvu " +
                                  "WHERE hd.ngaytraphong BETWEEN @bd AND @kt " +
                                  "GROUP BY dv.tendichvu";

                cmd.Parameters.AddWithValue("@bd", bd);
                cmd.Parameters.AddWithValue("@kt", kt);

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
