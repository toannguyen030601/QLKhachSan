using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_qlks
{
    public class DTO_HoaDonChiTiet
    {
        private string mahoadonchitiet;
        private int soluong;
        private string mahoadon;
        private string madichvu;

        public string Mahoadonchitiet
        {
            get { return mahoadonchitiet; }
            set { mahoadon = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string Mahoadon
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
        public string Madichvu
        {
            get { return madichvu; }
            set { madichvu = value; }
        }
        public DTO_HoaDonChiTiet() { }
        public DTO_HoaDonChiTiet(string mahoadonchitiet,int soluong,string mahoadon,string madichvu)
        {
            this.Mahoadonchitiet = mahoadonchitiet;
            this.Soluong = soluong;
            this.Mahoadon = mahoadon;
            this.Madichvu = madichvu;
        }                
    }
}
