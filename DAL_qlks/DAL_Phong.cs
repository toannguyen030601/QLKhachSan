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
    public class DAL_Phong:DBConnect
    {
        public DataTable DanhSachPhong()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Phong";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally { connection.Close(); }
        }
        public void LuuPhong(DTO_Phong p)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "luuphong";
                cmd.Parameters.AddWithValue("@p_maphong",p.MaPhong);
                cmd.Parameters.AddWithValue("@p_tenphong", p.TenPhong);
                cmd.Parameters.AddWithValue("@p_gia", p.Gia);
                cmd.Parameters.AddWithValue("@p_trangthai", p.TrangThai);
                cmd.Parameters.AddWithValue("@p_maloaiphong", p.MaLoaiPhong);
                cmd.ExecuteNonQuery();
            }
            finally { connection.Close(); }
        }
        public void XoaPhong(string maPhong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoaphong";
                cmd.Parameters.AddWithValue("@p_maphong", maPhong);
                cmd.ExecuteNonQuery();
                /*int affectedRows = Convert.ToInt16(cmd.ExecuteNonQuery());*/

               /* if (affectedRows > 0)
                {
                    return true;
                }
                
                else
                {
                    return false;
                }*/
            }
            finally { connection.Close(); }
        }
    }
}
