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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLKhachSan
{
    public partial class FormDoiMK : Form
    {
        Class1 bus_NhanVien = new Class1();
        public FormDoiMK(string email)
        {
            InitializeComponent();
            this.email = email;

            this.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            panelDMK.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, panelDMK.Width, panelDMK.Height, 20, 20));
            btnDoiMK.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnDoiMK.Width, btnDoiMK.Height, 20, 20));
            button2.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
        }
        private bool isSuccess = false;
        private string email;

        public bool getSuccess
        {
            get { return isSuccess; }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtMkCu_Enter(object sender, EventArgs e)
        {
         
        }

        private void txtMkCu_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtMkMoi_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtMkMoi_Leave(object sender, EventArgs e)
        {
         
        }

        private void txtMkMoi2_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtMkMoi2_Leave(object sender, EventArgs e)
        {
         
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email nhân viên" || txtMkCu.Text == "Mật khẩu cũ" || txtMkMoi.Text == "Mật khẩu mới" || txtMkMoi2.Text == "Nhập lại mật khẩu")
            {
                MessageBox.Show("Nhập thông tin cần thiết");
            }
            else
            {
                if (txtMkMoi.Text != txtMkMoi2.Text)//ko trung mk
                {
                    MessageBox.Show("Mật khẩu mới không trùng");
                }
                else
                {
                    if (bus_NhanVien.CheckMK(txtEmail.Text, bus_NhanVien.HashPassword(txtMkCu.Text)))//
                    {

                        bus_NhanVien.updatematkhau(txtEmail.Text, txtMkMoi.Text);
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMkMoi_Validating(object sender, CancelEventArgs e)
        {

        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
