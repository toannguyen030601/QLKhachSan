using BUS_qlks;
using DTO_qlks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLKhachSan
{
    public partial class FromThemSuaKhachHang : Form
    {
        public bool IsUpdated { get; private set; }
        private bool isNam;
        public FromThemSuaKhachHang(bool isthemsuaKH, string hoTen = "", string soDienThoai = "", string socccd = "", string gioiTinh = "Nam", string maKH = "")
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.isthemsuaKH = isthemsuaKH;
            if (!isthemsuaKH)
            {
                // Hiển thị thông tin khách hàng để chỉnh sửa
                DisplayCustomerInfo(hoTen, soDienThoai, socccd, gioiTinh, maKH);
            }

        }
        private void DisplayCustomerInfo(string hoTen, string soDienThoai, string socccd, string gioiTinh, string maKH)
        {
            txtHoten.Text = hoTen;
            txtSoDT.Text = soDienThoai;
            txtCCCD.Text = socccd;
            labelMaKH.Text = maKH;

            // Gán giá trị cho RadioButton dựa trên giới tính được truyền vào
            if (gioiTinh.Equals("Nam"))
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
            }
            else if (gioiTinh.Equals("Nữ"))
            {
                rdbNam.Checked = false;
                rdbNu.Checked = true;
            }
        }
        private bool checkNumber(string number)
        {
            return int.TryParse(number, out int check);
        }
        BUS_qlks.BUS_khachhang buskh = new BUS_qlks.BUS_khachhang();
        BUS_qlks.Class1 busnv = new BUS_qlks.Class1();
        private bool isthemsuaKH;
        
        private void ValidateButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtSoDT.Text.Trim();

            // Kiểm tra xem chuỗi số điện thoại có phù hợp với định dạng không
            if (IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Số điện thoại hợp lệ!");
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
        }

        // Phương thức để kiểm tra định dạng số điện thoại
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Use a regular expression to check the Vietnamese phone number format
            // (e.g., 10 digits starting with 0, excluding the country code)
            Regex regex = new Regex(@"^0[0-9]{9}$");
            return regex.IsMatch(phoneNumber);
        }

        // Method to validate Vietnamese ID card number (Số CCCD) format
        private bool IsValidVietnameseID(string idNumber)
        {
            // Use a regular expression to check the Vietnamese ID card number format
            // (e.g., 9 to 12 digits)
            Regex regex = new Regex(@"^\d{9,12}$");
            return regex.IsMatch(idNumber);
        }
        private void btnThemSuaNV_Click(object sender, EventArgs e)
        {
            if (!isthemsuaKH)
            {
                labelMaKH.Visible = true;
                // Logic cập nhật thông tin khách hàng
                string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";

                // Validation for non-empty fields
                if (!string.IsNullOrWhiteSpace(txtHoten.Text) &&
                    (rdbNam.Checked || rdbNu.Checked) &&
                    !string.IsNullOrWhiteSpace(txtSoDT.Text) &&
                    !string.IsNullOrWhiteSpace(txtCCCD.Text))
                {
                    // Validation for Vietnamese phone number format
                    if (IsValidPhoneNumber(txtSoDT.Text.Trim()) && IsValidVietnameseID(txtCCCD.Text.Trim()))
                    {
                        DTO_khachhang khachHang = new DTO_khachhang()
                        {
                            Hoten = txtHoten.Text,
                            Gioitinh = gioiTinh,
                            Sodt = txtSoDT.Text,
                            Socccd = txtCCCD.Text,
                            Makhachhang = labelMaKH.Text,
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
                        MessageBox.Show("Số điện thoại hoặc số CCCD không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                string emailDaDangNhap = UserLoginInfo.Email;
                // Validation for non-empty fields
                if (!string.IsNullOrWhiteSpace(txtHoten.Text) &&
                    (rdbNam.Checked || rdbNu.Checked) &&
                    !string.IsNullOrWhiteSpace(txtSoDT.Text) &&
                    !string.IsNullOrWhiteSpace(txtCCCD.Text))
                {
                    // Validation for numeric values of phone number and ID card
                    if (checkNumber(txtSoDT.Text) && checkNumber(txtCCCD.Text))
                    {
                        // Validation for Vietnamese phone number format
                        if (IsValidPhoneNumber(txtSoDT.Text.Trim()) && IsValidVietnameseID(txtCCCD.Text.Trim()))
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
                                IsUpdated = true;

                            }
                            else
                            {
                                MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại hoặc số CCCD không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FromThemSuaKhachHang_Load(object sender, EventArgs e)
        {

        }



        private void txtSoDT_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSoDT.Text) && !txtSoDT.Text.Equals("Nhập số điện thoại (VD: 0987654321)"))
            {
                if (!txtSoDT.Text.StartsWith("0") || txtSoDT.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và có ít nhất 10 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDT.Focus();
                }
            }
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCCCD.Text) && !txtCCCD.Text.Equals("Nhập số CCCD (VD: 123456789)"))
            {
                if (txtCCCD.Text.Length < 9 || txtCCCD.Text.Length > 12)
                {
                    MessageBox.Show("Số CCCD cần ít nhất 9 và tối đa 12 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCCCD.Focus();
                }
            }
        }
    }
}
