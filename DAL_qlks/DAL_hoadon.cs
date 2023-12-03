using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_qlks
{
    public class DAL_hoadon : DBConnect
    {
        public DataTable danhsachhoadon()
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from danhSachHoaDon1()";
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

        public DataTable TimHoaDon(DateTime ngayTim)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "timhoadon";

                // Thêm tham số cho DateTime
                cmd.Parameters.AddWithValue("@p_ngaytim", ngayTim);

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
        public DataTable timkhachhang(string tenKH)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from timkhachhang(@txttim)";
                /*string sql = @"select * from timnhanvien(@txttim)";
                cmd = new NpgsqlCommand(sql,connection);*/
                cmd.Parameters.AddWithValue("@txttim", tenKH);
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

        public string TenKhachHanhCuaHD(string maHoaDon)
        {
            string tenKhachHang = "";

            try
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    // Sử dụng thời điểm cụ thể thay vì null
                    cmd.CommandText = "SELECT kh.hoten FROM hoadonphong hd join khachhang kh " +
                        "on hd.makhachhang=kh.makhachhang where mahoadon=@mahoadon";

                    // Sử dụng parameters để tránh SQL injecti on
                    cmd.Parameters.AddWithValue("@mahoadon", maHoaDon);

                    // Thực hiện truy vấn và lấy kết quả
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        maHoaDon = result.ToString();
                    }
                }

                return maHoaDon;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
