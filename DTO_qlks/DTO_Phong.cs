using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_Phong
    {
        private string maPhong;
        private string tenPhong;
        private double gia;
        private bool trangThai;
        private string maLoaiPhong;
        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }
        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai=value; }
        }
        public string MaLoaiPhong
        {
            get { return maLoaiPhong; }
            set { maLoaiPhong = value;}
        }

        public DTO_Phong() { }
        public DTO_Phong(string maPhong,string tenPhong,double gia,bool trangThai,string maLoaiPhong)
        {
            this.MaPhong = maPhong;
            this.TenPhong= tenPhong;
            this.Gia= gia;
            this.TrangThai= trangThai;
            this.MaLoaiPhong= maLoaiPhong;
        }   
    }
}
