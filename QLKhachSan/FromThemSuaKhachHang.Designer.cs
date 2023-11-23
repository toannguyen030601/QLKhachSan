namespace QLKhachSan
{
    partial class FromThemSuaKhachHang
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtSoDT = new TextBox();
            txtHoten = new TextBox();
            btnThemSuaNV = new Button();
            panel3 = new Panel();
            label1 = new Label();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            txtCCCD = new TextBox();
            label4 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(111, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 3);
            panel1.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 205);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 33;
            label3.Text = "Số ĐT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 115);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 32;
            label2.Text = "Họ tên:";
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(111, 197);
            txtSoDT.Margin = new Padding(4, 3, 4, 3);
            txtSoDT.Multiline = true;
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(347, 30);
            txtSoDT.TabIndex = 30;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(111, 107);
            txtHoten.Margin = new Padding(4, 3, 4, 3);
            txtHoten.Multiline = true;
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(347, 30);
            txtHoten.TabIndex = 29;
            // 
            // btnThemSuaNV
            // 
            btnThemSuaNV.BackColor = Color.LimeGreen;
            btnThemSuaNV.FlatAppearance.BorderSize = 0;
            btnThemSuaNV.FlatStyle = FlatStyle.Flat;
            btnThemSuaNV.Location = new Point(169, 329);
            btnThemSuaNV.Margin = new Padding(4, 3, 4, 3);
            btnThemSuaNV.Name = "btnThemSuaNV";
            btnThemSuaNV.Size = new Size(176, 46);
            btnThemSuaNV.TabIndex = 36;
            btnThemSuaNV.Text = "Lưu";
            btnThemSuaNV.UseVisualStyleBackColor = false;
            btnThemSuaNV.Click += btnThemSuaNV_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(rdbNu);
            panel3.Controls.Add(rdbNam);
            panel3.Controls.Add(txtCCCD);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtHoten);
            panel3.Controls.Add(btnThemSuaNV);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(txtSoDT);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(-5, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(503, 493);
            panel3.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 158);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 41;
            label1.Text = "Giới tính:";
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(239, 154);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(56, 26);
            rdbNu.TabIndex = 40;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(136, 154);
            rdbNam.Margin = new Padding(4, 3, 4, 3);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(68, 26);
            rdbNam.TabIndex = 39;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(111, 233);
            txtCCCD.Margin = new Padding(4, 3, 4, 3);
            txtCCCD.Multiline = true;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(347, 30);
            txtCCCD.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 241);
            label4.Name = "label4";
            label4.Size = new Size(95, 22);
            label4.TabIndex = 38;
            label4.Text = "Số CCCD:";
            // 
            // FromThemSuaKhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 495);
            Controls.Add(panel3);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FromThemSuaKhachHang";
            Text = "FromThemSuaKhachHang";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txtSoDT;
        private TextBox txtHoten;
        private Button btnThemSuaNV;
        private Panel panel3;
        private TextBox txtCCCD;
        private Label label4;
        private Label label1;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
    }
}