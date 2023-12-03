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
    public partial class FormThemDvu : Form
    {
        private string maPhong;
        private string maHoaDon;
        BUS_dichvu busdv = new BUS_dichvu();
        BUS_hoaDon bushd = new BUS_hoaDon();
        public FormThemDvu(string maPhong, string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.maPhong = maPhong;
            LoadDichVuDaChon();
            danhsachDvu();
            lblMaDichVu.Visible = false;
            lblMaHoaDonChiTiet.Visible = false;
            lblTenKH.Text = bushd.LayTenKhachHangCuaHoaDon(maHoaDon);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void danhsachDvu()
        {
            dGVDichVu.DataSource = null;
            dGVDichVu.DataSource = busdv.Danhsachdvu();
            dGVDichVu.Columns[0].HeaderText = "Mã Dịch Vụ";
            dGVDichVu.Columns[1].HeaderText = "Tên dịch vụ";
            dGVDichVu.Columns[2].HeaderText = "Đơn giá";
            // dataGridView2.DataSource = bushd.DanhSachHDCT(); Hiển thị hóa đơn chi tiết để test chức năng xóa
        }

        public void LoadDichVuDaChon()
        {
            dGVDichVuDaChon.DataSource = null;
            dGVDichVuDaChon.DataSource = bushd.DichVuDaChon(lbMaHoaDon.Text);
            dGVDichVuDaChon.Columns[0].Visible=false;
            dGVDichVuDaChon.Columns[1].HeaderText = "Tên dịch vụ";
            dGVDichVuDaChon.Columns[2].HeaderText = "Đơn Giá";
            dGVDichVuDaChon.Columns[3].HeaderText = "Số lượng";
        }

        private void FormThemDvu_Load(object sender, EventArgs e)
        {
            danhsachDvu();
            LoadDichVuDaChon();
            lblMaDichVu.Text = string.Empty;
            lblMaHoaDonChiTiet.Text = string.Empty;
            lbMaPhong.Text = maPhong;
            lbMaHoaDon.Text = maHoaDon;
            // tên khách hàng lấy trong bảng HoaDon dựa vào Mã Hóa Đơn
        }
        private void ChuyenDuLieu()
        {

        }
        private void btnPhai_Click(object sender, EventArgs e)
        {
            ChuyenDuLieu();
            if (!string.IsNullOrEmpty(lblMaDichVu.Text))
            {
                DTO_hoadonchitiet hdct = new DTO_hoadonchitiet();
                hdct.maDichVu = lblMaDichVu.Text;
                hdct.maHoaDon = lbMaHoaDon.Text;
                if (bushd.LuuHDCT(hdct))
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    LoadDichVuDaChon();
                };
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa(object sender, EventArgs e)// Xóa thành công
        {
            if (!string.IsNullOrEmpty(lblMaHoaDonChiTiet.Text))
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bushd.XoaHDCT(lblMaHoaDonChiTiet.Text))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        danhsachDvu();// Refresh lại trang
                        LoadDichVuDaChon();
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

        private void txtTimdv_TextChanged(object sender, EventArgs e)
        {
            if (txtTimdv.Text != "")
            {
                DataTable data = busdv.TimDvu(txtTimdv.Text);
                if (data.Rows.Count > 0)
                {
                    dGVDichVu.DataSource = data;
                }
            }
            else
            {
                danhsachDvu();
            }
        }

        private void dGVDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVDichVu.Rows.Count - 1 && e.ColumnIndex >= 0)
            {
                // Use the Value property to get the cell value
                object cellValue = dGVDichVu.Rows[e.RowIndex].Cells[0].Value;

                // Check if the cell value is not null
                if (cellValue != null)
                {
                    // Convert the value to a string and assign it to lblMaDichVu
                    lblMaDichVu.Text = cellValue.ToString();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (bushd.ThanhToanPhong(lbMaHoaDon.Text, DateTime.Now, false, lbMaPhong.Text))
            {
                //Hiển thị form Hóa Đơn chi tiết
                MessageBox.Show("THanh toán thành công");
                FrmHoaDonChiTiet hdct = new FrmHoaDonChiTiet(lbMaHoaDon.Text);
            }
            else
            {
                MessageBox.Show("THanh toán thất bại");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbMaPhong_Click(object sender, EventArgs e)
        {

        }

        private void lbTenKH_Click(object sender, EventArgs e)
        {
        }

        private void lbMaHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void dGVDichVuDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lblMaHoaDonChiTiet.Text = dGVDichVuDaChon.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
