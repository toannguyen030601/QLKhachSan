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
    public partial class NhapTTLoaiDichVu : Form
    {

        private bool isthemsuaLDV;
        /*public bool trangthai = false;

        public bool istrangthai { get { return trangthai; } }*/
        public bool IsUpdated { get; private set; }
        public NhapTTLoaiDichVu(bool isthemsuaLDV, string tenloaidichvu = "", string maloaidichvu = "")
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.isthemsuaLDV = isthemsuaLDV;
            if (!isthemsuaLDV)
            {
                // Hiển thị thông tin khách hàng để chỉnh sửa                
                txtNhapLoaiDichVu.Text = tenloaidichvu;
                labelMaLDV.Text = maloaidichvu;
            }
        }
        BUS_loaidichvu bUS_Loaidichvu = new BUS_loaidichvu();   
        private void btnThemLoaiDichVu2_Click(object sender, EventArgs e)
        {
            if (!isthemsuaLDV)
            {
                // -> label mã loại dịch vụ hiện hoặc ẩn khi thêm hoặc sửa
                labelMaLDV.Visible = true;

                // Logic cập nhật thông tin khách hàng

                DTO_loaidichvu loaidichvu = new DTO_loaidichvu()
                {
                    tenLoaiDichVu = txtNhapLoaiDichVu.Text,
                    maLoaiDichVu = labelMaLDV.Text
                   
                    // Gán các trường thông tin khác của khách hàng tại đây nếu có
                };
                // Cập nhật các thông tin khác nếu cần

                // Gọi hàm trong BUS_qlks để cập nhật thông tin
                if (bUS_Loaidichvu.SuaLoaiDichVu(loaidichvu))
                {
                    MessageBox.Show("Cập nhật thông tin loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsUpdated = true; // Đã cập nhật thành công
                    this.Close(); // Đóng form chỉnh sửa
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin loại dịch vụ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtNhapLoaiDichVu.Text != "")
                {
                     DTO_loaidichvu loaidichvu = new DTO_loaidichvu()
                     {
                         tenLoaiDichVu = txtNhapLoaiDichVu.Text
                         // Gán các trường thông tin khác của khách hàng tại đây nếu có
                     };

                     // Gọi phương thức để thêm khách hàng trong lớp BUS_khachhang
                     if (bUS_Loaidichvu.ThemLoaiDichVu(loaidichvu))
                     {
                         MessageBox.Show("Thêm loại dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Thêm bất kỳ logic nào bạn cần sau khi thêm thành công ở đây
                        IsUpdated = true; // Đã cập nhật thành công
                        this.Close(); // Đóng form chỉnh sửa
                    }
                     else
                     {
                         MessageBox.Show("Thêm loại dịch vụ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
