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
    public partial class FrmPhong : Form
    {
        BUS_Phong bus_Phong = new BUS_Phong();
        public FrmPhong()
        {
            InitializeComponent();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi button được nhấn
            Button btn = sender as Button;
            if (btn != null)
            {
                DTO_Phong phong = (DTO_Phong)btn.Tag;
                if (!phong.TrangThai)
                {
                    FrmDatPhongTrong frm = new FrmDatPhongTrong(phong.MaPhong);
                    frm.ShowDialog();
                }
                else
                {
                    string maHoaDon = bus_Phong.MaHoaDonCuaPhong(phong.MaPhong);
                    // Mở Form dịch vụ của phòng
                    FormThemDvu frm = new FormThemDvu(phong.MaPhong, maHoaDon);
                    frm.ShowDialog();
                }
            }

        }
        private void LoadPhong(double min = 0, double max = double.MaxValue, string maPhongTimKiem = "")
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = bus_Phong.DanhSachPhong();
            int count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maPhong = dt.Rows[i]["MaPhong"].ToString();
                if (maPhongTimKiem != "")
                {
                    if (maPhong != maPhongTimKiem) continue;
                }

                string tenPhong = dt.Rows[i]["TenPhong"].ToString();
                double gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                string maloaiPhong = dt.Rows[i]["MaLoaiPhong"].ToString();
                bool trangThai = Convert.ToBoolean(dt.Rows[i]["TrangThai"]);

                if (gia >= min && gia <= max)
                {
                    count++;
                    Button btn = new Button
                    {
                        Width = 190,
                        Height = 150,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        ForeColor = Color.Black,
                        FlatStyle = FlatStyle.Flat,
                        FlatAppearance = { BorderSize = 0 },
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    btn.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 20, 20));
                    btn.BackColor = trangThai ? Color.Tomato : Color.SpringGreen;

                    btn.Tag = new DTO_Phong(maPhong, tenPhong, gia, trangThai, maloaiPhong);

                    Label lblMaPhong = new Label
                    {
                        Text = maPhong,
                        Location = new Point(30, 10),
                        Font = new Font("Arial", 18, FontStyle.Bold),
                        AutoSize = true,
                        ForeColor = Color.Blue // Customize the color as needed
                    };

                    Label lblTenPhong = new Label
                    {
                        Text = tenPhong,
                        Location = new Point(30, 60),
                        AutoSize = true,
                        ForeColor = Color.Purple // Customize the color as needed
                    };

                    Label lblGia = new Label
                    {
                        Text = $"Giá: {gia} VND",
                        Location = new Point(30, 90),
                        AutoSize = true,
                        ForeColor = Color.White // Customize the color as needed
                    };

                    Label lblLoaiPhong = new Label
                    {
                        Text = bus_Phong.GetLoaiPhongFromMaLoaiPhong(maloaiPhong),
                        Location = new Point(30, 120),
                        ForeColor = Color.Black // Customize the color as needed
                    };

                    btn.Controls.Add(lblMaPhong);
                    btn.Controls.Add(lblTenPhong);
                    btn.Controls.Add(lblGia);
                    btn.Controls.Add(lblLoaiPhong);

                    btn.Click += Btn_Click;
                    if (rdoDaThue.Checked)
                    {
                        if (trangThai) flowLayoutPanel1.Controls.Add(btn);
                    }
                    else
                    {
                        if (rdoTrong.Checked)
                        {
                            if (!trangThai) flowLayoutPanel1.Controls.Add(btn);
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(btn);
                        }
                    }
                }

            }
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng cần tìm");
            }
        }
        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
            rdoTatCaTrangThai.Checked = true;
        }

        private void rdoTrong_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadPhong();
        }

        private void rdoDaThue_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadPhong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadPhong(0, double.MaxValue, txtTimKiem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQuanLiDSPhong frm = new FrmQuanLiDSPhong();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtMin.Text, out double Min))
            {
                if (txtMax.Text == "Max")
                {
                    LoadPhong();
                }
                else
                {
                    if (double.TryParse(txtMax.Text, out double Max))
                    {
                        LoadPhong(Min, Max);
                    }
                    else
                    {
                        MessageBox.Show("Nhập số để lọc");
                        txtMax.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập số để lọc");
                txtMin.Focus();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMax_Enter(object sender, EventArgs e)
        {
            if (txtMax.Text == "Max")
                txtMax.Text = "";
        }

        private void txtMin_Enter(object sender, EventArgs e)
        {
            if (txtMin.Text == "0")
            {
                txtMin.Text = "";
            }

        }

        private void txtMin_Leave(object sender, EventArgs e)
        {
            if (txtMin.Text == "")
            {
                txtMin.Text = "0";
            }
        }

        private void txtMax_Leave(object sender, EventArgs e)
        {
            if (txtMax.Text == "")
            {
                txtMax.Text = "Max";
            }
        }

        private void rdoTatCaTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            LoadPhong();
        }
    }
}
