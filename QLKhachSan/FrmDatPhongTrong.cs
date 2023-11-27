using BUS_qlks;
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
        public BUS_Phong bus_Phong = new BUS_Phong();
        public FrmDatPhongTrong(string maPhong = null)
        {
            this.maPhong = maPhong;
            InitializeComponent();
            lblMaNhanVien.Text = bus_Phong.LayMaNV(UserLoginInfo.Email);
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
            //Thêm Khách Hàng
            if (txtHoTen.Text == "Nhập Họ Tên" || txtSDT.Text == "Nhập Số Điện Thoại" || txtSoCCCD.Text == "Nhập Số CCCD")
            {
                MessageBox.Show("Nhập đủ thông tin khách hàng");
            }
            else
            {
                if (cbGT.SelectedIndex == -1)
                {
                    MessageBox.Show("Chọn giới tính");
                }
                else
                {
                    string gt = cbGT.SelectedIndex == 0 ? "Nam" : "Nữ";
                    /// Thêm khách hàng
                    if (bus_Phong.DatPhong(txtHoTen.Text,txtSDT.Text,txtSoCCCD.Text,gt,UserLoginInfo.Email, dtpNgayNhanPhong.Value,lblMaPhong.Text))
                    {
                        MessageBox.Show("Đặt Phòng Thành Công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đặt Phòng Thất Bại");
                    }
                }
            }

        }

        private void FrmDatPhongTrong_Load(object sender, EventArgs e)
        {
            lblMaPhong.Text = maPhong;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
