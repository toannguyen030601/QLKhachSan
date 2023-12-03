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
        public bool XoaHDCT(string mahdct)
        DAL_qlks.DAL_hoadon dalnv = new DAL_qlks.DAL_hoadon(); 
        public DataTable DanhSachHoaDon()
        {
            return dal.XoaHDCT(mahdct);
            return dalnv.danhsachhoadon();
        }
        public DataTable DanhSachHDCT()
        public DataTable TimHoaDon(DateTime ngayTim)
        {
            return dal.DanhsachHDCT();
            return dalnv.TimHoaDon(ngayTim);
        }
        public bool LuuHDCT(DTO_hoadonchitiet hdct)
        public DataTable timkhachhang(string tenKH)
        {
            return dal.Luuhdct(hdct);
        }
        public DataTable DichVuDaChon()
        {
            return dal.DichVuDaChon();
        }
        public bool ThanhToanPhong(string mahoadon, DateTime ngaytraphong, bool trangthai, string maphong)
        {
            return dal.ThanhToanPhong(mahoadon,ngaytraphong,trangthai,maphong);
        }
    }
}
