using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_khachhang
    {
        private string makhachhang;
        private string hoten;
        private string sodt;
        private string socccd;
        private string gioitinh;
        private string manv;

        public string Makhachhang
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Sodt
        {
            get { return sodt; }
            set { sodt = value; }
        }
        public string Socccd
        {
            get { return socccd; }
            set { socccd = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        public DTO_khachhang(string makhachhang, string hoten, string sodt, string socccd, string gioitinh, string manv)
        {
            this.Makhachhang = makhachhang;
            this.Hoten = hoten;
            this.Sodt = sodt;
            this.Socccd = socccd;
            this.Gioitinh = gioitinh;
            this.Manv = manv;
        }

        public DTO_khachhang() { }
    }
}
