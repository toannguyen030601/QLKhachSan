namespace QLKhachSan
{
    partial class FrmPhong
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            rdoTatCaTrangThai = new RadioButton();
            rdoDaThue = new RadioButton();
            rdoTrong = new RadioButton();
            groupBox1 = new GroupBox();
            rdoTatCa = new RadioButton();
            rdoGiaDinh = new RadioButton();
            rdoDoi = new RadioButton();
            rdoDon = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.InactiveCaption;
            flowLayoutPanel1.Location = new Point(222, 98);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(869, 475);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 475);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoTatCaTrangThai);
            groupBox2.Controls.Add(rdoDaThue);
            groupBox2.Controls.Add(rdoTrong);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(0, 269);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 191);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trạng Thái";
            // 
            // rdoTatCaTrangThai
            // 
            rdoTatCaTrangThai.AutoSize = true;
            rdoTatCaTrangThai.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoTatCaTrangThai.ForeColor = SystemColors.ControlText;
            rdoTatCaTrangThai.Location = new Point(32, 155);
            rdoTatCaTrangThai.Name = "rdoTatCaTrangThai";
            rdoTatCaTrangThai.Size = new Size(95, 30);
            rdoTatCaTrangThai.TabIndex = 5;
            rdoTatCaTrangThai.TabStop = true;
            rdoTatCaTrangThai.Text = "Tất cả ";
            rdoTatCaTrangThai.UseVisualStyleBackColor = true;
            // 
            // rdoDaThue
            // 
            rdoDaThue.AutoSize = true;
            rdoDaThue.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoDaThue.ForeColor = SystemColors.ControlText;
            rdoDaThue.Location = new Point(32, 100);
            rdoDaThue.Name = "rdoDaThue";
            rdoDaThue.Size = new Size(180, 30);
            rdoDaThue.TabIndex = 4;
            rdoDaThue.TabStop = true;
            rdoDaThue.Text = "Phòng Đã Thuê";
            rdoDaThue.UseVisualStyleBackColor = true;
            rdoDaThue.CheckedChanged += rdoDaThue_CheckedChanged;
            // 
            // rdoTrong
            // 
            rdoTrong.AutoSize = true;
            rdoTrong.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoTrong.ForeColor = SystemColors.ControlText;
            rdoTrong.Location = new Point(32, 42);
            rdoTrong.Name = "rdoTrong";
            rdoTrong.Size = new Size(155, 30);
            rdoTrong.TabIndex = 3;
            rdoTrong.TabStop = true;
            rdoTrong.Text = "Phòng Trống";
            rdoTrong.UseVisualStyleBackColor = true;
            rdoTrong.CheckedChanged += rdoTrong_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoTatCa);
            groupBox1.Controls.Add(rdoGiaDinh);
            groupBox1.Controls.Add(rdoDoi);
            groupBox1.Controls.Add(rdoDon);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 249);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại Phòng";
            // 
            // rdoTatCa
            // 
            rdoTatCa.AutoSize = true;
            rdoTatCa.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoTatCa.ForeColor = SystemColors.ControlText;
            rdoTatCa.Location = new Point(32, 213);
            rdoTatCa.Name = "rdoTatCa";
            rdoTatCa.Size = new Size(155, 30);
            rdoTatCa.TabIndex = 3;
            rdoTatCa.TabStop = true;
            rdoTatCa.Text = "Tất cả Phòng";
            rdoTatCa.UseVisualStyleBackColor = true;
            // 
            // rdoGiaDinh
            // 
            rdoGiaDinh.AutoSize = true;
            rdoGiaDinh.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoGiaDinh.ForeColor = SystemColors.ControlText;
            rdoGiaDinh.Location = new Point(32, 156);
            rdoGiaDinh.Name = "rdoGiaDinh";
            rdoGiaDinh.Size = new Size(184, 30);
            rdoGiaDinh.TabIndex = 2;
            rdoGiaDinh.TabStop = true;
            rdoGiaDinh.Text = "Phòng Gia Đình";
            rdoGiaDinh.UseVisualStyleBackColor = true;
            // 
            // rdoDoi
            // 
            rdoDoi.AutoSize = true;
            rdoDoi.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoDoi.ForeColor = SystemColors.ControlText;
            rdoDoi.Location = new Point(32, 92);
            rdoDoi.Name = "rdoDoi";
            rdoDoi.Size = new Size(134, 30);
            rdoDoi.TabIndex = 1;
            rdoDoi.TabStop = true;
            rdoDoi.Text = "Phòng Đôi";
            rdoDoi.UseVisualStyleBackColor = true;
            // 
            // rdoDon
            // 
            rdoDon.AutoSize = true;
            rdoDon.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoDon.ForeColor = SystemColors.ControlText;
            rdoDon.Location = new Point(32, 33);
            rdoDon.Name = "rdoDon";
            rdoDon.Size = new Size(140, 30);
            rdoDon.TabIndex = 0;
            rdoDon.TabStop = true;
            rdoDon.Text = "Phòng Đơn";
            rdoDon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(800, 52);
            label1.Name = "label1";
            label1.Size = new Size(85, 26);
            label1.TabIndex = 2;
            label1.Text = "Đã thuê";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(977, 52);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 3;
            label2.Text = "Trống";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tomato;
            pictureBox1.Location = new Point(752, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SpringGreen;
            pictureBox2.Location = new Point(938, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 35);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FrmPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 570);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmPhong";
            Text = "Quản lí Phòng";
            Load += FrmPhong_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox2;
        private RadioButton rdoTatCaTrangThai;
        private RadioButton rdoDaThue;
        private RadioButton rdoTrong;
        private GroupBox groupBox1;
        private RadioButton rdoTatCa;
        private RadioButton rdoGiaDinh;
        private RadioButton rdoDoi;
        private RadioButton rdoDon;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}