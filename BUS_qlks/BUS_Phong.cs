using DAL_qlks;
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
    }
}
