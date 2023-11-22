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
        public void LuuPhong(DTO_Phong p)
        {
            dal_Phong.LuuPhong(p);
        }
        public void XoaPhong(string maPhong)
        {
            dal_Phong.XoaPhong(maPhong); 
        }

    }
}
