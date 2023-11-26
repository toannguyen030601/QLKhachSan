namespace QLKhachSan
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
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.btnInfoDangnhap);
            this.panel4.Controls.Add(this.btnLogout);
            this.panel4.Controls.Add(this.lblTen);
            this.panel4.Controls.Add(this.picAvatar);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 166);
            this.panel4.TabIndex = 5;
            // 
            // btnInfoDangnhap
            // 
            this.btnInfoDangnhap.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoDangnhap.FlatAppearance.BorderSize = 0;
            this.btnInfoDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoDangnhap.Image = global::QLKhachSan.Properties.Resources.infoMain;
            this.btnInfoDangnhap.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInfoDangnhap.Location = new System.Drawing.Point(227, 0);
            this.btnInfoDangnhap.Name = "btnInfoDangnhap";
            this.btnInfoDangnhap.Size = new System.Drawing.Size(23, 24);
            this.btnInfoDangnhap.TabIndex = 3;
            this.btnInfoDangnhap.UseVisualStyleBackColor = false;
            this.btnInfoDangnhap.Click += new System.EventHandler(this.btnInfoDangnhap_Click);
            this.btnInfoDangnhap.MouseLeave += new System.EventHandler(this.btnInfoDangnhap_MouseLeave);
            this.btnInfoDangnhap.MouseHover += new System.EventHandler(this.btnInfoDangnhap_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::QLKhachSan.Properties.Resources.logoutqlks1;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.Location = new System.Drawing.Point(12, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(42, 39);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTen
            // 
            this.lblTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTen.Location = new System.Drawing.Point(4, 132);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(240, 31);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "label2";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::QLKhachSan.Properties.Resources.user;
            this.picAvatar.Location = new System.Drawing.Point(60, 6);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(129, 123);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
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
            button7.BackColor = SystemColors.ScrollBar;
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.dichvu;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 0);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(250, 55);
            button7.TabIndex = 2;
            button7.Text = "QL Dịch Vụ";
            button7.UseVisualStyleBackColor = false;
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
            button8.BackColor = SystemColors.ScrollBar;
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.loaidichvu;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 0);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Padding = new Padding(10, 0, 0, 0);
            button8.Size = new Size(250, 55);
            button8.TabIndex = 2;
            button8.Text = "QL Loại Dịch Vụ";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNhanVien);
            this.panel3.Location = new System.Drawing.Point(0, 661);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 55);
            this.panel3.TabIndex = 4;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Image = global::QLKhachSan.Properties.Resources.nhanvien;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(250, 55);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 758);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

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