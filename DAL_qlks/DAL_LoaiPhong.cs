using DTO_qlks;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL_qlks
{
    public class DAL_LoaiPhong:DBConnect
    {
        public DataTable DanhSachLoaiPhong()
        {
            DataTable dt= new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from LoaiPhong";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally { connection.Close(); }
        }
        public bool LuuLoaiPhong(DTO_LoaiPhong lp)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd=new NpgsqlCommand();
                cmd.Connection= connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "luuloaiphong";
                // Thêm tham số đầu vào
                cmd.Parameters.AddWithValue("@p_maloaiphong", lp.MaLoaiPhong);
                cmd.Parameters.AddWithValue("@p_tenloaiphong", lp.TenLoaiPhong);

                // Thực thi stored procedure
                if (Convert.ToInt16(cmd.ExecuteNonQuery())>0)
                {
                    return true;
                }        
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool CapNhatLoaiPhong(string maLoaiPhong,string tenLoaiPhong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CapNhatLoaiPhong";
                cmd.Parameters.AddWithValue("@MaLoaiPhong", maLoaiPhong);
                cmd.Parameters.AddWithValue("@TenLoaiPhong", tenLoaiPhong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally { connection.Close(); }
        }
        public bool XoaLoaiPhong(string maLoaiPhong)
        {
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("XoaLoaiPhong", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    cmd.Parameters.AddWithValue("@p_maloaiphong", maLoaiPhong);
                    connection.Open();
                    // Thực thi stored procedure
                    if(Convert.ToInt16(cmd.ExecuteNonQuery()) > 0)
                    {
                        return true;
                    }
                }
            }
    
            finally
            {
                connection.Close();
            }
            return false;
        }
    }
}
