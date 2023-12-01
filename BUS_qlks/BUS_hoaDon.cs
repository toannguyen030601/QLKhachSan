﻿using DAL_qlks;
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
            return dal.ThanhToanPhong(mahoadon,ngaytraphong,trangthai,maphong);
        }
    }
}
