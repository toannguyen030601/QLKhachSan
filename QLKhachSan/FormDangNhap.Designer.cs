namespace QLKhachSan
{
    partial class FormDangNhap
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
            this.panelDangnhap = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuenmatkhau = new System.Windows.Forms.Label();
            this.chkNhotaikhoan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelDangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDangnhap
            // 
            this.panelDangnhap.BackColor = System.Drawing.Color.LightGray;
            this.panelDangnhap.Controls.Add(this.pictureBox2);
            this.panelDangnhap.Controls.Add(this.pictureBox1);
            this.panelDangnhap.Controls.Add(this.btnDangnhap);
            this.panelDangnhap.Controls.Add(this.label4);
            this.panelDangnhap.Controls.Add(this.lblQuenmatkhau);
            this.panelDangnhap.Controls.Add(this.chkNhotaikhoan);
            this.panelDangnhap.Controls.Add(this.label2);
            this.panelDangnhap.Controls.Add(this.label1);
            this.panelDangnhap.Controls.Add(this.panel3);
            this.panelDangnhap.Controls.Add(this.txtMatkhau);
            this.panelDangnhap.Controls.Add(this.panel2);
            this.panelDangnhap.Controls.Add(this.txtEmail);
            this.panelDangnhap.Location = new System.Drawing.Point(48, 53);
            this.panelDangnhap.Name = "panelDangnhap";
            this.panelDangnhap.Size = new System.Drawing.Size(386, 358);
            this.panelDangnhap.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLKhachSan.Properties.Resources.matkhau;
            this.pictureBox2.Location = new System.Drawing.Point(16, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKhachSan.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDangnhap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDangnhap.FlatAppearance.BorderSize = 0;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangnhap.ForeColor = System.Drawing.Color.White;
            this.btnDangnhap.Location = new System.Drawing.Point(135, 301);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(112, 40);
            this.btnDangnhap.TabIndex = 0;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(118, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đăng Nhập";
            // 
            // lblQuenmatkhau
            // 
            this.lblQuenmatkhau.AutoSize = true;
            this.lblQuenmatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuenmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblQuenmatkhau.Location = new System.Drawing.Point(238, 247);
            this.lblQuenmatkhau.Name = "lblQuenmatkhau";
            this.lblQuenmatkhau.Size = new System.Drawing.Size(134, 22);
            this.lblQuenmatkhau.TabIndex = 14;
            this.lblQuenmatkhau.Text = "Quên mật khẩu?";
            this.lblQuenmatkhau.Click += new System.EventHandler(this.lblQuenmatkhau_Click);
            // 
            // chkNhotaikhoan
            // 
            this.chkNhotaikhoan.AutoSize = true;
            this.chkNhotaikhoan.Location = new System.Drawing.Point(62, 247);
            this.chkNhotaikhoan.Name = "chkNhotaikhoan";
            this.chkNhotaikhoan.Size = new System.Drawing.Size(154, 26);
            this.chkNhotaikhoan.TabIndex = 13;
            this.chkNhotaikhoan.Text = "Nhớ Tài Khoản";
            this.chkNhotaikhoan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(62, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 3);
            this.panel3.TabIndex = 3;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BackColor = System.Drawing.Color.White;
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatkhau.Location = new System.Drawing.Point(62, 198);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(272, 32);
            this.txtMatkhau.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(62, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 3);
            this.panel2.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(62, 117);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 32);
            this.txtEmail.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::QLKhachSan.Properties.Resources.close2;
            this.btnClose.Location = new System.Drawing.Point(58, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.btnMinimize);
            this.panel14.Controls.Add(this.btnClose);
            this.panel14.Location = new System.Drawing.Point(624, 1);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(96, 36);
            this.panel14.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::QLKhachSan.Properties.Resources.minimize1;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(27, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 28);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKhachSan.Properties.Resources.bgdangnhap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 468);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panelDangnhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.panelDangnhap.ResumeLayout(false);
            this.panelDangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDangnhap;
        private TextBox txtEmail;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtMatkhau;
        private Label label2;
        private Label label1;
        private CheckBox chkNhotaikhoan;
        private Label lblQuenmatkhau;
        private Label label4;
        private Button btnDangnhap;
        private Button btnClose;
        private Panel panel14;
        private Button btnMinimize;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}