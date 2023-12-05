namespace QLKhachSan
{
    partial class QLDichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLDichvu));
            dataGridView1 = new DataGridView();
            btnTimDichVu = new Button();
            txtTimDichVu = new TextBox();
            /*label1 = new Label();*/
           /* progressBar1 = new ProgressBar();*/
            panel1 = new Panel();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // 

            // 
            // 

            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(980, 500);
            dataGridView1.TabIndex = 29;
            // 
            // btnTimDichVu
            // 
            btnTimDichVu.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimDichVu.Image = (Image)resources.GetObject("btnTimDichVu.Image");
            btnTimDichVu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimDichVu.Location = new Point(375, 26);
            btnTimDichVu.Name = "btnTimDichVu";
            btnTimDichVu.Size = new Size(96, 47);
            btnTimDichVu.TabIndex = 28;
            btnTimDichVu.Text = "Tìm";
            btnTimDichVu.TextAlign = ContentAlignment.MiddleRight;
            btnTimDichVu.UseVisualStyleBackColor = true;
            btnTimDichVu.Click += btnTimDichVu_Click;
            // 
            // txtTimDichVu
            // 
            txtTimDichVu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimDichVu.Location = new Point(62, 36);
            txtTimDichVu.Name = "txtTimDichVu";
            txtTimDichVu.Size = new Size(304, 30);
            txtTimDichVu.TabIndex = 27;
            txtTimDichVu.Text = "Nhập dịch vụ cần tìm";
            // 
            /*// label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 8);
            label1.Name = "label1";
            label1.Size = new Size(163, 34);
            label1.TabIndex = 26;
            label1.Text = "QL Dịch Vụ";*/
            // 
            /*// progressBar1
            // 
            progressBar1.Location = new Point(-7, -3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1079, 54);
            progressBar1.TabIndex = 25;*/
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Location = new Point(529, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 61);
            panel1.TabIndex = 42;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSalmon;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.Location = new Point(317, 10);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 47);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.add1;
            btnThem.Location = new Point(17, 10);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 47);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Pink;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = Properties.Resources.edit;
            btnSua.Location = new Point(167, 10);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 47);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // QLDichvu
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1062, 653);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnTimDichVu);
            Controls.Add(txtTimDichVu);
            /*Controls.Add(label1);*/
           /* Controls.Add(progressBar1);*/
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QLDichvu";
            Text = "QLDichvu";
            Load += QLDichvu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnTimDichVu;
        private TextBox txtTimDichVu;
        /*private Label label1;*/
        /*private ProgressBar progressBar1;*/
        private Panel panel1;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
    }
}