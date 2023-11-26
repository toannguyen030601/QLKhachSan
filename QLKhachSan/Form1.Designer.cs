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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel14 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            label1 = new Label();
            menu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel4 = new Panel();
            btnInfoDangnhap = new Button();
            btnLogout = new Button();
            lblTen = new Label();
            picAvatar = new PictureBox();
            panel2 = new Panel();
            btnTrangChu = new Button();
            panel12 = new Panel();
            button9 = new Button();
            panel5 = new Panel();
            button2 = new Button();
            panel7 = new Panel();
            button4 = new Button();
            panel8 = new Panel();
            button5 = new Button();
            panel6 = new Panel();
            button3 = new Button();
            panel9 = new Panel();
            button6 = new Button();
            panel10 = new Panel();
            button7 = new Button();
            panel11 = new Panel();
            button8 = new Button();
            panel3 = new Panel();
            btnNhanVien = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel13 = new Panel();
            panelBody = new Panel();
            panel1.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            sidebar.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 38);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Move += new System.EventHandler(this.panel1_Move);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Luxury Hotel";
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
            this.button9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::QLKhachSan.Properties.Resources.phong1;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(250, 55);
            this.button9.TabIndex = 2;
            this.button9.Text = "Phòng";
            this.button9.UseVisualStyleBackColor = false;
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
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::QLKhachSan.Properties.Resources.qlphong;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 55);
            this.button5.TabIndex = 2;
            this.button5.Text = "QL Phòng";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button3);
            panel6.Location = new Point(0, 441);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 55);
            panel6.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::QLKhachSan.Properties.Resources.hoadon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hóa Đơn";
            this.button3.UseVisualStyleBackColor = false;
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
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::QLKhachSan.Properties.Resources.loaiphong;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 55);
            this.button6.TabIndex = 2;
            this.button6.Text = "QL Loai Phòng";
            this.button6.UseVisualStyleBackColor = false;
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
        private Button button3;
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