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
        private DBConnect db;
        public FormHoaDon()
        {
            InitializeComponent();
            db = new DBConnect(); // Initialize your DBConnect instance
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
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
        private void UpdateDataGridView(DateTime selectedDate)
        {
            // Gọi function TimHoaDon từ BUS_hoaDon với tham số là ngày đã chọn
            DataTable data = busnv.TimHoaDon(selectedDate);

            // Cập nhật dữ liệu cho DataGridView
            dataGridView1.DataSource = data;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*// Gọi hàm TimHoaDon từ BUS_hoaDon
            DataTable data = busnv.TimHoaDon(dateTimePicker1.Value);

            // Cập nhật dữ liệu cho DataGridView
            dataGridView1.DataSource = data;*/
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text != "")
            {
                DataTable data = busnv.timkhachhang(txtTim.Text);
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
    }
}
