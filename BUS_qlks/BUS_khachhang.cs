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
    public class BUS_khachhang
    {
        DAL_khachhang dalKhachHang = new DAL_khachhang();

        public DataTable TimKhachHang(DTO_khachhang khachHang)
        {
            return dalKhachHang.TimKhachHang(khachHang);
        }

        public bool ThemKhachHang(DTO_khachhang khachHang)
        {
            string newCustomerId = dalKhachHang.TaoMaKhachHang();

            if (string.IsNullOrEmpty(newCustomerId))
            {
                // Xử lý khi không thể tạo mã khách hàng mới
                return false;
            }

            khachHang.Makhachhang = newCustomerId;
            return dalKhachHang.ThemKhachHang(khachHang);
        }



        public bool SuaKhachHang(DTO_khachhang khachHang)
        {
            return dalKhachHang.SuaKhachHang(khachHang);
        }

        public bool XoaKhachHang(string maKhachHang)
        {
            return dalKhachHang.XoaKhachHang(maKhachHang);
        }

        public DataTable LayDuLieuKhachHang()
        {
            return dalKhachHang.LayDuLieuKhachHang();
        }
    }
}
