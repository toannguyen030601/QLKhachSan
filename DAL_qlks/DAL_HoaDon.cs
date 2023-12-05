using DTO_qlks;
using Npgsql;
using NpgsqlTypes;
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
        public DataTable DanhSachHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT HoaDonPhong.MaHoaDon, HoaDonPhong.NgayNhanPhong, HoaDonPhong.NgayTraPhong,\r\n     " +
                    "  KhachHang.HoTen AS TenKhachHang,\r\n      " +
                    " NhanVien.HoTen AS TenNhanVien,\r\n       " +
                    "Phong.TenPhong\r\nFROM HoaDonPhong\r\nI" +
                    "NNER JOIN KhachHang ON HoaDonPhong.MaKhachHang = KhachHang.MaKhachHang\r\n" +
                    "INNER JOIN NhanVien ON HoaDonPhong.MaNhanVien = NhanVien.MaNV\r\n" +
                    "INNER JOIN Phong ON HoaDonPhong.MaPhong = Phong.MaPhong;";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                connection.Close();
            }
        }
        public string LayTenKhachHangTuMaHoaDon(string maHoaDon)
        {
            try
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT kh.hoten FROM khachhang kh " +
                              "JOIN hoadonphong hd ON kh.makhachhang = hd.makhachhang " +
                              "WHERE mahoadon = @mahoadon";

                    // Tạo tham số và đặt giá trị cho nó
                    cmd.Parameters.AddWithValue("@mahoadon",maHoaDon);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable TimKhachHang(string tenKH)
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

    }
}
