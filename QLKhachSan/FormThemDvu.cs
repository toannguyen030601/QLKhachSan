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
    public partial class FormThemDvu : Form
    {
        public FormThemDvu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        BUS_dichvu busdv = new BUS_dichvu();
        BUS_hoaDon bushd = new BUS_hoaDon();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            danhsachDvu();
        }
        private void danhsachDvu()
        {
            dataGridView1.DataSource = busdv.Danhsachdvu();
           // dataGridView2.DataSource = bushd.DanhSachHDCT(); Hiển thị hóa đơn chi tiết để test chức năng xóa
        }




        private void FormThemDvu_Load(object sender, EventArgs e)
        {
            danhsachDvu();
            btnPhai.Click += btnPhai_Click;
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa(object sender, EventArgs e)// Xóa thành công
        {
            int i = 0;
            i = dataGridView2.CurrentCell.RowIndex;
            string mahdct = dataGridView2.Rows[i].Cells[0].Value.ToString();
            if (mahdct != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bushd.XoaHDCT(mahdct))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        danhsachDvu();// Refresh lại trang
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
