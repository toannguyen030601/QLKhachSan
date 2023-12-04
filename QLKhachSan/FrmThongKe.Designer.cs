namespace QLKhachSan
{
    partial class FrmThongKe
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
            menuStrip1 = new MenuStrip();
            doanhThuPhòngToolStripMenuItem = new ToolStripMenuItem();
            doanhThuDịchVụToolStripMenuItem = new ToolStripMenuItem();
            dgvDoanhThu = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnLoc = new Button();
            label3 = new Label();
            lblDoanhThu = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { doanhThuPhòngToolStripMenuItem, doanhThuDịchVụToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1210, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // doanhThuPhòngToolStripMenuItem
            // 
            doanhThuPhòngToolStripMenuItem.Name = "doanhThuPhòngToolStripMenuItem";
            doanhThuPhòngToolStripMenuItem.Size = new Size(173, 27);
            doanhThuPhòngToolStripMenuItem.Text = "Doanh Thu Phòng";
            doanhThuPhòngToolStripMenuItem.Click += doanhThuPhòngToolStripMenuItem_Click;
            // 
            // doanhThuDịchVụToolStripMenuItem
            // 
            doanhThuDịchVụToolStripMenuItem.Name = "doanhThuDịchVụToolStripMenuItem";
            doanhThuDịchVụToolStripMenuItem.Size = new Size(188, 27);
            doanhThuDịchVụToolStripMenuItem.Text = "Doanh Thu Dịch Vụ";
            doanhThuDịchVụToolStripMenuItem.Click += doanhThuDịchVụToolStripMenuItem_Click;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(75, 244);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.RowTemplate.Height = 29;
            dgvDoanhThu.Size = new Size(1073, 415);
            dgvDoanhThu.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(246, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(669, 121);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 34);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 68);
            label1.Name = "label1";
            label1.Size = new Size(82, 26);
            label1.TabIndex = 4;
            label1.Text = "Bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(669, 68);
            label2.Name = "label2";
            label2.Size = new Size(90, 26);
            label2.TabIndex = 5;
            label2.Text = "Kết thúc";
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(1022, 111);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 45);
            btnLoc.TabIndex = 6;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 190);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 7;
            label3.Text = "Doanh Thu";
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoanhThu.ForeColor = Color.OrangeRed;
            lblDoanhThu.Location = new Point(551, 177);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(168, 39);
            lblDoanhThu.TabIndex = 8;
            lblDoanhThu.Text = "Doanh Thu";
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 726);
            Controls.Add(lblDoanhThu);
            Controls.Add(label3);
            Controls.Add(btnLoc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvDoanhThu);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            Load += FrmThongKe_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem doanhThuPhòngToolStripMenuItem;
        private ToolStripMenuItem doanhThuDịchVụToolStripMenuItem;
        private DataGridView dgvDoanhThu;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Button btnLoc;
        private Label label3;
        private Label lblDoanhThu;
    }
}