namespace QLKhachSan
{
    partial class FormThemDvu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTimdv = new TextBox();
            dGVDichVu = new DataGridView();
            dGVDichVuDaChon = new DataGridView();
            label2 = new Label();
            btnPhai = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            button1 = new Button();
            lbMaPhong = new Label();
            lblTenKH = new Label();
            lblMaDichVu = new Label();
            lblMaHoaDonChiTiet = new Label();
            lbMaHoaDon = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGVDichVuDaChon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(63, 158);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 39);
            label1.TabIndex = 0;
            label1.Text = "Danh sách dịch vụ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTimdv);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(95, 212);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(176, 77);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm loại dịch vụ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtTimdv
            // 
            txtTimdv.Location = new Point(25, 43);
            txtTimdv.Margin = new Padding(2);
            txtTimdv.Name = "txtTimdv";
            txtTimdv.Size = new Size(106, 30);
            txtTimdv.TabIndex = 0;
            txtTimdv.TextChanged += txtTimdv_TextChanged;
            // 
            // dGVDichVu
            // 
            dGVDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGVDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGVDichVu.ColumnHeadersHeight = 29;
            dGVDichVu.Location = new Point(63, 306);
            dGVDichVu.Margin = new Padding(2);
            dGVDichVu.Name = "dGVDichVu";
            dGVDichVu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dGVDichVu.RowTemplate.Height = 35;
            dGVDichVu.Size = new Size(387, 216);
            dGVDichVu.TabIndex = 2;
            dGVDichVu.CellClick += dGVDichVu_CellClick;
            dGVDichVu.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dGVDichVuDaChon
            // 
            dGVDichVuDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVDichVuDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVDichVuDaChon.Location = new Point(613, 306);
            dGVDichVuDaChon.Margin = new Padding(2);
            dGVDichVuDaChon.Name = "dGVDichVuDaChon";
            dGVDichVuDaChon.RowHeadersWidth = 51;
            dGVDichVuDaChon.RowTemplate.Height = 35;
            dGVDichVuDaChon.Size = new Size(374, 209);
            dGVDichVuDaChon.TabIndex = 3;
            dGVDichVuDaChon.CellClick += dGVDichVuDaChon_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(670, 194);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 39);
            label2.TabIndex = 4;
            label2.Text = "Dịch vụ đã chọn";
            label2.Click += label2_Click;
            // 
            // btnPhai
            // 
            btnPhai.Image = Properties.Resources.send_message__1_1;
            btnPhai.Location = new Point(494, 393);
            btnPhai.Margin = new Padding(2);
            btnPhai.Name = "btnPhai";
            btnPhai.Size = new Size(72, 57);
            btnPhai.TabIndex = 5;
            btnPhai.UseVisualStyleBackColor = true;
            btnPhai.Click += btnPhai_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(454, 594);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(138, 50);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Hóa Đơn";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(652, 594);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 50);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(276, 594);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 9;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnXoa;
            // 
            // lbMaPhong
            // 
            lbMaPhong.AutoSize = true;
            lbMaPhong.BackColor = SystemColors.Control;
            lbMaPhong.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaPhong.ForeColor = Color.Tomato;
            lbMaPhong.Location = new Point(63, 78);
            lbMaPhong.Margin = new Padding(2, 0, 2, 0);
            lbMaPhong.Name = "lbMaPhong";
            lbMaPhong.Size = new Size(139, 32);
            lbMaPhong.TabIndex = 10;
            lbMaPhong.Text = "Mã Phòng";
            lbMaPhong.Click += lbMaPhong_Click;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.BackColor = SystemColors.Control;
            lblTenKH.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenKH.ForeColor = Color.Tomato;
            lblTenKH.Location = new Point(342, 78);
            lblTenKH.Margin = new Padding(2, 0, 2, 0);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(112, 32);
            lblTenKH.TabIndex = 11;
            lblTenKH.Text = "Tên KH";
            lblTenKH.Click += lbTenKH_Click;
            // 
            // lblMaDichVu
            // 
            lblMaDichVu.AutoSize = true;
            lblMaDichVu.Location = new Point(276, 239);
            lblMaDichVu.Name = "lblMaDichVu";
            lblMaDichVu.Size = new Size(81, 20);
            lblMaDichVu.TabIndex = 12;
            lblMaDichVu.Text = "Mã dịch vụ";
            // 
            // lblMaHoaDonChiTiet
            // 
            lblMaHoaDonChiTiet.AutoSize = true;
            lblMaHoaDonChiTiet.Location = new Point(584, 239);
            lblMaHoaDonChiTiet.Name = "lblMaHoaDonChiTiet";
            lblMaHoaDonChiTiet.Size = new Size(73, 20);
            lblMaHoaDonChiTiet.TabIndex = 13;
            lblMaHoaDonChiTiet.Text = "Mã HDCT";
            // 
            // lbMaHoaDon
            // 
            lbMaHoaDon.AutoSize = true;
            lbMaHoaDon.BackColor = SystemColors.Control;
            lbMaHoaDon.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHoaDon.ForeColor = Color.Tomato;
            lbMaHoaDon.Location = new Point(701, 78);
            lbMaHoaDon.Margin = new Padding(2, 0, 2, 0);
            lbMaHoaDon.Name = "lbMaHoaDon";
            lbMaHoaDon.Size = new Size(170, 32);
            lbMaHoaDon.TabIndex = 14;
            lbMaHoaDon.Text = "Mã Hóa Đơn";
            lbMaHoaDon.Click += lbMaHoaDon_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(342, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 3);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(701, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 3);
            panel4.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(63, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 3);
            panel1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 38);
            label3.Name = "label3";
            label3.Size = new Size(107, 26);
            label3.TabIndex = 18;
            label3.Text = "Mã Phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(352, 27);
            label4.Name = "label4";
            label4.Size = new Size(168, 26);
            label4.TabIndex = 19;
            label4.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(701, 27);
            label5.Name = "label5";
            label5.Size = new Size(131, 26);
            label5.TabIndex = 20;
            label5.Text = "Mã Hóa Đơn";
            // 
            // FormThemDvu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 661);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lbMaHoaDon);
            Controls.Add(lblMaHoaDonChiTiet);
            Controls.Add(lblMaDichVu);
            Controls.Add(lblTenKH);
            Controls.Add(lbMaPhong);
            Controls.Add(button1);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnPhai);
            Controls.Add(label2);
            Controls.Add(dGVDichVuDaChon);
            Controls.Add(dGVDichVu);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormThemDvu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThemDvu";
            Load += FormThemDvu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGVDichVuDaChon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dGVDichVu;
        private DataGridView dGVDichVuDaChon;
        private Label label2;
        private Button btnPhai;
        private Button btnLuu;
        private Button btnThoat;
        private Button button1;
        private Label lbMaPhong;
        private Label lblTenKH;
        private TextBox txtTimdv;
        private Label lblMaDichVu;
        private Label lblMaHoaDonChiTiet;
        private Label lbMaHoaDon;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}