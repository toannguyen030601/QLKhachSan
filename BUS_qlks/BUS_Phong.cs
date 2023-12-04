using DAL_qlks;
using DTO_qlks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_qlks
{
    public class BUS_Phong
    {
        DAL_Phong dal_Phong = new DAL_Phong();
        public DataTable DanhSachPhong()
        {
            return dal_Phong.DanhSachPhong();
        }
        public bool LuuPhong(DTO_Phong p)
        {
            return dal_Phong.LuuPhong(p);
        }
        public bool XoaPhong(string maPhong)
        {
           return dal_Phong.XoaPhong(maPhong); 
        }
        public string GetLoaiPhongFromMaLoaiPhong(string maLoaiPhong)
        {
            return dal_Phong.GetLoaiPhongFromMaLoaiPhong(maLoaiPhong);
        }
        public bool DatPhong(string hoten, string sdt, string cccd, string gioitinh, string email, DateTime ngaynhanphong, string maphong)
        {
            return dal_Phong.DatPhong(hoten,sdt,cccd,gioitinh,email,ngaynhanphong,maphong);
        }
        public string LayMaNV(string email)
        {
            return dal_Phong.LayMaNhanVien(email);
        }
        public string MaHoaDonCuaPhong(string maPhong)
        {
            return dal_Phong.MaHoaDonCuaPhong(maPhong);
        }
        public bool CheckMaPhong(string maPhong)
        {
            return dal_Phong.CheckMaPhong(maPhong);
        }
        public bool CheckXoaPhong(string maPhong)
        {
            return dal_Phong.CheckXoaPhong(maPhong);
        }

    }
}
