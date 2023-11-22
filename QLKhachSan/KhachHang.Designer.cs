namespace QLKhachSan
{
    partial class KhachHang
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
            btnTim = new Button();
            txtTim = new TextBox();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.Transparent;
            btnTim.FlatAppearance.BorderSize = 2;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Image = Properties.Resources.search;
            btnTim.Location = new Point(484, 20);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(50, 36);
            btnTim.TabIndex = 9;
            btnTim.UseVisualStyleBackColor = false;
            // 
            // txtTim
            // 
            txtTim.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTim.Location = new Point(98, 20);
            txtTim.Multiline = true;
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(436, 35);
            txtTim.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(968, 458);
            dataGridView1.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Image = Properties.Resources.add1;
            btnThem.Location = new Point(892, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 47);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 560);
            Controls.Add(btnThem);
            Controls.Add(btnTim);
            Controls.Add(txtTim);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KhachHang";
            Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTim;
        private TextBox txtTim;
        private DataGridView dataGridView1;
        private Button btnThem;
    }
}