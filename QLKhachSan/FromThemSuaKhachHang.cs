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
    public partial class FromThemSuaKhachHang : Form
    {
        public bool IsUpdated { get; private set; }
        private bool isNam;
        public FromThemSuaKhachHang(bool isthemsuaKH, string hoTen = "", string soDienThoai = "", string socccd = "", bool gioiTinhNam = true)
        {
            InitializeComponent();
            this.isthemsuaKH = isthemsuaKH;
            if (!isthemsuaKH)
            {
                // Hiển thị thông tin khách hàng để chỉnh sửa
                txtHoten.Text = hoTen;
                txtSoDT.Text = soDienThoai;
                txtCCCD.Text = socccd;
                isNam = gioiTinhNam; // Gán giá trị giới tính được truyền vào từ tham số

                // Gán giá trị cho RadioButton dựa trên giới tính được truyền vào
                if (gioiTinhNam)
                {
                    rdbNam.Checked = true;
                    rdbNu.Checked = false;
                }
                else
                {
                    rdbNam.Checked = false;
                    rdbNu.Checked = true;
                }
                // Hiển thị các thông tin khác để chỉnh sửa nếu cần
            }

        }
        private bool checkNumber(string number)
        {
            return int.TryParse(number, out int check);
        }
        BUS_qlks.BUS_khachhang buskh = new BUS_qlks.BUS_khachhang();
        BUS_qlks.Class1 busnv = new BUS_qlks.Class1();
        private bool isthemsuaKH;
        public bool trangthai = false;

        public bool istrangthai { get { return trangthai; } }
        private void btnThemSuaNV_Click(object sender, EventArgs e)
        {
            if (!isthemsuaKH)
            {
                // Logic cập nhật thông tin khách hàng
                string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";

                DTO_khachhang khachHang = new DTO_khachhang()
                {
                    Hoten = txtHoten.Text,
                    Gioitinh = gioiTinh,
                    Sodt = txtSoDT.Text,
                    Socccd = txtCCCD.Text,
                    Makhachhang = ,
                    // Gán các trường thông tin khác của khách hàng tại đây nếu có
                };
                // Cập nhật các thông tin khác nếu cần

                // Gọi hàm trong BUS_qlks để cập nhật thông tin
                if (buskh.SuaKhachHang(khachHang))
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsUpdated = true; // Đã cập nhật thành công
                    this.Close(); // Đóng form chỉnh sửa
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string emailDaDangNhap = UserLoginInfo.Email;
                if (txtHoten.Text != "" && (rdbNam.Checked || rdbNu.Checked) && txtSoDT.Text != "" && txtCCCD.Text != "")
                {
                    if (checkNumber(txtSoDT.Text) && checkNumber(txtCCCD.Text))
                    {
                        string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";

                        DTO_khachhang khachHang = new DTO_khachhang()
                        {
                            Hoten = txtHoten.Text,
                            Gioitinh = gioiTinh,
                            Sodt = txtSoDT.Text,
                            Socccd = txtCCCD.Text,
                            Manv = busnv.TimMaNhanVienTheoEmail(emailDaDangNhap),
                            // Gán các trường thông tin khác của khách hàng tại đây nếu có
                        };

                        // Gọi phương thức để thêm khách hàng trong lớp BUS_khachhang
                        if (buskh.ThemKhachHang(khachHang))
                        {
                            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Thêm bất kỳ logic nào bạn cần sau khi thêm thành công ở đây
                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại và Số CCCD phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
