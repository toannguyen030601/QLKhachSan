﻿namespace QLKhachSan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInfoDangnhap = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel13 = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1292, 38);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseUp += panel1_MouseUp;
            panel1.Move += panel1_Move;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel14.Controls.Add(btnMinimize);
            panel14.Controls.Add(btnMaximize);
            panel14.Controls.Add(btnClose);
            panel14.Location = new Point(1151, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(141, 38);
            panel14.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.minimize1;
            btnMinimize.ImageAlign = ContentAlignment.BottomCenter;
            btnMinimize.Location = new Point(3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 28);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.maximize1;
            btnMaximize.Location = new Point(46, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(37, 28);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.close2;
            btnClose.Location = new Point(89, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 28);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 2;
            label1.Text = "Luxury Hotel";
            // 
            // menu
            // 
            menu.Image = Properties.Resources.bar;
            menu.Location = new Point(4, 2);
            menu.Margin = new Padding(4, 3, 4, 3);
            menu.Name = "menu";
            menu.Size = new Size(50, 33);
            menu.SizeMode = PictureBoxSizeMode.CenterImage;
            menu.TabIndex = 1;
            menu.TabStop = false;
            menu.Click += menu_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ScrollBar;
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel12);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel10);
            sidebar.Controls.Add(panel11);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 38);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(250, 720);
            sidebar.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(btnInfoDangnhap);
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(lblTen);
            panel4.Controls.Add(picAvatar);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 166);
            panel4.TabIndex = 5;
            // 
            // btnInfoDangnhap
            // 
            btnInfoDangnhap.BackColor = Color.Transparent;
            btnInfoDangnhap.FlatAppearance.BorderSize = 0;
            btnInfoDangnhap.FlatStyle = FlatStyle.Flat;
            btnInfoDangnhap.Image = Properties.Resources.reset_password__1_;
            btnInfoDangnhap.ImageAlign = ContentAlignment.BottomCenter;
            btnInfoDangnhap.Location = new Point(219, 0);
            btnInfoDangnhap.Name = "btnInfoDangnhap";
            btnInfoDangnhap.Size = new Size(28, 34);
            btnInfoDangnhap.TabIndex = 3;
            btnInfoDangnhap.UseVisualStyleBackColor = false;
            btnInfoDangnhap.Click += btnInfoDangnhap_Click;
            btnInfoDangnhap.MouseLeave += btnInfoDangnhap_MouseLeave;
            btnInfoDangnhap.MouseHover += btnInfoDangnhap_MouseHover;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = Properties.Resources.logoutqlks1;
            btnLogout.ImageAlign = ContentAlignment.BottomCenter;
            btnLogout.Location = new Point(12, 6);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(42, 39);
            btnLogout.TabIndex = 2;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTen
            // 
            lblTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTen.Location = new Point(4, 132);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(240, 31);
            lblTen.TabIndex = 1;
            lblTen.Text = "label2";
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.Image = Properties.Resources.user;
            picAvatar.Location = new Point(60, 6);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(129, 123);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTrangChu);
            panel2.Location = new Point(0, 166);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 55);
            panel2.TabIndex = 3;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ScrollBar;
            btnTrangChu.Dock = DockStyle.Fill;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Image = Properties.Resources.home1;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Padding = new Padding(10, 0, 0, 0);
            btnTrangChu.Size = new Size(250, 55);
            btnTrangChu.TabIndex = 2;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += button1_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(button9);
            panel12.Location = new Point(0, 221);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(250, 55);
            panel12.TabIndex = 12;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ScrollBar;
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = Properties.Resources.phong1;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 0);
            button9.Name = "button9";
            button9.Padding = new Padding(10, 0, 0, 0);
            button9.Size = new Size(250, 55);
            button9.TabIndex = 2;
            button9.Text = "Phòng";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Location = new Point(0, 276);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 55);
            panel5.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.datphong;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(250, 55);
            button2.TabIndex = 2;
            button2.Text = "Đặt Phòng";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(button4);
            panel7.Location = new Point(0, 331);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 55);
            panel7.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ScrollBar;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.customer;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(250, 55);
            button4.TabIndex = 2;
            button4.Text = "QL Khách Hàng";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(button5);
            panel8.Location = new Point(0, 386);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 55);
            panel8.TabIndex = 8;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ScrollBar;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.qlphong;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(250, 55);
            button5.TabIndex = 2;
            button5.Text = "QL Phòng";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnHoaDon);
            panel6.Location = new Point(0, 441);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 55);
            panel6.TabIndex = 6;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = SystemColors.ScrollBar;
            btnHoaDon.Dock = DockStyle.Fill;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Image = Properties.Resources.hoadon;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 0);
            btnHoaDon.Margin = new Padding(0);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 0, 0);
            btnHoaDon.Size = new Size(250, 55);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Text = "Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(button6);
            panel9.Location = new Point(0, 496);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 55);
            panel9.TabIndex = 9;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ScrollBar;
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.loaiphong;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 0);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(250, 55);
            button6.TabIndex = 2;
            button6.Text = "QL Loai Phòng";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(button7);
            panel10.Location = new Point(0, 551);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(250, 55);
            panel10.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::QLKhachSan.Properties.Resources.dichvu;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(250, 55);
            this.button7.TabIndex = 2;
            this.button7.Text = "QL Dịch Vụ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel11
            // 
            panel11.Controls.Add(button8);
            panel11.Location = new Point(0, 606);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(250, 55);
            panel11.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::QLKhachSan.Properties.Resources.loaidichvu;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(250, 55);
            this.button8.TabIndex = 2;
            this.button8.Text = "QL Loại Dịch Vụ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNhanVien);
            panel3.Location = new Point(0, 661);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 55);
            panel3.TabIndex = 4;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = SystemColors.ScrollBar;
            btnNhanVien.Dock = DockStyle.Fill;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Image = Properties.Resources.nhanvien;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 0);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10, 0, 0, 0);
            btnNhanVien.Size = new Size(250, 55);
            btnNhanVien.TabIndex = 2;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(250, 699);
            panel13.Name = "panel13";
            panel13.Size = new Size(1042, 59);
            panel13.TabIndex = 2;
            // 
            // panelBody
            // 
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(250, 38);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1042, 661);
            panelBody.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 758);
            Controls.Add(panelBody);
            Controls.Add(panel13);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            sidebar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            panel2.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox menu;
        private FlowLayoutPanel sidebar;
        private Button btnTrangChu;
        private Panel panel2;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel3;
        private Button btnNhanVien;
        private Panel panel4;
        private PictureBox picAvatar;
        private Label lblTen;
        private Panel panel6;
        private Button btnHoaDon;
        private Panel panel5;
        private Button button2;
        private Panel panel11;
        private Button button8;
        private Panel panel10;
        private Panel panel9;
        private Button button6;
        private Panel panel8;
        private Button button5;
        private Panel panel7;
        private Button button4;
        private Button button7;
        private Panel panel12;
        private Button button9;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnMaximize;
        private Panel panel14;
        private Button btnLogout;
        private Panel panel13;
        private Panel panelBody;
        private Button btnInfoDangnhap;
    }
}