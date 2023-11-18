using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_nhanvien
    {
        private string socccd;
        private string hoten;
        private string gioitinh;
        private string chucvu;
        private string ngaysinh;
        private string email;
        private string diachi;
        private string hinhanh;
        private string matkhau;
        private string sodienthoai;

        public string Socccd
        {
            get { return socccd; }
            set { socccd = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value;}
        }
        public string Chucvu
        {
            get { return chucvu; }
            set{chucvu = value;}
        }
        public string Ngaysinh
        {
            get { return ngaysinh; }
            set{ngaysinh = value;}
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set{diachi = value;}
        }
        public string Hinhanh
        {
            get { return hinhanh; }
            set{hinhanh = value;}
        }
        public string Matkhau
        {
            get { return matkhau; }
            set{matkhau = value;}
        }

        public string Sodienthoai
        {
            get { return sodienthoai; }
            set{sodienthoai = value;}
        }

        public DTO_nhanvien(string socccd, string hoten, string gioitinh, string chucvu, string ngaysinh, string email, string diachi, string hinhanh, string matkhau, string sodienthoai)
        {
            this.Socccd = socccd;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Chucvu = chucvu;
            this.Ngaysinh = ngaysinh;
            this.Email = email;
            this.Diachi = diachi;
            this.Hinhanh = hinhanh;
            this.Matkhau = matkhau;
            this.Sodienthoai = sodienthoai;
        }
        public DTO_nhanvien(string socccd, string hoten, string gioitinh, string chucvu, string ngaysinh, string email, string diachi, string hinhanh, string sodienthoai)
        {
            this.Socccd = socccd;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Chucvu = chucvu;
            this.Ngaysinh = ngaysinh;
            this.Email = email;
            this.Diachi = diachi;
            this.Hinhanh = hinhanh;
            this.Sodienthoai = sodienthoai;
        }
        public DTO_nhanvien() { }
    }
}
