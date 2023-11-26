using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_qlks;
using DTO_qlks;

namespace BUS_qlks
{
    public class BUS_loaidichvu
    {
        DAL_loaidichvu dAL_Loaidichvu = new DAL_loaidichvu();

        public DataTable danhsachloaidichvu()
        {
            return dAL_Loaidichvu.DanhSachLoaiDichVu();
        }

        public bool ThemLoaiDichVu(DTO_loaidichvu dtoloaidichvu)
        {
            string newCustomerId = dAL_Loaidichvu.TaoMaLoaiDichVu();

            if (string.IsNullOrEmpty(newCustomerId))
            {
                // Xử lý khi không thể tạo mã khách hàng mới
                return false;
            }

            dtoloaidichvu.maLoaiDichVu = newCustomerId;
            return dAL_Loaidichvu.ThemLoaiDichVu(dtoloaidichvu);
        }
        public bool XoaLoaiDichVu(string maLoaidichvu)
        {
            return dAL_Loaidichvu.XoaLoaiDichVu(maLoaidichvu);
        }
        public DataTable TimLoaiDichVu(DTO_loaidichvu dTO_Loaidichvu)
        {
            return dAL_Loaidichvu.TimLoaiDichVu(dTO_Loaidichvu);
        }
        public bool SuaLoaiDichVu(DTO_loaidichvu dTO_Loaidichvu)
        {
            return dAL_Loaidichvu.SuaLoaiDichVu(dTO_Loaidichvu);
        }
        public string TimMaloaidichvutheoTen(string tenloaidichvu)
        {
            return dAL_Loaidichvu.TimMaloaidichvutheoTen(tenloaidichvu);
        }
    }
}
