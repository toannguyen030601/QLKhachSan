using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_LoaiPhong
    {
        private string maLoaiPhong;
        private string tenLoaiPhong;
        public string MaLoaiPhong
        {
            get { return maLoaiPhong; }
            set { maLoaiPhong = value;}
        }
        public string TenLoaiPhong
        {
            get { return tenLoaiPhong; }
            set { tenLoaiPhong = value; }
        }

        public DTO_LoaiPhong()
        {
        }

        public DTO_LoaiPhong(string maLoaiPhong, string tenLoaiPhong)
        {
            this.MaLoaiPhong = maLoaiPhong;
            this.TenLoaiPhong = tenLoaiPhong;
        }
    }

}
