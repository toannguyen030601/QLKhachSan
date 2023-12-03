using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_HoaDon
    {
        /*    MaHoaDon varchar(15) PRIMARY KEY,
        NgayNhanPhong DATE,
        NgayTraPhong DATE,
        MaKhachHang varchar(8),
        MaNhanVien varchar(8),
        MaPhong varchar(8),*/
        private string mahoadon;
        private DateTime ngaynhanphong;
        private DateTime ngaytraphong;
        private string makhachhang;
        private string manhanvien;
        private string maphong;
        public string Mahoadon
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
        public DateTime Ngaynhanphong
        {
            set {  ngaynhanphong=value; }
            get { return ngaynhanphong;}
        }
        public DateTime Ngaytraphong
        {
            set { ngaytraphong = value;}
            get { return ngaytraphong;}        
        }
        public string Makhachhang
        {
            set { makhachhang = value; }
            get { return makhachhang;}
        }
        public string Manhanvien
        {
            set { makhachhang = value; }
            get { return manhanvien; }
        }
        public string Maphong
        {
            set { makhachhang = value; }
            get { return maphong; }
        }
        public DTO_HoaDon() { }
        public DTO_HoaDon(string mahoadon,DateTime ngaynhanphong,DateTime ngaytraphong,string makhachhang,string manhanvien,string maphong)
        {
            this.Mahoadon = mahoadon;
            this.Ngaynhanphong = ngaynhanphong;
            this.Ngaytraphong=ngaytraphong;
            this.Makhachhang = makhachhang;
            this.Manhanvien = manhanvien;
            this.Maphong = maphong;
        }
    }

}
