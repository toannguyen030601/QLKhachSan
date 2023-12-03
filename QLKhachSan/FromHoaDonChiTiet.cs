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

namespace QLKhachSan
{
    public partial class FromHoaDonChiTiet : Form
    {
        public BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        public BUS_HoaDonChiTiet bus_HoaDonChiTiet = new BUS_HoaDonChiTiet();
        string maHoaDon;
        public FromHoaDonChiTiet(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        public void LoadDuLieu()
        {
            DataTable data = bus_HoaDon.LayHoaDon(maHoaDon);
            lblMaHoaDon.Text = maHoaDon;
            lblMaPhong.Text = data.Rows[0]["maphong"].ToString();
            string maNhanVien = data.Rows[0]["manhanvien"].ToString();
            lblTenNhanVien.Text = bus_HoaDonChiTiet.LayTenNhanVien(maNhanVien);
            string maKhachHang = data.Rows[0]["makhachhang"].ToString();
            lblTenKhachHang.Text = bus_HoaDonChiTiet.LayTenKhachHang(maKhachHang);
            dtpNgayLap.Value = (DateTime)data.Rows[0]["ngaynhanphong"];
            dtpTraPhong.Value = (DateTime)data.Rows[0]["ngaytraphong"];

            //Dịch vụ 
            dgvDichVu.DataSource = bus_HoaDonChiTiet.DichVuDaSuDung(maHoaDon);
            dgvDichVu.Columns[0].HeaderText = "Tên Dịch Vụ";
            dgvDichVu.Columns[1].HeaderText = "Đơn Giá";
            dgvDichVu.Columns[2].HeaderText = "Số Lượng";
            dgvDichVu.Columns[3].HeaderText = "Thành Tiền";

            /// Tổng tiền dịch vụ + phòng 
            double tongTienDichVu = 0;

            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {
                object giaObj = row.Cells[3].Value;

                if (giaObj != null && double.TryParse(giaObj.ToString(), out double gia))
                {
                    tongTienDichVu += gia;
                }

                //tổng tiền phòng;
                double tongTienPhong = 0;
                DateTime ngayNhanPhong = (DateTime)data.Rows[0]["ngaynhanphong"];
                DateTime ngayTraPhong = DateTime.Now;

                double soGioThue = (ngayTraPhong - ngayNhanPhong).TotalHours;
                double giaPhong = bus_HoaDonChiTiet.GiaPhong(lblMaPhong.Text);
                if (soGioThue < 6)
                {
                    lblGiamGia.Text = "0%";
                    tongTienPhong = soGioThue * giaPhong;
                }
                else
                {
                    if (soGioThue < 12)
                    {
                        lblGiamGia.Text = "20%";
                        tongTienPhong = soGioThue * giaPhong * 80 / 100;
                    }
                    else
                    {
                        lblGiamGia.Text = "40%";
                        tongTienPhong = soGioThue * giaPhong * 60 / 100;
                    }
                }
                lblTongTien.Text = (tongTienDichVu + tongTienPhong).ToString() + "VND";
            }

        }

        private void FromHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\testin"; // Thay đổi đường dẫn đến thư mục lưu trữ PDF nếu cần

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string pdfFilePath = Path.Combine(folderPath, "HoaDonChiTiet.pdf");

                PdfDocument pdf = new PdfDocument();
                PdfPage page = pdf.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Arial", 12);

                // Vẽ thông tin từ các label
                gfx.DrawString("Mã hóa đơn: " + lblMaHoaDon.Text, font, XBrushes.Black, new XPoint(50, 50));
                gfx.DrawString("Tên khách hàng: " + lblTenKhachHang.Text, font, XBrushes.Black, new XPoint(50, 70));
                // Vẽ thông tin từ DataGridView
                int yOffset = 90;
                foreach (DataGridViewRow row in dgvDichVu.Rows)
                {
                    gfx.DrawString(row.Cells["TenDV"].Value.ToString(), font, XBrushes.Black, new XPoint(50, yOffset));
                    gfx.DrawString(row.Cells["GiaDV"].Value.ToString(), font, XBrushes.Black, new XPoint(200, yOffset));

                    // Vẽ các thông tin khác nếu cần
                    yOffset += 20;
                }

                // Lưu tệp PDF
                pdf.Save(pdfFilePath);

                MessageBox.Show("PDF file saved successfully in the folder: " + folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



    }

}
