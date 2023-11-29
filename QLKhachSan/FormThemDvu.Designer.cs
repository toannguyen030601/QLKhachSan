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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            btnPhai = new Button();
            btnTrai = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(42, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 39);
            label1.TabIndex = 0;
            label1.Text = "Danh sách dịch vụ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(67, 150);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(173, 105);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm loại dịch vụ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 45);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 30);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 263);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(419, 293);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(725, 263);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 35;
            dataGridView2.Size = new Size(425, 293);
            dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(725, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 39);
            label2.TabIndex = 4;
            label2.Text = "Dịch vụ đã chọn";
            label2.Click += label2_Click;
            // 
            // btnPhai
            // 
            btnPhai.Location = new Point(533, 294);
            btnPhai.Margin = new Padding(4);
            btnPhai.Name = "btnPhai";
            btnPhai.Size = new Size(117, 43);
            btnPhai.TabIndex = 5;
            btnPhai.Text = ">>";
            btnPhai.UseVisualStyleBackColor = true;
            btnPhai.Click += btnPhai_Click;
            // 
            // btnTrai
            // 
            btnTrai.Location = new Point(533, 414);
            btnTrai.Margin = new Padding(4);
            btnTrai.Name = "btnTrai";
            btnTrai.Size = new Size(117, 43);
            btnTrai.TabIndex = 6;
            btnTrai.Text = "<<";
            btnTrai.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(725, 588);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(143, 43);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(892, 588);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 43);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(555, 586);
            button1.Name = "button1";
            button1.Size = new Size(118, 45);
            button1.TabIndex = 9;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnXoa;
            // 
            // FormThemDvu
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 672);
            Controls.Add(button1);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnTrai);
            Controls.Add(btnPhai);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormThemDvu";
            Text = "FormThemDvu";
            Load += FormThemDvu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Button btnPhai;
        private Button btnTrai;
        private Button btnLuu;
        private Button btnThoat;
        private Button button1;
    }
}