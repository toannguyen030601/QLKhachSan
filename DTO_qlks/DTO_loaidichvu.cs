using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_loaidichvu
    {
        private string MaLoaiDichVu { get; set; }
        private string TenLoaiDichVu { get; set; }

        public string maLoaiDichVu
        {
            get { return MaLoaiDichVu; }
            set { MaLoaiDichVu = value; }
        }

        public string tenLoaiDichVu
        {
            get { return TenLoaiDichVu; }
            set { TenLoaiDichVu = value; }
        }

        public DTO_loaidichvu(string MaLoaiDichVu, string TenLoaiDichVu)
        {
            this.maLoaiDichVu = MaLoaiDichVu;
            this.tenLoaiDichVu = TenLoaiDichVu;
        }
        public DTO_loaidichvu()
        {

        }
    }
}
