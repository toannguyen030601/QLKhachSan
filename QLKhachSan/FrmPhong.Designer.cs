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
            panel4 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            txtMax = new TextBox();
            txtMin = new TextBox();
            btnLoc = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtTimKiem = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            btnTimKiem = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.InactiveCaption;
            flowLayoutPanel1.Location = new Point(219, 98);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(803, 521);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 501);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoTatCaTrangThai);
            groupBox2.Controls.Add(rdoDaThue);
            groupBox2.Controls.Add(rdoTrong);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(0, 310);
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
            rdoTatCaTrangThai.CheckedChanged += rdoTatCaTrangThai_CheckedChanged;
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
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(txtMax);
            groupBox1.Controls.Add(txtMin);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc Theo Giá";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(12, 213);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 3);
            panel4.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(107, 180);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 11;
            label7.Text = "K VND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(107, 95);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 10;
            label6.Text = "K VND";
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(12, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 3);
            panel3.TabIndex = 8;
            // 
            // txtMax
            // 
            txtMax.BackColor = SystemColors.Control;
            txtMax.BorderStyle = BorderStyle.None;
            txtMax.Location = new Point(12, 180);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(120, 27);
            txtMax.TabIndex = 4;
            txtMax.Text = "Max";
            txtMax.Enter += txtMax_Enter;
            txtMax.Leave += txtMax_Leave;
            // 
            // txtMin
            // 
            txtMin.BackColor = SystemColors.Control;
            txtMin.BorderStyle = BorderStyle.None;
            txtMin.Location = new Point(12, 95);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(122, 27);
            txtMin.TabIndex = 3;
            txtMin.Text = "0";
            txtMin.Enter += txtMin_Enter;
            txtMin.Leave += txtMin_Leave;
            // 
            // btnLoc
            // 
            btnLoc.Image = Properties.Resources.filter_filled_tool_symbol;
            btnLoc.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoc.Location = new Point(58, 228);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 46);
            btnLoc.TabIndex = 2;
            btnLoc.Text = "Lọc";
            btnLoc.TextAlign = ContentAlignment.MiddleRight;
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(41, 141);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 1;
            label4.Text = "Đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(32, 67);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 0;
            label3.Text = "Giá từ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(708, 51);
            label1.Name = "label1";
            label1.Size = new Size(85, 26);
            label1.TabIndex = 2;
            label1.Text = "Đã thuê";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(885, 51);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 3;
            label2.Text = "Trống";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tomato;
            pictureBox1.Location = new Point(660, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SpringGreen;
            pictureBox2.Location = new Point(846, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 35);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(388, 43);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(174, 34);
            txtTimKiem.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(388, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 3);
            panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.search1;
            pictureBox3.Location = new Point(347, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 34);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Transparent;
            btnTimKiem.Image = Properties.Resources.send_message__1_;
            btnTimKiem.Location = new Point(568, 38);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(50, 43);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(393, 14);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(0, 34);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 9);
            label5.Name = "label5";
            label5.Size = new Size(116, 26);
            label5.TabIndex = 12;
            label5.Text = "Tìm Phòng";
            // 
            // FrmPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 611);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(btnTimKiem);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(txtTimKiem);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sơ đồ Phòng";
            Load += FrmPhong_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtTimKiem;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btnTimKiem;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private TextBox txtMax;
        private TextBox txtMin;
        private Button btnLoc;
        private TextBox textBox3;
        private Label label5;
        private Label label7;
        private Label label6;
        private Panel panel4;
    }
}