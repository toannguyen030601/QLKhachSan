using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_dichvu
    {
        private string MaDichVu;
        private string TenDichVu;
        private double DonGia;
        private string DonViTinh;
        private string MaLoaiDichVu;

        public string maDichVu
        {
            get { return MaDichVu; }
            set { MaDichVu = value; }
        }
        public string tenDichVu
        {
            get { return TenDichVu; }
            set { TenDichVu = value; }
        }
        public double donGia
        {
            get { return DonGia; }
            set { DonGia = value; }
        }
        public string donViTinh
        {
            get { return DonViTinh; }
            set { DonViTinh = value; }
        }
        public string maLoaiDichVu
        {
            get { return MaLoaiDichVu; }
            set { MaLoaiDichVu = value; }
        }

        public DTO_dichvu(string MaDichVu, string TenDichVu, double DonGia, string DonViTinh, string MaLoaiDichVu)
        {
            this.maDichVu = MaDichVu;
            this.tenDichVu = TenDichVu;
            this.donGia = DonGia;
            this.donViTinh = DonViTinh;
            this.maLoaiDichVu = MaLoaiDichVu;
        }
        public DTO_dichvu(string MaDichVu, string TenDichVu, double DonGia, string DonViTinh)
        {
            this.maDichVu = MaDichVu;
            this.tenDichVu = TenDichVu;
            this.donGia = DonGia;
            this.donViTinh = DonViTinh;
        }

        public DTO_dichvu()
        {

        }
    }
}
