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
        public FormThemDvu(string maPhong, string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.maPhong = maPhong;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        BUS_dichvu busdv = new BUS_dichvu();
        BUS_hoaDon bushd = new BUS_hoaDon();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVDichVu.Rows.Count - 1 && e.ColumnIndex >= 0)
            {
                // Use the Value property to get the cell value
                object cellValue = dGVDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Check if the cell value is not null
                if (cellValue != null)
                {
                    // Convert the value to a string and assign it to lblMaDichVu
                    lblMaDichVu.Text = cellValue.ToString();
                }
            }
        }
        private void danhsachDvu()
        {
            dGVDichVu.DataSource = null;
            dGVDichVu.DataSource = busdv.Danhsachdvu();
            // dataGridView2.DataSource = bushd.DanhSachHDCT(); Hiển thị hóa đơn chi tiết để test chức năng xóa
        }

        public void LoadDichVuDaChon()
        {
            dGVDichVu.DataSource = null;
            dGVDichVuDaChon.DataSource=bushd.DichVuDaChon();
        }


        private void FormThemDvu_Load(object sender, EventArgs e)
        {
            danhsachDvu();
            LoadDichVuDaChon();
            lblMaDichVu.Text = string.Empty;
            lblMaHoaDonChiTiet.Text = string.Empty;
            lbMaPhong.Text = maPhong;
            lbMaHoaDon.Text=maHoaDon;
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
                if (bushd.CheckMaDichVu(lblMaDichVu.Text))// đã có dịch vụ này trong bảng nên tăng số lượng 1
                {
                    DTO_hoadonchitiet hdct = new DTO_hoadonchitiet();
                    hdct.maDichVu = lblMaDichVu.Text;
                    if (bushd.LuuHDCT(hdct))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        LoadDichVuDaChon();
                    };
                }
                else
                {
                    DTO_hoadonchitiet hdct = new DTO_hoadonchitiet();
                    hdct.maDichVu = lblMaDichVu.Text;
                    hdct.soLuong = 1;
                    hdct.maHoaDon = lbMaHoaDon.Text;
                    if (bushd.LuuHDCT(hdct))
                    {
                        MessageBox.Show("Lưu dịch vụ thành công");
                        LoadDichVuDaChon();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa(object sender, EventArgs e)// Xóa thành công
        {
            int i = 0;
            i = dGVDichVuDaChon.CurrentCell.RowIndex;
            string mahdct = dGVDichVuDaChon.Rows[i].Cells[0].Value.ToString();
            if (mahdct != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bushd.XoaHDCT(mahdct))
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
                MessageBox.Show("Vui lòng chọn nhân viên bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
