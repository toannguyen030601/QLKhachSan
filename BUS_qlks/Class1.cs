using System.Data;

namespace BUS_qlks
{
    public class Class1
    {
        DAL_qlks.Class1 dalnv = new DAL_qlks.Class1();
        public DataTable danhsachnhanvien()
        {
            return dalnv.danhsachnhanvien();
        }

        public DataTable timnhanvien(string tennv)
        {
            return dalnv.timnhanvien(tennv);
        }
    }
}