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
using System.Xml.Linq;

namespace QLKhachSan
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            btnThem.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 20, 20));
            btnSua.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 20, 20));
            btnXoa.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 20, 20));
        }
        BUS_qlks.BUS_khachhang buskh = new BUS_qlks.BUS_khachhang();
        private void SearchData(string searchTerm)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {
                BUS_khachhang bus = new BUS_khachhang();
                DataTable searchData = bus.TimKhachHang(new DTO_khachhang { Hoten = searchTerm }); // Gọi phương thức tìm kiếm

                if (searchData != null && searchData.Rows.Count > 0)
                {
                    dataGridView1.DataSource = searchData; // Cập nhật DataGridView với kết quả tìm kiếm
                }
                else
                {
                    // Hiển thị thông báo nếu không tìm thấy kết quả
                    MessageBox.Show("Không tìm thấy kết quả nào hoặc dữ liệu trống.");
                }
            }
            else
            {
                // Hiển thị thông báo nếu TextBox tìm kiếm trống
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.");
                LoadDataToDataGridView();
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text; // Lấy thông tin từ TextBox tìm kiếm
            SearchData(searchTerm);
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            /*Danhsachnhanvien();*/
            LoadDataToDataGridView();
        }
        private bool columnsAdded = false;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            MessageBox.Show(btn.Tag.ToString());
        }
        private void LoadDataToDataGridView()
        {
            DataTable data = buskh.XemKhachHang();
            dataGridView1.DataSource = data;
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FromThemSuaKhachHang f = new FromThemSuaKhachHang(true);
            
            f.ShowDialog();
            if (f.istrangthai)
            {
                LoadDataToDataGridView();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = dataGridView1.CurrentCell.RowIndex;
            string makh = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (makh != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (buskh.XoaKhachHang(makh))
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
                MessageBox.Show("Vui lòng chọn nhân viên bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            // Kiểm tra nếu có hàng đang được chọn
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                // Lấy thông tin từ DataGridView
                string maKH = dataGridView1.Rows[rowIndex].Cells["makhachhang"].Value.ToString();
                string hoTen = dataGridView1.Rows[rowIndex].Cells["hoten"].Value.ToString();
                string soDienThoai = dataGridView1.Rows[rowIndex].Cells["sodt"].Value.ToString();
                string socccd = dataGridView1.Rows[rowIndex].Cells["socccd"].Value.ToString();
                string gioitinh = dataGridView1.Rows[rowIndex].Cells["gioitinh"].Value.ToString();
                // Lấy các thông tin khác tương tự...

                // Tạo instance mới của form ThemSuaKhachHang
                FromThemSuaKhachHang f = new FromThemSuaKhachHang(false);

                // Gán dữ liệu cho các trường trên form Sửa
                FromThemSuaKhachHang editForm = new FromThemSuaKhachHang(false, hoTen, soDienThoai, socccd, gioitinh, maKH); // Truyền thông tin cần chỉnh sửa
                editForm.ShowDialog();

                // Cập nhật lại DataGridView nếu có thay đổi
                if (editForm.IsUpdated)
                {
                    LoadDataToDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
