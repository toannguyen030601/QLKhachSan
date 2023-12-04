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
    public class BUS_LoaiPhong
    {
        DAL_LoaiPhong dAL_LoaiPhong=new DAL_LoaiPhong();
        public DataTable DanhSachLoaiPhong()
        {
            return dAL_LoaiPhong.DanhSachLoaiPhong();
        }
        public bool LuuLoaiPhong(DTO_LoaiPhong lp)
        {
            return dAL_LoaiPhong.LuuLoaiPhong(lp);
        }
        public bool CapNhatLoaiPhong(DTO_LoaiPhong lp)
        {
            return dAL_LoaiPhong.CapNhatLoaiPhong(lp);
        }

        public void XoaLoaiPhong(string maLoaiPhong)
        {
            dAL_LoaiPhong.XoaLoaiPhong(maLoaiPhong);
        }
        public bool CheckLoaiPhongTonTai(string maLoaiPhong)
        {
            return dAL_LoaiPhong.CheckLoaiPhongTonTai(maLoaiPhong);
        }
        public bool CheckXoaLoaiPhong(string maLoaiPhong)
        {
            return dAL_LoaiPhong.CheckXoaLoaiPhong(maLoaiPhong);
        }


    }
}
