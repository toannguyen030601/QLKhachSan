namespace QLKhachSan
{
    partial class NhanVien
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
            dataGridView1 = new DataGridView();
            txtTim = new TextBox();
            btnTim = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(968, 509);
            dataGridView1.TabIndex = 0;
            // 
            // txtTim
            // 
            txtTim.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTim.Location = new Point(62, 36);
            txtTim.Multiline = true;
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(436, 35);
            txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.Transparent;
            btnTim.FlatAppearance.BorderSize = 2;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Image = Properties.Resources.search;
            btnTim.Location = new Point(448, 36);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(50, 36);
            btnTim.TabIndex = 2;
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
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
            btnThem.MouseDown += btnThem_MouseDown;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Location = new Point(529, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 61);
            panel1.TabIndex = 6;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1024, 614);
            Controls.Add(panel1);
            Controls.Add(btnTim);
            Controls.Add(txtTim);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            Load += NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtTim;
        private Button btnTim;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Panel panel1;
    }
}