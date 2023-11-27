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
            panelDangnhap = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnDangnhap = new Button();
            label4 = new Label();
            lblQuenmatkhau = new Label();
            chkNhotaikhoan = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            txtMatkhau = new TextBox();
            panel2 = new Panel();
            txtEmail = new TextBox();
            btnClose = new Button();
            panel14 = new Panel();
            btnMinimize = new Button();
            panelDangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // panelDangnhap
            // 
            panelDangnhap.BackColor = Color.LightGray;
            panelDangnhap.Controls.Add(pictureBox2);
            panelDangnhap.Controls.Add(pictureBox1);
            panelDangnhap.Controls.Add(btnDangnhap);
            panelDangnhap.Controls.Add(label4);
            panelDangnhap.Controls.Add(lblQuenmatkhau);
            panelDangnhap.Controls.Add(chkNhotaikhoan);
            panelDangnhap.Controls.Add(label2);
            panelDangnhap.Controls.Add(label1);
            panelDangnhap.Controls.Add(panel3);
            panelDangnhap.Controls.Add(txtMatkhau);
            panelDangnhap.Controls.Add(panel2);
            panelDangnhap.Controls.Add(txtEmail);
            panelDangnhap.Location = new Point(48, 53);
            panelDangnhap.Name = "panelDangnhap";
            panelDangnhap.Size = new Size(386, 358);
            panelDangnhap.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.matkhau;
            pictureBox2.Location = new Point(16, 184);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(16, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = SystemColors.Highlight;
            btnDangnhap.FlatAppearance.BorderColor = Color.Black;
            btnDangnhap.FlatAppearance.BorderSize = 0;
            btnDangnhap.FlatStyle = FlatStyle.Flat;
            btnDangnhap.ForeColor = Color.White;
            btnDangnhap.Location = new Point(135, 301);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(112, 40);
            btnDangnhap.TabIndex = 0;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(118, 29);
            label4.Name = "label4";
            label4.Size = new Size(159, 35);
            label4.TabIndex = 8;
            label4.Text = "Đăng Nhập";
            // 
            // lblQuenmatkhau
            // 
            lblQuenmatkhau.AutoSize = true;
            lblQuenmatkhau.Cursor = Cursors.Hand;
            lblQuenmatkhau.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblQuenmatkhau.Location = new Point(238, 247);
            lblQuenmatkhau.Name = "lblQuenmatkhau";
            lblQuenmatkhau.Size = new Size(134, 22);
            lblQuenmatkhau.TabIndex = 14;
            lblQuenmatkhau.Text = "Quên mật khẩu?";
            lblQuenmatkhau.Click += lblQuenmatkhau_Click;
            // 
            // chkNhotaikhoan
            // 
            chkNhotaikhoan.AutoSize = true;
            chkNhotaikhoan.Location = new Point(62, 247);
            chkNhotaikhoan.Name = "chkNhotaikhoan";
            chkNhotaikhoan.Size = new Size(154, 26);
            chkNhotaikhoan.TabIndex = 13;
            chkNhotaikhoan.Text = "Nhớ Tài Khoản";
            chkNhotaikhoan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 173);
            label2.Name = "label2";
            label2.Size = new Size(93, 22);
            label2.TabIndex = 5;
            label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 92);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(62, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 3);
            panel3.TabIndex = 3;
            // 
            // txtMatkhau
            // 
            txtMatkhau.BackColor = Color.White;
            txtMatkhau.BorderStyle = BorderStyle.None;
            txtMatkhau.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhau.Location = new Point(62, 198);
            txtMatkhau.Multiline = true;
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(272, 32);
            txtMatkhau.TabIndex = 2;
            txtMatkhau.Text = "1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(62, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 3);
            panel2.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(62, 117);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(272, 32);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "toannguyen0257@gmail.com";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.close2;
            btnClose.Location = new Point(58, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 28);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel14.BackColor = Color.Transparent;
            panel14.Controls.Add(btnMinimize);
            panel14.Controls.Add(btnClose);
            panel14.Location = new Point(624, 1);
            panel14.Name = "panel14";
            panel14.Size = new Size(96, 36);
            panel14.TabIndex = 1;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Gainsboro;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.minimize1;
            btnMinimize.ImageAlign = ContentAlignment.BottomCenter;
            btnMinimize.Location = new Point(27, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 28);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgdangnhap;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(721, 468);
            Controls.Add(panel14);
            Controls.Add(panelDangnhap);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            panelDangnhap.ResumeLayout(false);
            panelDangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel14.ResumeLayout(false);
            ResumeLayout(false);
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