namespace QLKhachSan
{
    partial class FrmQuanLiDSPhong
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
            btnMoi = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            dgvDSPhong = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaPhong = new TextBox();
            groupBox1 = new GroupBox();
            rdoTrong = new RadioButton();
            rdoDaThue = new RadioButton();
            groupBox2 = new GroupBox();
            cbMaLoaiPhong = new ComboBox();
            txtTenPhong = new TextBox();
            txtGia = new TextBox();
            btnSoDo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDSPhong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMoi
            // 
            btnMoi.Image = Properties.Resources.add2;
            btnMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnMoi.Location = new Point(41, 130);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(94, 59);
            btnMoi.TabIndex = 19;
            btnMoi.Text = "Mới";
            btnMoi.TextAlign = ContentAlignment.MiddleRight;
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // btnHuy
            // 
            btnHuy.Image = Properties.Resources.multiply;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(41, 488);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 59);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete1;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(41, 407);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 59);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.edit1;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(41, 314);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 59);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.diskette;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(41, 220);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 59);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // dgvDSPhong
            // 
            dgvDSPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSPhong.Location = new Point(214, 229);
            dgvDSPhong.Name = "dgvDSPhong";
            dgvDSPhong.RowHeadersWidth = 51;
            dgvDSPhong.RowTemplate.Height = 29;
            dgvDSPhong.Size = new Size(678, 339);
            dgvDSPhong.TabIndex = 20;
            dgvDSPhong.CellClick += dgvDSPhong_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 14);
            label1.Name = "label1";
            label1.Size = new Size(107, 26);
            label1.TabIndex = 21;
            label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(615, 20);
            label2.Name = "label2";
            label2.Size = new Size(44, 26);
            label2.TabIndex = 22;
            label2.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 80);
            label3.Name = "label3";
            label3.Size = new Size(114, 26);
            label3.TabIndex = 23;
            label3.Text = "Tên Phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 152);
            label4.Name = "label4";
            label4.Size = new Size(0, 26);
            label4.TabIndex = 24;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(313, 6);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(190, 34);
            txtMaPhong.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoTrong);
            groupBox1.Controls.Add(rdoDaThue);
            groupBox1.Location = new Point(214, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 74);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng Thái";
            // 
            // rdoTrong
            // 
            rdoTrong.AutoSize = true;
            rdoTrong.Location = new Point(160, 35);
            rdoTrong.Name = "rdoTrong";
            rdoTrong.Size = new Size(89, 30);
            rdoTrong.TabIndex = 1;
            rdoTrong.TabStop = true;
            rdoTrong.Text = "Trống";
            rdoTrong.UseVisualStyleBackColor = true;
            // 
            // rdoDaThue
            // 
            rdoDaThue.AutoSize = true;
            rdoDaThue.Location = new Point(16, 35);
            rdoDaThue.Name = "rdoDaThue";
            rdoDaThue.Size = new Size(106, 30);
            rdoDaThue.TabIndex = 0;
            rdoDaThue.TabStop = true;
            rdoDaThue.Text = "Đã thuê";
            rdoDaThue.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbMaLoaiPhong);
            groupBox2.Location = new Point(603, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 78);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mã Loại Phòng";
            // 
            // cbMaLoaiPhong
            // 
            cbMaLoaiPhong.FormattingEnabled = true;
            cbMaLoaiPhong.Location = new Point(34, 33);
            cbMaLoaiPhong.Name = "cbMaLoaiPhong";
            cbMaLoaiPhong.Size = new Size(151, 34);
            cbMaLoaiPhong.TabIndex = 0;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(313, 58);
            txtTenPhong.Multiline = true;
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(190, 61);
            txtTenPhong.TabIndex = 28;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(685, 12);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(124, 34);
            txtGia.TabIndex = 29;
            // 
            // btnSoDo
            // 
            btnSoDo.Location = new Point(1, 14);
            btnSoDo.Name = "btnSoDo";
            btnSoDo.Size = new Size(147, 39);
            btnSoDo.TabIndex = 30;
            btnSoDo.Text = "Sơ đồ Phòng";
            btnSoDo.UseVisualStyleBackColor = true;
            btnSoDo.Click += btnSoDo_Click;
            // 
            // FrmQuanLiDSPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 566);
            Controls.Add(btnSoDo);
            Controls.Add(txtGia);
            Controls.Add(txtTenPhong);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtMaPhong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDSPhong);
            Controls.Add(btnMoi);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmQuanLiDSPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmQuanLiDSPhong";
            Load += FrmQuanLiDSPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDSPhong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMoi;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private DataGridView dgvDSPhong;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaPhong;
        private GroupBox groupBox1;
        private RadioButton rdoTrong;
        private RadioButton rdoDaThue;
        private GroupBox groupBox2;
        private ComboBox cbMaLoaiPhong;
        private TextBox txtTenPhong;
        private TextBox txtGia;
        private Button btnSoDo;
    }
}