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
                cmd.CommandText = "select * from loaiphong";
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
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into loaiphong(maloaiphong,tenloaiphong) values (@maloaiphong,@tenloaiphong)";
                // Thêm tham số đầu vào
                cmd.Parameters.AddWithValue("@maloaiphong", lp.MaLoaiPhong);
                cmd.Parameters.AddWithValue("@tenloaiphong", lp.TenLoaiPhong);

                // Thực thi stored procedure
                int kq=Convert.ToInt16(cmd.ExecuteNonQuery());
                return kq>0;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool CapNhatLoaiPhong(DTO_LoaiPhong lp)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update loaiphong set tenloaiphong=@tenloaiphong where maloaiphong=@maloaiphong";
                // Thêm tham số đầu vào
                cmd.Parameters.AddWithValue("@maloaiphong", lp.MaLoaiPhong);
                cmd.Parameters.AddWithValue("@tenloaiphong", lp.TenLoaiPhong);

                // Thực thi stored procedure
                int kq = Convert.ToInt16(cmd.ExecuteNonQuery());
                return kq > 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool XoaLoaiPhong(string maLoaiPhong)
        {
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand("XoaLoaiPhong", connection))
                {
                    cmd.CommandType = CommandType.Text;

                    // Thêm tham số đầu vào
                    cmd.CommandText = "delete from loaiphong where maloaiphong=@maloaiphong";
                    cmd.Parameters.AddWithValue("@maloaiphong", maLoaiPhong);
                    connection.Open();
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
        public bool CheckLoaiPhongTonTai(string maLoaiPhong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from loaiphong where maloaiphong=@maloaiphong";
                // Thêm tham số đầu vào
                cmd.Parameters.AddWithValue("@maloaiphong", maLoaiPhong);
                // Thực thi stored procedure
                int kq = Convert.ToInt16(cmd.ExecuteScalar());
                return kq > 0;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool CheckXoaLoaiPhong(string maLoaiPhong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from phong where maloaiphong=@maloaiphong";
                // Thêm tham số đầu vào
                cmd.Parameters.AddWithValue("@maloaiphong", maLoaiPhong);
                // Thực thi stored procedure
                int kq = Convert.ToInt16(cmd.ExecuteScalar());
                return kq > 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
