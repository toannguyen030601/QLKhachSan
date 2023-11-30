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
            lbTenKH = new Label();
            lblMaDichVu = new Label();
            lblMaHoaDonChiTiet = new Label();
            lbMaHoaDon = new Label();
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
            label1.Location = new Point(81, 55);
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
            groupBox1.Location = new Point(91, 94);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(99, 60);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm loại dịch vụ";
            // 
            // txtTimdv
            // 
            txtTimdv.Location = new Point(10, 27);
            txtTimdv.Margin = new Padding(2);
            txtTimdv.Name = "txtTimdv";
            txtTimdv.Size = new Size(73, 30);
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
            dGVDichVu.Location = new Point(37, 158);
            dGVDichVu.Margin = new Padding(2);
            dGVDichVu.Name = "dGVDichVu";
            dGVDichVu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dGVDichVu.RowTemplate.Height = 35;
            dGVDichVu.Size = new Size(283, 167);
            dGVDichVu.TabIndex = 2;
            dGVDichVu.CellClick += dGVDichVu_CellClick;
            dGVDichVu.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dGVDichVuDaChon
            // 
            dGVDichVuDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVDichVuDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVDichVuDaChon.Location = new Point(416, 158);
            dGVDichVuDaChon.Margin = new Padding(2);
            dGVDichVuDaChon.Name = "dGVDichVuDaChon";
            dGVDichVuDaChon.RowHeadersWidth = 51;
            dGVDichVuDaChon.RowTemplate.Height = 35;
            dGVDichVuDaChon.Size = new Size(285, 167);
            dGVDichVuDaChon.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(469, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 39);
            label2.TabIndex = 4;
            label2.Text = "Dịch vụ đã chọn";
            label2.Click += label2_Click;
            // 
            // btnPhai
            // 
            btnPhai.Location = new Point(336, 227);
            btnPhai.Margin = new Padding(2);
            btnPhai.Name = "btnPhai";
            btnPhai.Size = new Size(67, 42);
            btnPhai.TabIndex = 5;
            btnPhai.Text = ">>";
            btnPhai.UseVisualStyleBackColor = true;
            btnPhai.Click += btnPhai_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(469, 336);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 25);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(566, 336);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 25);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(383, 336);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(70, 25);
            button1.TabIndex = 9;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnXoa;
            // 
            // lbMaPhong
            // 
            lbMaPhong.AutoSize = true;
            lbMaPhong.Location = new Point(47, 21);
            lbMaPhong.Margin = new Padding(2, 0, 2, 0);
            lbMaPhong.Name = "lbMaPhong";
            lbMaPhong.Size = new Size(76, 20);
            lbMaPhong.TabIndex = 10;
            lbMaPhong.Text = "Mã Phòng";
            // 
            // lbTenKH
            // 
            lbTenKH.AutoSize = true;
            lbTenKH.Location = new Point(250, 21);
            lbTenKH.Margin = new Padding(2, 0, 2, 0);
            lbTenKH.Name = "lbTenKH";
            lbTenKH.Size = new Size(56, 20);
            lbTenKH.TabIndex = 11;
            lbTenKH.Text = "MÃ KH";
            // 
            // lblMaDichVu
            // 
            lblMaDichVu.AutoSize = true;
            lblMaDichVu.Location = new Point(225, 110);
            lblMaDichVu.Name = "lblMaDichVu";
            lblMaDichVu.Size = new Size(81, 20);
            lblMaDichVu.TabIndex = 12;
            lblMaDichVu.Text = "Mã dịch vụ";
            // 
            // lblMaHoaDonChiTiet
            // 
            lblMaHoaDonChiTiet.AutoSize = true;
            lblMaHoaDonChiTiet.Location = new Point(454, 110);
            lblMaHoaDonChiTiet.Name = "lblMaHoaDonChiTiet";
            lblMaHoaDonChiTiet.Size = new Size(73, 20);
            lblMaHoaDonChiTiet.TabIndex = 13;
            lblMaHoaDonChiTiet.Text = "Mã HDCT";
            // 
            // lbMaHoaDon
            // 
            lbMaHoaDon.AutoSize = true;
            lbMaHoaDon.Location = new Point(403, 21);
            lbMaHoaDon.Margin = new Padding(2, 0, 2, 0);
            lbMaHoaDon.Name = "lbMaHoaDon";
            lbMaHoaDon.Size = new Size(94, 20);
            lbMaHoaDon.TabIndex = 14;
            lbMaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // FormThemDvu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 384);
            Controls.Add(lbMaHoaDon);
            Controls.Add(lblMaHoaDonChiTiet);
            Controls.Add(lblMaDichVu);
            Controls.Add(lbTenKH);
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
        private Label lbTenKH;
        private TextBox txtTimdv;
        private Label lblMaDichVu;
        private Label lblMaHoaDonChiTiet;
        private Label lbMaHoaDon;
    }
}