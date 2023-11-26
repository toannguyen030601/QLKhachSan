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
        DAL_qlks.DAL_hoadon dalnv = new DAL_qlks.DAL_hoadon(); 
        public DataTable DanhSachHoaDon()
        {
            return dalnv.danhsachhoadon();
        }
    }
}
