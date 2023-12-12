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
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using System.Diagnostics;

namespace QLKhachSan
{
    public partial class FromHoaDonChiTiet : Form
    {
        public BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        private BUS_HoaDonChiTiet bus_HDCT = new BUS_HoaDonChiTiet();
        private string maHoaDon;
        public FromHoaDonChiTiet(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            lblMaHDCT.Visible = false;
        }

        public void LoadDuLieu()
        {
            DataTable data = bus_HoaDon.LayHoaDon(maHoaDon);
            lblMaHoaDon.Text = maHoaDon;
            lblMaPhong.Text = data.Rows[0]["maphong"].ToString();
            string maNhanVien = data.Rows[0]["manhanvien"].ToString();
            lblTenNhanVien.Text = bus_HDCT.LayTenNhanVien(maNhanVien);
            string maKhachHang = data.Rows[0]["makhachhang"].ToString();
            lblTenKhachHang.Text = bus_HDCT.LayTenKhachHang(maKhachHang);
            dtpNgayLap.Value = (DateTime)data.Rows[0]["ngaynhanphong"];
            dtpTraPhong.Value = DateTime.Now;

            //Dịch vụ 
            dgvDichVu.DataSource = bus_HDCT.DichVuDaChon(maHoaDon);
            dgvDichVu.Columns[0].Visible = false;
            dgvDichVu.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgvDichVu.Columns[2].HeaderText = "Đơn Giá";
            dgvDichVu.Columns[3].HeaderText = "Số Lượng";
            dgvDichVu.Columns[4].HeaderText = "Thành Tiền";

            /// Tổng tiền dịch vụ + phòng 
            double tongTienDichVu = 0;

            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {
                object giaObj = row.Cells[4].Value;

                if (giaObj != null && double.TryParse(giaObj.ToString(), out double gia))
                {
                    tongTienDichVu += gia;
                }
            }
            lblTongTienDV.Text = tongTienDichVu.ToString();
            //tổng tiền phòng;
            double tongTienPhong = 0;
            DateTime ngayNhanPhong = (DateTime)data.Rows[0]["ngaynhanphong"];
            DateTime ngayTraPhong = DateTime.Now;

            double soGioThue = (ngayTraPhong - ngayNhanPhong).TotalHours;
            double giaPhong = bus_HDCT.GiaPhong(lblMaPhong.Text);
            soGioThue = Math.Ceiling(soGioThue);
            if (soGioThue < 2)
            {
                tongTienPhong += giaPhong * soGioThue;
                lblGiamGia.Text = "0%";
            }
            else
            {
                if (soGioThue < 6)
                {
                    lblGiamGia.Text = "20%";
                    tongTienPhong += giaPhong * soGioThue * 80 / 100;
                }
                else
                {
                    if (soGioThue < 12)
                    {
                        tongTienPhong += giaPhong * soGioThue * 60 / 100;
                        lblGiamGia.Text = "40%";
                    }
                    else
                    {
                        tongTienPhong += giaPhong * soGioThue * 50 / 100;
                        lblGiamGia.Text = "50%";
                    }
                }
            }
            lblTongTienPhong.Text = tongTienPhong.ToString();
            lblTongTien.Text = (Math.Round(tongTienDichVu + tongTienPhong, 2)).ToString() + "VND";

        }

        private void FromHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfFilePath = saveFileDialog.FileName;

                        if (!string.IsNullOrEmpty(pdfFilePath))
                        {
                            using (PdfDocument pdf = new PdfDocument())
                            {
                                PdfPage page = pdf.AddPage();
                                XGraphics gfx = XGraphics.FromPdfPage(page);
                                XFont font = new XFont("Arial", 12);

                                // Vẽ thông tin từ các label
                                gfx.DrawString("Mã hóa đơn: " + lblMaHoaDon.Text, font, XBrushes.Black, new XPoint(50, 50));
                                gfx.DrawString("Tên Nhân Viên: " + lblTenNhanVien.Text, font, XBrushes.Black, new XPoint(50, 70));
                                gfx.DrawString("Tên khách hàng: " + lblTenKhachHang.Text, font, XBrushes.Black, new XPoint(50, 90));
                                gfx.DrawString("Giá dịch vụ: " + lblTongTienDV.Text, font, XBrushes.Black, new XPoint(50, 110));
                                gfx.DrawString("Giá Phòng: " + lblTongTienPhong.Text, font, XBrushes.Black, new XPoint(50, 130));
                                gfx.DrawString("----------------------------------------------------------", font, XBrushes.Black, new XPoint(50, 150));
                                gfx.DrawString("Tổng tiền: " + lblTongTien.Text, font, XBrushes.Black, new XPoint(50, 170));

                                // Lưu tệp PDF
                                pdf.Save(pdfFilePath);

                                MessageBox.Show("Lưu PDF thành công tại : " + pdfFilePath);
                                ProcessStartInfo psi = new ProcessStartInfo
                                {
                                    FileName = pdfFilePath,
                                    UseShellExecute = true
                                };

                                Process.Start(psi);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn nơi để lưu tệp PDF.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại: " + ex.Message);
            }


        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (bus_HDCT.ThanhToanPhong(lblMaHoaDon.Text, DateTime.Now, false, lblMaPhong.Text))
            {
                //Hiển thị form Hóa Đơn chi tiết
                MessageBox.Show("Thanh toán thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                object maHCDT = dgvDichVu.Rows[e.RowIndex].Cells[0].Value;
                if (maHCDT != null)
                {
                    lblMaHDCT.Text = maHCDT.ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lblMaHDCT.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa");
            }
            else
            {
               DialogResult kq= MessageBox.Show("Bạn có chắn chắn muốn xóa","Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (bus_HDCT.XoaHDCT(lblMaHDCT.Text))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();// Refresh lại trang
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
