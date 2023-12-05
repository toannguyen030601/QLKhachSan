namespace QLKhachSan
{
    partial class QLLoaiDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLoaiDichVu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTimLoaiDichVu = new System.Windows.Forms.Button();
            this.txtTimLoaiDichVu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(968, 519);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnTimLoaiDichVu
            // 
            this.btnTimLoaiDichVu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimLoaiDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btnTimLoaiDichVu.Image")));
            this.btnTimLoaiDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimLoaiDichVu.Location = new System.Drawing.Point(371, 20);
            this.btnTimLoaiDichVu.Name = "btnTimLoaiDichVu";
            this.btnTimLoaiDichVu.Size = new System.Drawing.Size(96, 47);
            this.btnTimLoaiDichVu.TabIndex = 36;
            this.btnTimLoaiDichVu.Text = "Tìm";
            this.btnTimLoaiDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimLoaiDichVu.UseVisualStyleBackColor = true;
            this.btnTimLoaiDichVu.Click += new System.EventHandler(this.btnTimLoaiDichVu_Click);
            // 
            // txtTimLoaiDichVu
            // 
            this.txtTimLoaiDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimLoaiDichVu.Location = new System.Drawing.Point(49, 32);
            this.txtTimLoaiDichVu.Name = "txtTimLoaiDichVu";
            this.txtTimLoaiDichVu.Size = new System.Drawing.Size(304, 30);
            this.txtTimLoaiDichVu.TabIndex = 35;
            this.txtTimLoaiDichVu.Text = "Nhập tên loại dịch vụ cần tìm";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Location = new System.Drawing.Point(543, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 61);
            this.panel1.TabIndex = 41;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QLKhachSan.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(317, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 47);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QLKhachSan.Properties.Resources.add1;
            this.btnThem.Location = new System.Drawing.Point(17, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 47);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Pink;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = global::QLKhachSan.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(167, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 47);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // QLLoaiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimLoaiDichVu);
            this.Controls.Add(this.txtTimLoaiDichVu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QLLoaiDichVu";
            this.Text = "QLLoaiDichVu";
            this.Load += new System.EventHandler(this.QLLoaiDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Button btnTimLoaiDichVu;
        private TextBox txtTimLoaiDichVu;
        private Panel panel1;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
    }
}