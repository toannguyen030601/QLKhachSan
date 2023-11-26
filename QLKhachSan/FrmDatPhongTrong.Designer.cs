namespace QLKhachSan
{
    partial class FrmDatPhongTrong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatPhongTrong));
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cbGT = new ComboBox();
            panel4 = new Panel();
            txtSoCCCD = new TextBox();
            panel2 = new Panel();
            txtHoTen = new TextBox();
            panel3 = new Panel();
            txtSDT = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            lblMaPhong = new Label();
            dtpNgayDat = new DateTimePicker();
            btnDatPhong = new Button();
            btnHuy = new Button();
            label3 = new Label();
            label4 = new Label();
            lblMaNhanVien = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.lavatory;
            pictureBox4.Location = new Point(60, 371);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 40);
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.telephone;
            pictureBox3.Location = new Point(60, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 40);
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.id_card__1_;
            pictureBox2.Location = new Point(65, 114);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 40);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.id_card;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(60, 304);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 35);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // cbGT
            // 
            cbGT.BackColor = SystemColors.ControlLightLight;
            cbGT.FormattingEnabled = true;
            cbGT.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGT.Location = new Point(118, 371);
            cbGT.Name = "cbGT";
            cbGT.Size = new Size(183, 34);
            cbGT.TabIndex = 28;
            cbGT.Text = "Chọn giới tính";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(109, 337);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 2);
            panel4.TabIndex = 27;
            // 
            // txtSoCCCD
            // 
            txtSoCCCD.BackColor = SystemColors.ControlLight;
            txtSoCCCD.BorderStyle = BorderStyle.None;
            txtSoCCCD.Location = new Point(109, 304);
            txtSoCCCD.Name = "txtSoCCCD";
            txtSoCCCD.Size = new Size(254, 27);
            txtSoCCCD.TabIndex = 26;
            txtSoCCCD.Text = "Nhập Số CCCD";
            txtSoCCCD.Enter += txtSoCCCD_Enter;
            txtSoCCCD.Leave += txtSoCCCD_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(109, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 2);
            panel2.TabIndex = 25;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.ControlLight;
            txtHoTen.BorderStyle = BorderStyle.None;
            txtHoTen.Location = new Point(109, 114);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(254, 27);
            txtHoTen.TabIndex = 24;
            txtHoTen.Text = "Nhập Họ Tên";
            txtHoTen.Enter += txtHoTen_Enter;
            txtHoTen.Leave += txtHoTen_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(109, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 2);
            panel3.TabIndex = 23;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = SystemColors.ControlLight;
            txtSDT.BorderStyle = BorderStyle.None;
            txtSDT.Location = new Point(109, 207);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(254, 27);
            txtSDT.TabIndex = 22;
            txtSDT.Text = "Nhập Số Điện Thoại";
            txtSDT.Enter += txtSDT_Enter;
            txtSDT.Leave += txtSDT_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(65, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 2);
            panel1.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 34);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(528, 25);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 19;
            label2.Text = "THÔNG TIN PHÒNG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(74, 25);
            label1.Name = "label1";
            label1.Size = new Size(280, 28);
            label1.TabIndex = 18;
            label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(484, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 2);
            panel5.TabIndex = 22;
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaPhong.ForeColor = Color.DarkRed;
            lblMaPhong.Location = new Point(570, 85);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(168, 43);
            lblMaPhong.TabIndex = 33;
            lblMaPhong.Text = "Mã Phòng";
            // 
            // dtpNgayDat
            // 
            dtpNgayDat.Format = DateTimePickerFormat.Time;
            dtpNgayDat.Location = new Point(667, 169);
            dtpNgayDat.Name = "dtpNgayDat";
            dtpNgayDat.Size = new Size(147, 34);
            dtpNgayDat.TabIndex = 34;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.Chartreuse;
            btnDatPhong.FlatStyle = FlatStyle.Popup;
            btnDatPhong.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatPhong.ForeColor = Color.Brown;
            btnDatPhong.Location = new Point(505, 386);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(129, 55);
            btnDatPhong.TabIndex = 35;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Chartreuse;
            btnHuy.FlatStyle = FlatStyle.Popup;
            btnHuy.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Brown;
            btnHuy.Location = new Point(715, 386);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(99, 55);
            btnHuy.TabIndex = 36;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 175);
            label3.Name = "label3";
            label3.Size = new Size(175, 26);
            label3.TabIndex = 37;
            label3.Text = "Thời gian bắt đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 270);
            label4.Name = "label4";
            label4.Size = new Size(111, 26);
            label4.TabIndex = 38;
            label4.Text = "Nhân Viên";
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaNhanVien.ForeColor = Color.DarkRed;
            lblMaNhanVien.Location = new Point(640, 268);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(158, 28);
            lblMaNhanVien.TabIndex = 39;
            lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // FrmDatPhongTrong
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(858, 453);
            Controls.Add(lblMaNhanVien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnHuy);
            Controls.Add(btnDatPhong);
            Controls.Add(dtpNgayDat);
            Controls.Add(lblMaPhong);
            Controls.Add(panel5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cbGT);
            Controls.Add(panel4);
            Controls.Add(txtSoCCCD);
            Controls.Add(panel2);
            Controls.Add(txtHoTen);
            Controls.Add(panel3);
            Controls.Add(txtSDT);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmDatPhongTrong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Phòng";
            Load += FrmDatPhongTrong_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox cbGT;
        private Panel panel4;
        private TextBox txtSoCCCD;
        private Panel panel2;
        private TextBox txtHoTen;
        private Panel panel3;
        private TextBox txtSDT;
        private Panel panel1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Label lblMaPhong;
        private DateTimePicker dtpNgayDat;
        private Button btnDatPhong;
        private Button btnHuy;
        private Label label3;
        private Label label4;
        private Label lblMaNhanVien;
    }
}