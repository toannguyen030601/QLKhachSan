﻿using DTO_qlks;
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

        public string GetLoaiPhongFromMaLoaiPhong(string maLoaiPhong)
        {
            string tenLoaiPhong = "";

            try
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT tenloaiphong FROM loaiphong WHERE maloaiphong = @maLoaiPhong";

                    // Use parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@maLoaiPhong", maLoaiPhong);

                    // Execute the query and get the result
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        tenLoaiPhong = result.ToString();
                    }
                }

                return tenLoaiPhong;
            }
            finally
            {
                connection.Close();
            }
        }


        public string TaoMaKhachHang()
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Tìm mã khách hàng trống nếu có
                cmd.CommandText = "SELECT MaKhachHang FROM KhachHang WHERE substring(MaKhachHang, 3) ~ '^[0-9]+$' ORDER BY substring(MaKhachHang, 3)::int DESC LIMIT 1";
                object result = cmd.ExecuteScalar();

                string newCustomerId = string.Empty;

                if (result != null && result != DBNull.Value)
                {
                    int lastNumber;
                    if (int.TryParse(result.ToString().Substring(2), out lastNumber))
                    {
                        newCustomerId = "KH" + (lastNumber + 1).ToString("000");
                    }
                }
                else
                {
                    // Lấy mã khách hàng mới từ cơ sở dữ liệu
                    cmd.CommandText = "SELECT COALESCE(MAX(CAST(substring(MaKhachHang, 3) AS int)), 0) + 1 FROM KhachHang WHERE substring(MaKhachHang, 3) ~ '^[0-9]+$'";
                    newCustomerId = "KH" + Convert.ToInt32(cmd.ExecuteScalar()).ToString("000");
                }

                return newCustomerId;
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây nếu cần
                // Ví dụ: throw ex; để ném exception lên lớp gọi
                // hoặc log lỗi
                throw;
            }
        }
        public string LayMaNhanVien(string email)
        {
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT manv FROM nhanvien WHERE email = @email";

                    // Tạo tham số và đặt giá trị cho nó
                    cmd.Parameters.AddWithValue("@email", email);
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
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }

        public bool DatPhong(string hoten, string sdt, string cccd, string gioitinh, string email, DateTime ngaynhanphong, string maphong)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Lấy mã khách hàng mới từ phương thức tạo mã
                string newCustomerId = TaoMaKhachHang();
                cmd.CommandText = "INSERT INTO KhachHang (MaKhachHang, HoTen, SoDT, SoCCCD, GioiTinh, MaNV) VALUES (@MaKhachHang, @HoTen, @SoDT, @SoCCCD, @GioiTinh, @MaNV)";

                cmd.Parameters.AddWithValue("@MaKhachHang", newCustomerId);
                cmd.Parameters.AddWithValue("@HoTen", hoten);
                cmd.Parameters.AddWithValue("@SoDT", sdt);
                cmd.Parameters.AddWithValue("@SoCCCD", cccd);
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                connection.Close();
                cmd.Parameters.AddWithValue("@MaNV", LayMaNhanVien(email));
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                NpgsqlCommand cmd2 = new NpgsqlCommand();
                cmd2.Connection = connection;
                cmd2.CommandType = CommandType.Text;

                // Lấy mã khách hàng mới từ phương thức tạo mã
                string HDId = TaoMaHoaDon();
                if (string.IsNullOrEmpty(HDId))
                {
                    // Xử lý khi không thể tạo mã khách hàng mới
                    return false;
                }

                cmd2.CommandText = "INSERT INTO hoadonphong (mahoadon,ngaynhanphong,makhachhang,manhanvien,maphong) VALUES (@mahoadon,@ngaynhanphong,@makhachhang,@manhanvien,@maphong)";

                cmd2.Parameters.AddWithValue("@mahoadon", HDId);
                cmd2.Parameters.AddWithValue("@ngaynhanphong", ngaynhanphong);
                cmd2.Parameters.AddWithValue("@makhachhang", newCustomerId);
                connection.Close();
                cmd2.Parameters.AddWithValue("@manhanvien",LayMaNhanVien(email));
                cmd2.Parameters.AddWithValue("@maphong", maphong);
                connection.Open();

                NpgsqlCommand cmd3 = new NpgsqlCommand();
                cmd3.Connection = connection;
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "update phong set trangthai=true where maphong=@maphong";
                cmd3.Parameters.AddWithValue("@maphong",maphong);
                cmd3.ExecuteNonQuery();
                int kq = cmd2.ExecuteNonQuery();
                if (kq > 0 && rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                // Trả về true nếu thêm thành công, ngược lại trả về false
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây nếu cần
                // Ví dụ: throw ex; để ném exception lên lớp gọi
                // hoặc log lỗi
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public string TaoMaHoaDon()
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                // Tìm mã khách hàng trống nếu có
                cmd.CommandText = "SELECT mahoadon FROM hoadonphong WHERE substring(mahoadon, 3) ~ '^[0-9]+$' ORDER BY substring(mahoadon, 3)::int DESC LIMIT 1";
                object result = cmd.ExecuteScalar();

                string newCustomerId = string.Empty;

                if (result != null && result != DBNull.Value)
                {
                    int lastNumber;
                    if (int.TryParse(result.ToString().Substring(2), out lastNumber))
                    {
                        newCustomerId = "HD" + (lastNumber + 1).ToString("000");
                    }
                }
                else
                {
                    // Lấy mã khách hàng mới từ cơ sở dữ liệu
                    cmd.CommandText = "SELECT COALESCE(MAX(CAST(substring(mahoadon, 3) AS int)), 0) + 1 FROM hoadonphong WHERE substring(mahoadon, 3) ~ '^[0-9]+$'";
                    newCustomerId = "HD" + Convert.ToInt32(cmd.ExecuteScalar()).ToString("000");
                }

                return newCustomerId;
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây nếu cần
                // Ví dụ: throw ex; để ném exception lên lớp gọi
                // hoặc log lỗi
                throw;
            }
        }
    }
}
