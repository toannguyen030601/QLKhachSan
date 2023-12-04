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
    public partial class FrmThongKe : Form
    {
        BUS_DoanhThu bus_DoanhThu = new BUS_DoanhThu();
        public static int loaiDoanhThu = 0;
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {

        }

        private void doanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDoanhThuDichVu(DateTime.MinValue, DateTime.MaxValue);
            loaiDoanhThu = 1;
        }

        public void LoadDoanhThuDichVu(DateTime bd, DateTime kt)
        {
            dgvDoanhThu.DataSource = null;
            dgvDoanhThu.DataSource = bus_DoanhThu.DoanhThuDichVu(bd, kt);
            dgvDoanhThu.Columns[0].HeaderText = "Tên Dịch Vụ";
            dgvDoanhThu.Columns[1].HeaderText = "Đơn giá";
            dgvDoanhThu.Columns[2].HeaderText = "Số Lượng";
            dgvDoanhThu.Columns[3].HeaderText = "Thành Tiền";
            double doanhThu = 0;

            // Duyệt qua từng dòng trong DataGridView để tính tổng doanh thu
            foreach (DataGridViewRow row in dgvDoanhThu.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng header
                if (!row.IsNewRow)
                {
                    object tien = row.Cells[3].Value;
                    if (tien != null && double.TryParse(tien.ToString(), out double tienValue))
                    {
                        doanhThu += tienValue;
                    }
                }
            }

            // Hiển thị tổng doanh thu lên Label
            lblDoanhThu.Text = doanhThu.ToString() + "VNĐ"; // Định dạng hiển thị tiền tệ
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (loaiDoanhThu == 1)
            {
                LoadDoanhThuDichVu(dateTimePicker1.Value, dateTimePicker2.Value);
            }
            else
            {
                LoadDoanhThuPhong(dateTimePicker1.Value, dateTimePicker2.Value);
            }
        }

        private void doanhThuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDoanhThuPhong(DateTime.MinValue,DateTime.MaxValue);
            loaiDoanhThu = 2;
        }
        public void LoadDoanhThuPhong(DateTime bd, DateTime kt)
        {
            dgvDoanhThu.DataSource = null;
            dgvDoanhThu.DataSource = bus_DoanhThu.DoanhThuPhong(bd, kt);
            double doanhThu = 0;

            // Duyệt qua từng dòng trong DataGridView để tính tổng doanh thu
            foreach (DataGridViewRow row in dgvDoanhThu.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng header
                if (!row.IsNewRow)
                {
                    DateTime ngayNhanPhong = (DateTime)row.Cells["ngaynhanphong"].Value;
                    DateTime ngayTraPhong = (DateTime)row.Cells["ngaytraphong"].Value;
                    double soGioThue = (ngayTraPhong - ngayNhanPhong).TotalHours;
                    BUS_HoaDonChiTiet bus_HoaDonChiTiet = new BUS_HoaDonChiTiet();
                    string maPhong = row.Cells["maphong"].ToString();
                    double giaPhong = bus_HoaDonChiTiet.GiaPhong(maPhong);
                    if (soGioThue > 2)
                    {
                        doanhThu +=  giaPhong*soGioThue*80/100;
                        if (soGioThue > 6)
                        {
                            doanhThu += soGioThue * giaPhong * 70 / 100;
                        }
                        else
                        {
                            if (soGioThue > 12)
                            {
                                doanhThu += soGioThue * giaPhong * 50 / 100;
                            }
                        }
                    }
                    else
                    {
                        doanhThu = giaPhong * soGioThue ;
                    }
                }
            }

            // Hiển thị tổng doanh thu lên Label
            lblDoanhThu.Text = doanhThu.ToString() + "VNĐ"; // Định dạng hiển thị tiền tệ
        }
    }
}
