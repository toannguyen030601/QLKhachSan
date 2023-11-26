namespace QLKhachSan
{
    partial class FrmQuanLiLoaiPhong
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
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtLoaiPhong = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dgvLoaiPhong = new DataGridView();
            label3 = new Label();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnMoi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(343, 54);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Loại Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(343, 158);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 1;
            label2.Text = "Loại Phòng";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(343, 83);
            txtID.Name = "txtID";
            txtID.Size = new Size(208, 34);
            txtID.TabIndex = 2;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtLoaiPhong
            // 
            txtLoaiPhong.BorderStyle = BorderStyle.FixedSingle;
            txtLoaiPhong.Location = new Point(343, 187);
            txtLoaiPhong.Name = "txtLoaiPhong";
            txtLoaiPhong.Size = new Size(208, 34);
            txtLoaiPhong.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(343, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 3);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(343, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 3);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.id;
            pictureBox1.Location = new Point(297, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 34);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hotel;
            pictureBox2.Location = new Point(301, 184);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 37);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Location = new Point(251, 335);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.RowHeadersWidth = 51;
            dgvLoaiPhong.RowTemplate.Height = 29;
            dgvLoaiPhong.Size = new Size(359, 200);
            dgvLoaiPhong.TabIndex = 8;
            dgvLoaiPhong.CellClick += dgvLoaiPhong_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(251, 283);
            label3.Name = "label3";
            label3.Size = new Size(235, 26);
            label3.TabIndex = 9;
            label3.Text = "Danh Sách Loại Phòng";
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.diskette;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(79, 173);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 59);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.edit1;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(79, 267);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 59);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete1;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(79, 360);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 59);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Image = Properties.Resources.multiply;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(79, 441);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 59);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.TextAlign = ContentAlignment.MiddleRight;
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnMoi
            // 
            btnMoi.Image = Properties.Resources.add2;
            btnMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnMoi.Location = new Point(79, 83);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(94, 59);
            btnMoi.TabIndex = 14;
            btnMoi.Text = "Mới";
            btnMoi.TextAlign = ContentAlignment.MiddleRight;
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // FrmQuanLiLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 553);
            Controls.Add(btnMoi);
            Controls.Add(btnHuy);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(label3);
            Controls.Add(dgvLoaiPhong);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtLoaiPhong);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmQuanLiLoaiPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Loại Phòng";
            Load += FrmQuanLiLoaiPhong_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtLoaiPhong;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvLoaiPhong;
        private Label label3;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnMoi;
    }
}