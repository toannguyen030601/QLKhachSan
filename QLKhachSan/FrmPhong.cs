﻿using BUS_qlks;
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
               DTO_Phong phong=(DTO_Phong)btn.Tag;
               MessageBox.Show(phong.TenPhong.ToString());
            }
        }
        private void LoadPhong()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = bus_Phong.DanhSachPhong();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maPhong = dt.Rows[i]["MaPhong"].ToString();
                string tenPhong = dt.Rows[i]["TenPhong"].ToString();
                double gia = Convert.ToDouble(dt.Rows[i]["Gia"]);
                string maloaiPhong = dt.Rows[i]["MaLoaiPhong"].ToString();

                Button btn = new Button
                {
                    Width = 200,
                    Height = 150,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 4 },
                    TextAlign = ContentAlignment.MiddleCenter,
                    
                };
                bool trangThai = Convert.ToBoolean(dt.Rows[i]["TrangThai"]);
                btn.BackColor = trangThai ? Color.Tomato : Color.SpringGreen;

                btn.Tag = new DTO_Phong(maPhong,tenPhong,gia,trangThai,maloaiPhong);

                Label lblMaPhong = new Label
                {
                    Text = maPhong,
                    Location = new Point(40, 10),
                    Font = new Font("Arial", 18, FontStyle.Bold),
                    AutoSize=true,
                    ForeColor = Color.Blue // Customize the color as needed
                };

                Label lblTenPhong = new Label
                {
                    Text = tenPhong,
                    Location = new Point(40, 60),
                    AutoSize = true,
                    ForeColor = Color.Purple // Customize the color as needed
                };

                Label lblGia = new Label
                {
                    Text = $"Giá: {gia} VND",
                    Location = new Point(40, 90),
                    AutoSize=true,
                    ForeColor = Color.White // Customize the color as needed
                };

                Label lblLoaiPhong = new Label
                {
                    Text = maloaiPhong,
                    Location = new Point(40, 120),
                    ForeColor = Color.Black // Customize the color as needed
                };

                btn.Controls.Add(lblMaPhong);
                btn.Controls.Add(lblTenPhong);
                btn.Controls.Add(lblGia);
                btn.Controls.Add(lblLoaiPhong);

                btn.Click += Btn_Click;

                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQuanLiDSPhong frm = new FrmQuanLiDSPhong();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
