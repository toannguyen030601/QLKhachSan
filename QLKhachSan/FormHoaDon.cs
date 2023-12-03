using BUS_qlks;
using DAL_qlks;
using Npgsql;
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
    public partial class FormHoaDon : Form
    {
     
        public FormHoaDon()
        {
            InitializeComponent();
           
        }
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        //đóng mở menu
        bool sidebarExpand = false;
        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }
        private void danhsachHoadon()
        {
            dataGridView1.DataSource = bus_HoaDon.DanhSachHoaDon();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            danhsachHoadon();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text != "")
            {
                DataTable data = bus_HoaDon.TimKhachHang(txtTim.Text);
                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng bạn muốn tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Properties.Resources.normalcontrol;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.Image = Properties.Resources.maximize1;
            }
        }
    }
}
