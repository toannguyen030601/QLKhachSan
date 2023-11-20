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
        public bool XoaLoaiPhong(string maLoaiPhong)
        {
            return dAL_LoaiPhong.XoaLoaiPhong(maLoaiPhong);
        }
    }
}
