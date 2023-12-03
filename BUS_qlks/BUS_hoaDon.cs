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
    public class BUS_hoaDon
    {
        DAL_hoadonchitiet dal = new DAL_hoadonchitiet();
        DAL_qlks.DAL_hoadon dalHD = new DAL_qlks.DAL_hoadon();
        public bool XoaHDCT(string mahdct)
        {
            return dal.XoaHDCT(mahdct);
        }
        public DataTable DanhSachHoaDon()
        {
      
            return dalHD.danhsachhoadon();
        }
        public DataTable DanhSachHDCT()
        {
            return dal.DanhsachHDCT();
        }
        public DataTable TimHoaDon(DateTime ngayTim)
        {
        
            return dalHD.TimHoaDon(ngayTim);
        }
        public bool LuuHDCT(DTO_hoadonchitiet hdct)
        {
            return dal.Luuhdct(hdct);
        }
        public DataTable timkhachhang(string tenKH)
        {
           return dalHD.timkhachhang(tenKH);
        }
        public DataTable DichVuDaChon()
        {
            return dal.DichVuDaChon();
        }
        public bool ThanhToanPhong(string mahoadon, DateTime ngaytraphong, bool trangthai, string maphong)
        {
            return dal.ThanhToanPhong(mahoadon,ngaytraphong,trangthai,maphong);
        }
        public string LayTenKhachHangCuaHoaDon(string maHoaDon)
        {
            return dalHD.TenKhachHanhCuaHD(maHoaDon);
        }
        DAL_hoadonchitiet dal = new DAL_hoadonchitiet();
        public bool XoaHDCT(string mahdct)
        {
            return dal.XoaHDCT(mahdct);
        }
        public DataTable DanhSachHDCT()
        {
            return dal.DanhsachHDCT();
        }
        public bool LuuHDCT(DTO_hoadonchitiet hdct)
        {
            return dal.Luuhdct(hdct);
        }
        public DataTable DichVuDaChon()
        {
            return dal.DichVuDaChon();
        }
        public bool ThanhToanPhong(string mahoadon, DateTime ngaytraphong, bool trangthai, string maphong)
        {
            return dal.ThanhToanPhong(mahoadon, ngaytraphong, trangthai, maphong);
        }
    }
}
