using DAL_qlks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_qlks
{
    public class BUS_DoanhThu
    {
        DAL_DoanhThu dal_DoanhThu=new DAL_DoanhThu();
        public DataTable DoanhThuDichVu(DateTime bd,DateTime kt)
        {
            return dal_DoanhThu.DoanhThuDichVu(bd,kt);
        }
    }
}
