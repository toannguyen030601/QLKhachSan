using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FrmDatPhongTrong : Form
    {
        public string maPhong;
        public FrmDatPhongTrong(string maPhong = null)
        {
            this.maPhong = maPhong;
            InitializeComponent();
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Nhập Họ Tên")
            {
                txtHoTen.Text = string.Empty;
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Text = "Nhập Họ Tên";
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Nhập Số Điện Thoại")
            { txtSDT.Text = ""; }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                txtSDT.Text = "Nhập Số Điện Thoại";
            }
        }

        private void txtSoCCCD_Enter(object sender, EventArgs e)
        {
            if (txtSoCCCD.Text == "Nhập Số CCCD")
            { txtSoCCCD.Text = ""; }
        }

        private void txtSoCCCD_Leave(object sender, EventArgs e)
        {
            if (txtSoCCCD.Text == "")
            {
                txtSoCCCD.Text = "Nhập Số CCCD";
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpNgayDat.Value.ToString());
        }

        private void FrmDatPhongTrong_Load(object sender, EventArgs e)
        {
            lblMaPhong.Text = maPhong;
        }
    }
}
