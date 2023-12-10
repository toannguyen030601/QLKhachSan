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
    public partial class QLLoaiDichVu : Form
    {
        public QLLoaiDichVu()
        {
            InitializeComponent();
            btnThem.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 20, 20));
            btnSua.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnSua.Width, btnSua.Height, 20, 20));
            btnXoa.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnXoa.Width, btnXoa.Height, 20, 20));

            dataGridView1.ReadOnly = true;
            txtTimLoaiDichVu.Enter += new EventHandler(txtTimLoaiDichVu_Enter);
        }

        BUS_loaidichvu bus_ldv = new BUS_loaidichvu();
        private void btnTimLoaiDichVu_Click(object sender, EventArgs e)
        {
            string searchLDV = txtTimLoaiDichVu.Text; // Lấy thông tin từ TextBox tìm kiếm

            if (!string.IsNullOrEmpty(searchLDV))
            {
                BUS_loaidichvu bus = new BUS_loaidichvu();
                DataTable searchData = bus.TimLoaiDichVu(new DTO_loaidichvu { tenLoaiDichVu = searchLDV }); // Gọi phương thức tìm kiếm

                if (searchData != null && searchData.Rows.Count > 0)
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
        private void LoadDataToDataGridView()
        {
            DataTable data = bus_ldv.danhsachloaidichvu();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi tên cột sau khi dữ liệu được tải vào DataGridView
            dataGridView1.Columns["maloaidichvu"].HeaderText = "Mã Loại Dịch Vụ";
            dataGridView1.Columns["tenloaidichvu"].HeaderText = "Tên Loại Dịch Vụ";
            // Đổi tên các cột khác nếu cần thiết
        }

        private void QLLoaiDichVu_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapTTLoaiDichVu f = new NhapTTLoaiDichVu(true);
            f.ShowDialog();
            if (f.IsUpdated)
            {
                LoadDataToDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = dataGridView1.CurrentCell.RowIndex;
            string maldv = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (maldv != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bus_ldv.XoaLoaiDichVu(maldv))
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
                MessageBox.Show("Vui lòng chọn loại dịch vụ bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            // Kiểm tra nếu có hàng đang được chọn
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                // Lấy thông tin từ DataGridView
                string maloaidichvu = dataGridView1.Rows[rowIndex].Cells["maloaidichvu"].Value.ToString();
                string tenloaidichvu = dataGridView1.Rows[rowIndex].Cells["tenloaidichvu"].Value.ToString();
                // Lấy các thông tin khác tương tự...

                // Tạo instance mới của form ThemSuaKhachHang
                NhapTTLoaiDichVu f = new NhapTTLoaiDichVu(false);

                // Gán dữ liệu cho các trường trên form Sửa
                NhapTTLoaiDichVu editForm = new NhapTTLoaiDichVu(false, tenloaidichvu, maloaidichvu); // Truyền thông tin cần chỉnh sửa
                editForm.ShowDialog();

                // Cập nhật lại DataGridView nếu có thay đổi
                if (editForm.IsUpdated)
                {
                    LoadDataToDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại dịch vụ khác bạn muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtTimLoaiDichVu_Enter(object sender, EventArgs e)
        {
            if (txtTimLoaiDichVu.Text == "Nhập tên loại dịch vụ cần tìm")
            {
                txtTimLoaiDichVu.Text = "";
            }
        }
    }
}
