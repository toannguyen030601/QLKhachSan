using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_hoadonchitiet
    {
        private string MaHoaDonChiTiet { get; set; }
        private int SoLuong { get; set; }
        private string MaHoaDon { get; set; }
        private string MaDichVu { get; set; }

        public string maHoaDonChiTiet
        {
            get { return MaHoaDonChiTiet; }
            set { MaHoaDonChiTiet = value; }
        }
        public int soLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
        public string maHoaDon
        {
            get { return MaHoaDon; }
            set { MaHoaDon = value; }
        }
        public string maDichVu
        {
            get { return MaDichVu; }
            set { MaDichVu = value; }
        }
        public DTO_hoadonchitiet(string MaHoaDonChiTiet,int SoLuong,string MaHoaDon,string MaDichVu)
        {
            this.maHoaDonChiTiet= MaHoaDonChiTiet;
            this.soLuong= SoLuong;
            this.maHoaDon= MaHoaDon;
            this.maDichVu= MaDichVu;
        }
        public DTO_hoadonchitiet() 
        {
        
        }
    }
}
