using BUS_qlks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FrmDatPhongTrong : Form
    {
        public string maPhong;
        public BUS_Phong bus_Phong = new BUS_Phong();
        public bool IsUpdated { get; private set; }
        public FrmDatPhongTrong(string maPhong = null)
        {
            this.maPhong = maPhong;
            InitializeComponent();
            lblMaNhanVien.Text = bus_Phong.LayMaNV(UserLoginInfo.Email);
            BUS_HoaDonChiTiet hd = new BUS_HoaDonChiTiet();
            lblTenNhanVien.Text = hd.LayTenNhanVien(lblMaNhanVien.Text);
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
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^(032|033|034|035|036|037|038|039|096|097|098|086|083|084|085|081|082|088|091|094|070|079|077|076|078|090|093|089|056|058|092|059|099)[0-9]{7,8}$"; // Định dạng: Bắt đầu bằng "0" và sau đó là từ 10 đến 12 chữ số.

            Regex regex = new Regex(pattern);

            return regex.IsMatch(phoneNumber);
        }

        private bool IsNameValid(string name)
        {
            // Kiểm tra xem tên chỉ chứa chữ cái và dấu cách.
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }

            return true;
        }
        private bool IsCccdValid(string cccd)
        {
            // Kiểm tra xem số căn cước có đúng định dạng không (ví dụ: 12 chữ số).
            return cccd.Length == 12 && IsNumeric(cccd);
        }

        static bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (IsNameValid(txtHoTen.Text))
            {
                if (IsPhoneNumberValid(txtSDT.Text))
                {
                    if (IsCccdValid(txtSoCCCD.Text))
                    {
                        if (cbGT.SelectedIndex == -1)
                        {
                            MessageBox.Show("Vui lòng Chọn giới tính");
                        }
                        else
                        {
                            string gt = cbGT.SelectedIndex == 0 ? "Nam" : "Nữ";
                            /// Thêm khách hàng
                            if (bus_Phong.DatPhong(txtHoTen.Text, txtSDT.Text, txtSoCCCD.Text, gt, UserLoginInfo.Email, dtpNgayNhanPhong.Value, lblMaPhong.Text))
                            {
                                MessageBox.Show("Đặt Phòng Thành Công");
                                IsUpdated = true;
                                this.Close();
                                BUS_Phong bUS_Phong = new BUS_Phong();
                                string maHoaDon = bus_Phong.MaHoaDonCuaPhong(lblMaPhong.Text);
                                FormThemDvu frm = new FormThemDvu(lblMaPhong.Text, maHoaDon);
                                frm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Đặt Phòng Thất Bại");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập CCCD có 12 kí tự số");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập số điện thoại đúng định dạng");
                }
            }
            else
            {
                MessageBox.Show("Nhập tên chỉ chứa chữ cái và dấu cách ");
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
