using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_qlks;

namespace BUS_qlks
{
    public class BUS_HoaDonChiTiet
    {
        DAL_qlks.DAL_HoaDonChiTiet dalHDCT = new DAL_qlks.DAL_HoaDonChiTiet();
        public bool ThemHoaDonChiTiet(DTO_HoaDonChiTiet hoaDonChiTiet)
        {
            return dalHDCT.ThemHoaDonChiTiet(hoaDonChiTiet);
        }
        public bool XoaHoaDonChiTiet(string maHoaDonChiTiet)
        {
            return dalHDCT.XoaHoaDonChiTiet(maHoaDonChiTiet);
        }
        public bool SuaHoaDonChiTiet(DTO_HoaDonChiTiet suaDonChiTiet)
        {
            return dalHDCT.SuaHoaDonChiTiet(suaDonChiTiet);
        }
        public string LayTenNhanVien(string manv)
        {
            return dalHDCT.LayTenNhanVien(manv);
        }
        public string LayTenKhachHang(string makh)
        {
            return dalHDCT.LayTenKhachHang(makh);
        }
        public DataTable DichVuDaSuDung(string maHoaDon)
        {
            return dalHDCT.DichVuDaSuDung(maHoaDon);
        }
        public double GiaPhong(string maPhong)
        {
            return dalHDCT.GiaPhong(maPhong);
        }
    }
}
