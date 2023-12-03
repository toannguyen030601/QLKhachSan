using BUS_qlks;
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
    public partial class QLDichvu : Form
    {
        
        private DataTable dataTable;
        public QLDichvu()
        {
            InitializeComponent();
            btnThem.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 20, 20));
            btnSua.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 20, 20));
            btnXoa.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 20, 20));

            txtTimDichVu.Enter += new EventHandler(txtTimDichVu_Enter);
            txtTimDichVu.Leave += new EventHandler(txtTimDichVu_Leave);
        }   
        BUS_dichvu busdv = new BUS_dichvu();
        private void btnTimDichVu_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimDichVu.Text; // Lấy thông tin từ TextBox tìm kiếm

            if (!string.IsNullOrEmpty(searchTerm))
            {
                BUS_dichvu bus = new BUS_dichvu();
                DataTable searchData = bus.TimDichVu(new DTO_dichvu { tenDichVu = searchTerm }); // Gọi phương thức tìm kiếm

                if (searchData != null)
                {
                    dataGridView1.DataSource = searchData; // Cập nhật DataGridView với kết quả tìm kiếm
                }
                else
                {
                    // Hiển thị thông báo nếu không tìm thấy kết quả
                    MessageBox.Show("Không tìm thấy kết quả nào.");
                }
            }
            else
            {
                // Hiển thị thông báo nếu TextBox tìm kiếm trống
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.");
            }
        }
        private void QLDichvu_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            DataTable data = busdv.danhsachdichvu();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapTTDichVu f = new NhapTTDichVu(true);
            f.ShowDialog();
            if (f.istrangthai)
            {
                LoadDataToDataGridView();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = dataGridView1.CurrentCell.RowIndex;
            string madv = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (madv != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busdv.XoaDichVu(madv))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                string madichvu = dataGridView1.Rows[rowIndex].Cells["madichvu"].Value.ToString();
                string tendichvu = dataGridView1.Rows[rowIndex].Cells["tendichvu"].Value.ToString();
                string dongia = dataGridView1.Rows[rowIndex].Cells["dongia"].Value.ToString();
                string donvitinh = dataGridView1.Rows[rowIndex].Cells["donvitinh"].Value.ToString();
                string tenloaidichvu = dataGridView1.Rows[rowIndex].Cells["tenloaidichvu"].Value.ToString();

                // Tạo một instance mới của form NhapTTDichVu và truyền thông tin
                NhapTTDichVu editForm = new NhapTTDichVu(false, tendichvu, dongia, donvitinh, madichvu,tenloaidichvu);

                // Hiển thị form NhapTTDichVu
                editForm.ShowDialog();

                // Cập nhật DataGridView nếu có thay đổi
                if (editForm.IsUpdated)
                {
                    LoadDataToDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtTimDichVu_Enter(object sender, EventArgs e)
        {
            if (txtTimDichVu.Text == "Nhập dịch vụ cần tìm")
            {
                txtTimDichVu.Text = "";
            }
        }

        private void txtTimDichVu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimDichVu.Text))
            {
                txtTimDichVu.Text = "Nhập dịch vụ cần tìm";
            }
        }
    }
}
