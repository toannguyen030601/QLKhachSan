using DTO_qlks;
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
    public partial class FormThemSuaNhanVien : Form
    {
        public FormThemSuaNhanVien(bool isthemsuanv)
        {
            InitializeComponent();
            this.isthemsuanv = isthemsuanv;
        }
        BUS_qlks.Class1 busnv = new BUS_qlks.Class1();

        public bool them = false;
        public bool isthem
        {
            get
            {
                return them;
            }
        }
        private bool isthemsuanv;
        

        private void btnThemSuaNV_Click(object sender, EventArgs e)
        {
            if(isthemsuanv) // thêm nv
            {
                string matkhau = busnv.getPassword();

                DTO_nhanvien dtonv = new DTO_nhanvien(textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), "toannguyen0257@gmail.com", textBox1.Text, textBox1.Text, matkhau, textBox1.Text);
                if (busnv.ThemNhanVien(dtonv))
                {
                    FormMail sendMail = new FormMail(dtonv.Email, matkhau);
                    sendMail.ShowDialog();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    them = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else // sửa nv
            {

            }
        }
    }
}
