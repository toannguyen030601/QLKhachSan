using DAL_qlks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_qlks
{
    public class BUS_dichvu
    {
        DAL_dichvu busnv = new DAL_dichvu();
        public DataTable Danhsachdvu()
        {
            return busnv.Danhsachdvu();
        }
    }
}
