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
    public class BUS_dichvu
    {
        DAL_dichvu dAL_Dichvu = new DAL_dichvu();

        public DataTable danhsachdichvu()
        {
            return dAL_Dichvu.danhsachdichvu();
        }
        public DataTable DanhSachLoaiDichVu()
        {
            return dAL_Dichvu.DanhSachLoaiDichVu();
        }
        public string TaoMaDichVu()
        {
            return dAL_Dichvu.TaoMaDichVu();
        }

        public bool ThemDichVu(DTO_dichvu dtoDichVu)
        {
            string newDVid = dAL_Dichvu.TaoMaDichVu();

            if (string.IsNullOrEmpty(newDVid))
            {
                // Xử lý khi không thể tạo mã khách hàng mới
                return false;
            }

            dtoDichVu.maDichVu = newDVid;
            return dAL_Dichvu.ThemDichVu(dtoDichVu);
        }
        public bool XoaDichVu(string maLoaidichvu)
        {
            return dAL_Dichvu.XoaDichVu(maLoaidichvu);
        }
        public DataTable TimDichVu(DTO_dichvu dTO_Dichvu)
        {
            return dAL_Dichvu.TimDichVu(dTO_Dichvu);
        }
        public bool SuaDichVu(DTO_dichvu dTO_dichvu)
        {
            return dAL_Dichvu.SuaDichVu(dTO_dichvu);
        }
    }
}
