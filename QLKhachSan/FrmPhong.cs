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

            }
        }
        private void LoadPhong()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = bus_Phong.DanhSachPhong();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button
                {
                    Width = 200,
                    Height = 150,
                    Margin = new Padding(5), // Khoảng cách giữa các button
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 4 }, // Loại bỏ viền của button
                    TextAlign = ContentAlignment.MiddleCenter
                };
                bool trangThai = Convert.ToBoolean(dt.Rows[i]["TrangThai"]);
                if (rdoDaThue.Checked)
                {
                    if (trangThai)
                    {
                        flowLayoutPanel1.Controls.Add(btn);
                    }
                }
                else
                {
                    if (rdoTrong.Checked)
                    {
                        if (!trangThai) { flowLayoutPanel1.Controls.Add(btn); }
                    }
                    else flowLayoutPanel1.Controls.Add(btn);
                }
                string maPhong = dt.Rows[i]["MaPhong"].ToString();
                string tenPhong = dt.Rows[i]["TenPhong"].ToString();
                double gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                string maloaiPhong = dt.Rows[i]["MaLoaiPhong"].ToString();

                // Gán các thông tin vào Tag của button
                btn.Tag = new DTO_Phong(maPhong, tenPhong, gia, trangThai, maloaiPhong);

                // Thiết lập màu nền của button dựa trên trạng thái
                if (trangThai)
                {
                    btn.BackColor = Color.Tomato;
                }
                else
                {
                    //Trống
                    btn.BackColor = Color.SpringGreen;
                }

                // Hiển thị thông tin trên button
                btn.Text = $"Mã Phòng: {maPhong}\nTên Phòng: {tenPhong}\nGiá: {gia}\nLoại Phòng: {maloaiPhong}";

                btn.Click += Btn_Click;
            }
        }


        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
            rdoTatCa.Checked = true;
            rdoTatCaTrangThai.Checked = true;
        }

        private void rdoTrong_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void rdoDaThue_CheckedChanged(object sender, EventArgs e)
        {
            LoadPhong();
        }
    }
}
