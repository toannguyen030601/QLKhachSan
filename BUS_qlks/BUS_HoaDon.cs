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
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_HoaDon=new DAL_HoaDon();
        public DataTable LayHoaDon(string maHoaDon)
        {
            return dal_HoaDon.LayHoaDon(maHoaDon);
        }
    }
}
