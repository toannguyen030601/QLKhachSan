using DTO_qlks;
using Microsoft.VisualBasic.Logging;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            panelDangnhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDangnhap.Width, panelDangnhap.Height, 20, 20));
            btnDangnhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDangnhap.Width, btnDangnhap.Height, 10, 10));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,        // x-coordinate of upper-left corner
            int nTopRect,         // y-coordinate of upper-left corner
            int nRightRect,       // x-coordinate of lower-right corner
            int nBottomRect,      // y-coordinate of lower-right corner
            int nWidthEllipse,    // width of ellipse
            int nHeightEllipse    // height of ellipse
        );

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        BUS_qlks.Class1 busnv = new BUS_qlks.Class1();
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DTO_nhanvien dtonv = new DTO_nhanvien();
            dtonv.Email = txtEmail.Text;
            dtonv.Matkhau = busnv.HashPassword(txtMatkhau.Text);

            if (busnv.dangnhap(dtonv))
            {
                MessageBox.Show("Đăng nhập thành công");
                Form1.email = dtonv.Email;
                Properties.Settings.Default.Ghinho = chkNhotaikhoan.Checked;
                if (chkNhotaikhoan.Checked)
                {
                    Properties.Settings.Default.Email = txtEmail.Text;
                    Properties.Settings.Default.Matkhau = txtMatkhau.Text;
                }
                Properties.Settings.Default.Save();
                Form1 formmain = new Form1();
                this.Hide();
                formmain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng");
                txtMatkhau.Text = null;
                txtEmail.Focus();
            }

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Ghinho)
            {
                txtEmail.Text = Properties.Settings.Default.Email;
                txtMatkhau.Text = Properties.Settings.Default.Matkhau;
                chkNhotaikhoan.Checked = true;
                btnDangnhap.Focus();
            }
        }

        private void lblQuenmatkhau_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                //check email
                if (busnv.checkemail(txtEmail.Text))
                {
                    string matkhaumoi = busnv.getPassword();
                    if (busnv.updatematkhau(txtEmail.Text, matkhaumoi))
                    {
                        FormMail sendMail = new FormMail(txtEmail.Text, matkhaumoi, true);
                        sendMail.ShowDialog();
                        MessageBox.Show("Vui lòng vào email để nhận mật khẩu");
                    }
                    else
                    {
                        MessageBox.Show("Không thực hiện được");
                    }
                }
                else
                {
                    MessageBox.Show("Không thực hiện được");
                }
            }
        }
    }
}
