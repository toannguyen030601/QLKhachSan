using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_LoaiPhong
    {
        public string MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }

        public DTO_LoaiPhong()
        {
        }

        public DTO_LoaiPhong(string maLoaiPhong, string tenLoaiPhong)
        {
            MaLoaiPhong = maLoaiPhong;
            TenLoaiPhong = tenLoaiPhong;
        }
    }

}
