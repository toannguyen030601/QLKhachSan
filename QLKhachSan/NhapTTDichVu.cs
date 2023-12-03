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
    public partial class NhapTTDichVu : Form
    {

        private string currentMaLoaiDichVu = "";
/*        public bool istrangthai { get { return trangthai; } }
*/        public bool IsUpdated { get; private set; }

        public NhapTTDichVu(bool isthemsuaDV, string tenDV = "", string dongia = "", string donvitinh = "", string madichvu = "", string tenLoaiDV = "")
        {

            InitializeComponent();
            this.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.isthemsuaDV = isthemsuaDV;
            if (!isthemsuaDV)
            {
                // Hiển thị thông tin khách hàng để chỉnh sửa
                txtTenDichVu.Text = tenDV;
                txtDonGia.Text = dongia;
                txtDonViTinh.Text = donvitinh;
                lbMaDV.Text = madichvu;
                LoadLoaiDichVu(tenLoaiDV);
            }
            else
            {
                LoadLoaiDichVu();
            }
        }
        private void LoadLoaiDichVu(string selectedLoaiDV = "")
        {
            DataTable data = bus_dv.DanhSachLoaiDichVu();

            if (data.Rows.Count > 0)
            {
                cBTenloaiDV.DataSource = data;
                cBTenloaiDV.DisplayMember = "TenLoaiDichVu";
                cBTenloaiDV.ValueMember = "MaLoaiDichVu";

                // Set giá trị được chọn cho ComboBox
                if (!string.IsNullOrEmpty(selectedLoaiDV))
                {
                    cBTenloaiDV.Text = selectedLoaiDV;
                    currentMaLoaiDichVu = bUS_Loaidichvu.TimMaloaidichvutheoTen(selectedLoaiDV);
                }
            }
            else
            {
                MessageBox.Show("Không có loại dịch vụ nào. Hãy thêm loại dịch vụ trước khi thêm dịch vụ mới.");
                this.Close();
            }
        }
        BUS_dichvu bus_dv = new BUS_dichvu();
        
        BUS_dichvu bUS_Dichvu = new BUS_dichvu();   
        BUS_loaidichvu bUS_Loaidichvu = new BUS_loaidichvu();
        private bool isthemsuaDV;
       /* public bool trangthai = false;*/
        private void btnThemDichVu2_Click(object sender, EventArgs e)
        {
            if (!isthemsuaDV)
            {
                string tenloaidichvu = cBTenloaiDV.Text;
                lbMaDV.Visible = true;

                // Kiểm tra xem giá nhập vào có phải là số hay không
                if (double.TryParse(txtDonGia.Text, out double donGia))
                {
                    DTO_dichvu dichvu = new DTO_dichvu()
                    {
                        tenDichVu = txtTenDichVu.Text,
                        donGia = double.Parse(txtDonGia.Text),
                        donViTinh = txtDonViTinh.Text.ToUpper(),
                        maDichVu = lbMaDV.Text,
                        maLoaiDichVu = bUS_Loaidichvu.TimMaloaidichvutheoTen(tenloaidichvu),
                        // Gán các trường thông tin khác của khách hàng tại đây nếu có
                    };

                    // Gọi hàm trong BUS_qlks để cập nhật thông tin
                    if (bus_dv.SuaDichVu(dichvu))
                    {
                        MessageBox.Show("Cập nhật thông tin dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IsUpdated = true; // Đã cập nhật thành công
                        this.Close(); // Đóng form chỉnh sửa
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin dịch vụ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đơn giá phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string tenloaidichvu = cBTenloaiDV.Text;
                if (txtTenDichVu.Text != "" && txtDonGia.Text != "" && txtDonViTinh.Text != "")
                {
                    // Kiểm tra xem giá nhập vào có phải là số hay không
                    if (double.TryParse(txtDonGia.Text, out double donGia))
                    {
                        DTO_dichvu dichvu = new DTO_dichvu()
                        {
                            tenDichVu = txtTenDichVu.Text,
                            donGia = donGia,
                            donViTinh = txtDonViTinh.Text.ToUpper(),
                            maLoaiDichVu = bUS_Loaidichvu.TimMaloaidichvutheoTen(tenloaidichvu),
                            // Gán các trường thông tin khác của dịch vụ tại đây nếu có
                        };

                        // Gọi phương thức để thêm dịch vụ trong lớp BUS_dichvu
                        if (bus_dv.ThemDichVu(dichvu))
                        {
                            MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Thêm bất kỳ logic nào bạn cần sau khi thêm thành công ở đây
                            IsUpdated = true; // Đã cập nhật thành công
                            this.Close(); // Đóng form chỉnh sửa
                        }
                        else
                        {
                            MessageBox.Show("Thêm dịch vụ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

