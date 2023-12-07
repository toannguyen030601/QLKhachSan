using DTO_qlks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FormThemSuaNhanVien : Form
    {
        public FormThemSuaNhanVien(bool isthemsuanv)
        {
            InitializeComponent();
            this.isthemsuanv = isthemsuanv;

            //border
            this.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            btnTaianh.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnTaianh.Width, btnTaianh.Height, 20, 20));
            btnThemSuaNV.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThemSuaNV.Width, btnThemSuaNV.Height, 20, 20));
        }
        BUS_qlks.Class1 busnv = new BUS_qlks.Class1();

        public bool trangthai = false;

        public bool istrangthai {get{return trangthai; }}

        public string layemail { get; set; }
        private bool isthemsuanv;

        string checkUrlImg; //kiểm tra hình khi cập nhật
        string fileName; //tên file
        string fileSavePath = ""; // url store img
        string fileAddress; // url load img


        //refresh

        private bool isValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool checkNumber(string number)
        {
            return int.TryParse(number, out int check);
        }
        private bool IsCccdValid(string cccd)
        {
            // Kiểm tra xem số căn cước có đúng định dạng không (ví dụ: 12 chữ số).
            return cccd.Length == 12 && IsNumeric(cccd);
        }

        static bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^(032|033|034|035|036|037|038|039|096|097|098|086|083|084|085|081|082|088|091|094|070|079|077|076|078|090|093|089|056|058|092|059|099)[0-9]{7,8}$"; // Định dạng: Bắt đầu bằng "0" và sau đó là từ 10 đến 12 chữ số.

            Regex regex = new Regex(pattern);

            return regex.IsMatch(phoneNumber);
        }
        private void btnThemSuaNV_Click(object sender, EventArgs e)
        {
            if (isthemsuanv) // thêm nv
            {
                if (txtEmail.Text != "" && txtHoten.Text != "" && dtpNgaysinh.Text != "" && txtDiaChi.Text != "" && (rdbNam.Checked || rdbNu.Checked) && (rdbAmin.Checked || rdbNhanvien.Checked))
                {
                    if (IsPhoneNumberValid(txtSDT.Text))
                    {
                        if (IsCccdValid(txtSocccd.Text))
                        {
                            if (isValidEmail(txtEmail.Text))
                            {

                                string matkhau = busnv.getPassword();
                                string gioitinh = rdbNam.Checked ? "Nam" : "Nữ";
                                string chucvu = rdbAmin.Checked ? "Admin" : "Nhân viên";
                                DTO_nhanvien dtonv = new DTO_nhanvien()
                                {
                                    Email = txtEmail.Text,
                                    Hoten = txtHoten.Text,
                                    Socccd = txtSocccd.Text,
                                    Gioitinh = gioitinh,
                                    Chucvu = chucvu,
                                    Sodienthoai = txtSDT.Text,
                                    Ngaysinh = dtpNgaysinh.Value.ToString("d"),
                                    Diachi = txtDiaChi.Text,
                                    Hinhanh = @"\Img\" + fileName,
                                    Matkhau = matkhau
                                };

                                if (busnv.checkemail(txtEmail.Text))
                                {
                                    MessageBox.Show("Email này đã có trong hệ thống");
                                }
                                else
                                {
                                    if (busnv.ThemNhanVien(dtonv))
                                    {
                                        if (!Directory.Exists("Img"))
                                        {
                                            Directory.CreateDirectory("Img");
                                        }
                                        if (!string.IsNullOrEmpty(fileAddress))
                                        {
                                            File.Copy(fileAddress, fileSavePath, true);
                                        }
                                        FormMail sendMail = new FormMail(dtonv.Email, matkhau);
                                        sendMail.ShowDialog();
                                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        trangthai = true;
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm nhân viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email ko đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số CCCD không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("SĐT không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // sửa nv
            {
                if (lblManv.Text != "")
                {
                    if (txtEmail.Text != "" && txtHoten.Text != "" && dtpNgaysinh.Text != "" && txtDiaChi.Text != "" && (rdbNam.Checked || rdbNu.Checked) && (rdbAmin.Checked || rdbNhanvien.Checked))
                    {
                        if (IsPhoneNumberValid(txtSDT.Text))
                        {
                            if (IsCccdValid(txtSocccd.Text))
                            {
                                if (txtHinh.Text.Trim().Length != 0)
                                {
                                    if (isValidEmail(txtEmail.Text))
                                    {
                                        string gioitinh = rdbNam.Checked ? "Nam" : "Nữ";
                                        string chucvu = rdbAmin.Checked ? "Admin" : "Nhân viên";
                                        DTO_nhanvien dtonv = new DTO_nhanvien()
                                        {
                                            Email = txtEmail.Text,
                                            Hoten = txtHoten.Text,
                                            Socccd = txtSocccd.Text,
                                            Gioitinh = gioitinh,
                                            Chucvu = chucvu,
                                            Sodienthoai = txtSDT.Text,
                                            Ngaysinh = dtpNgaysinh.Value.ToString("d"),
                                            Diachi = txtDiaChi.Text,
                                            Hinhanh = txtHinh.Text
                                        };
                                        if (MessageBox.Show("Bạn có chắc muốn sửa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            if (busnv.SuaNhanvien(dtonv))
                                            {
                                                if (!Directory.Exists("Img"))
                                                {
                                                    Directory.CreateDirectory("Img");
                                                }
                                                try
                                                {
                                                    if (txtHinh.Text != checkUrlImg)
                                                    {
                                                        File.Copy(fileAddress, fileSavePath, true);
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine(ex.Message);
                                                }
                                                trangthai = true;
                                                MessageBox.Show("Sửa thành công");
                                                Form1 parentForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                                                if (parentForm != null)
                                                {
                                                    // Gọi phương thức cập nhật thông tin trong form cha
                                                    parentForm.infocuaban();
                                                }
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Sửa không thành công");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Email ko đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng chọn hình ảnh!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    btnTaianh.Focus();
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số CCCD không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("SĐT không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void FormThemSuaNhanVien_Load(object sender, EventArgs e)
        {
            if (!isthemsuanv)
            {
                string saveDirectory = Application.StartupPath;
                DataTable data = busnv.thongtinnhanvien(layemail);
                lblManv.Text = data.Rows[0][0].ToString();
                txtEmail.Text = data.Rows[0][6].ToString();
                txtHoten.Text = data.Rows[0][2].ToString();
                txtSocccd.Text = data.Rows[0][1].ToString();
                string gioitinh = data.Rows[0][3].ToString();
                if(gioitinh == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                string chucvu = data.Rows[0][4].ToString();
                if(chucvu == "Admin")
                {
                    rdbAmin.Checked= true;
                }
                else
                {
                    rdbNhanvien.Checked = true;
                }
                txtSDT.Text = data.Rows[0][10].ToString();
                dtpNgaysinh.Text = data.Rows[0][5].ToString();
                txtDiaChi.Text = data.Rows[0][7].ToString();
                txtHinh.Text = data.Rows[0][8].ToString();
                checkUrlImg = txtHinh.Text;

                string imagePath = saveDirectory + data.Rows[0][8].ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    picHinhanh.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Nếu không có hình ảnh hoặc đường dẫn không hợp lệ, bạn có thể hiển thị một hình ảnh mặc định hoặc để picHinhanh là null.
                    picHinhanh.Image = Properties.Resources.hinhanh; // hoặc hiển thị hình mặc định picHinhanh.Image = Properties.Resources.defaultImage;
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTaianh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";
            op.FilterIndex = 2;
            op.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (op.ShowDialog() == DialogResult.OK)
            {
                fileAddress = op.FileName;
                picHinhanh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(fileAddress);
                string saveDirectory = Application.StartupPath;
                fileSavePath = saveDirectory + @"\Img\" + fileName;
                txtHinh.Text = @"\Img\" + fileName;

            }
        }
    }
}
