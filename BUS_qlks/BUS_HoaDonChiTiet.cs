using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_qlks;
using DTO_qlks;

namespace BUS_qlks
{
    public class BUS_HoaDonChiTiet
    {
        DAL_qlks.DAL_HoaDonChiTiet dal_HDCT = new DAL_qlks.DAL_HoaDonChiTiet();
        public bool ThemHoaDonChiTiet(DTO_HoaDonChiTiet hoaDonChiTiet)
        {
            return dal_HDCT.ThemHoaDonChiTiet(hoaDonChiTiet);
        }
        public bool XoaHoaDonChiTiet(string maHoaDonChiTiet)
        {
            return dal_HDCT.XoaHoaDonChiTiet(maHoaDonChiTiet);
        }
        public bool SuaHoaDonChiTiet(DTO_HoaDonChiTiet suaDonChiTiet)
        {
            return dal_HDCT.SuaHoaDonChiTiet(suaDonChiTiet);
        }
        public string LayTenNhanVien(string manv)
        {
            return dal_HDCT.LayTenNhanVien(manv);
        }
        public string LayTenKhachHang(string makh)
        {
            return dal_HDCT.LayTenKhachHang(makh);
        }
        public DataTable DichVuDaSuDung(string maHoaDon)
        {
            return dal_HDCT.DichVuDaSuDung(maHoaDon);
        }
        public double GiaPhong(string maPhong)
        {
            return dal_HDCT.GiaPhong(maPhong);
        }
        public bool XoaHDCT(string mahdct)
        {
            return dal_HDCT.XoaHDCT(mahdct);
        }
        public DataTable DanhSachHDCT()
        {
            return dal_HDCT.DanhsachHDCT();
        }
        public bool LuuHDCT(DTO_HoaDonChiTiet hdct)
        {
            return dal_HDCT.Luuhdct(hdct);
        }
        public DataTable DichVuDaChon(string maHoaDon)
        {
            return dal_HDCT.DichVuDaChon(maHoaDon);
        }
        public bool ThanhToanPhong(string mahoadon, DateTime ngaytraphong, bool trangthai, string maphong)
        {
            return dal_HDCT.ThanhToanPhong(mahoadon, ngaytraphong, trangthai, maphong);
        }
    }
}
