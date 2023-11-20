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
        BUS_qlks.BUS_hoaDon busnv = new BUS_qlks.BUS_hoaDon();
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
            dataGridView1.DataSource = busnv.DanhSachHoaDon();
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
    }
}
