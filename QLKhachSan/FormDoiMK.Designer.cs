namespace QLKhachSan
{
    partial class FormDoiMK
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
            label1 = new Label();
            txtEmail = new TextBox();
            txtMkCu = new TextBox();
            txtMkMoi = new TextBox();
            txtMkMoi2 = new TextBox();
            btnDoiMK = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panelDMK = new Panel();
            panel14 = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelDMK.SuspendLayout();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(125, 30);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 1;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(68, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(300, 32);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "Email nhân viên";
            // 
            // txtMkCu
            // 
            txtMkCu.BackColor = SystemColors.Control;
            txtMkCu.BorderStyle = BorderStyle.None;
            txtMkCu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMkCu.Location = new Point(68, 162);
            txtMkCu.Name = "txtMkCu";
            txtMkCu.PasswordChar = '*';
            txtMkCu.Size = new Size(300, 32);
            txtMkCu.TabIndex = 7;
            txtMkCu.Enter += txtMkCu_Enter;
            txtMkCu.Leave += txtMkCu_Leave;
            // 
            // txtMkMoi
            // 
            txtMkMoi.BackColor = SystemColors.Control;
            txtMkMoi.BorderStyle = BorderStyle.None;
            txtMkMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMkMoi.Location = new Point(68, 246);
            txtMkMoi.Name = "txtMkMoi";
            txtMkMoi.PasswordChar = '*';
            txtMkMoi.Size = new Size(300, 32);
            txtMkMoi.TabIndex = 8;
            txtMkMoi.TextChanged += textBox3_TextChanged;
            txtMkMoi.Enter += txtMkMoi_Enter;
            txtMkMoi.Leave += txtMkMoi_Leave;
            txtMkMoi.Validating += txtMkMoi_Validating;
            // 
            // txtMkMoi2
            // 
            txtMkMoi2.BackColor = SystemColors.Control;
            txtMkMoi2.BorderStyle = BorderStyle.None;
            txtMkMoi2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMkMoi2.Location = new Point(68, 316);
            txtMkMoi2.Name = "txtMkMoi2";
            txtMkMoi2.PasswordChar = '*';
            txtMkMoi2.Size = new Size(300, 32);
            txtMkMoi2.TabIndex = 9;
            txtMkMoi2.Enter += txtMkMoi2_Enter;
            txtMkMoi2.Leave += txtMkMoi2_Leave;
            // 
            // btnDoiMK
            // 
            btnDoiMK.BackColor = SystemColors.Highlight;
            btnDoiMK.FlatAppearance.BorderSize = 0;
            btnDoiMK.FlatStyle = FlatStyle.Flat;
            btnDoiMK.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoiMK.ForeColor = Color.SeaShell;
            btnDoiMK.Location = new Point(113, 379);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(178, 54);
            btnDoiMK.TabIndex = 10;
            btnDoiMK.Text = "Đổi Mật Khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.SeaShell;
            button2.Location = new Point(113, 439);
            button2.Name = "button2";
            button2.Size = new Size(178, 45);
            button2.TabIndex = 11;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(68, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 3);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(68, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 3);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(68, 284);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 3);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(68, 354);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 3);
            panel4.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user1;
            pictureBox5.Location = new Point(18, 98);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 33);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.user1;
            pictureBox6.Location = new Point(18, 168);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 33);
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user1;
            pictureBox2.Location = new Point(18, 252);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user1;
            pictureBox3.Location = new Point(18, 322);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 33);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // panelDMK
            // 
            panelDMK.BackColor = Color.LightGray;
            panelDMK.Controls.Add(pictureBox3);
            panelDMK.Controls.Add(label1);
            panelDMK.Controls.Add(pictureBox2);
            panelDMK.Controls.Add(txtEmail);
            panelDMK.Controls.Add(pictureBox6);
            panelDMK.Controls.Add(txtMkCu);
            panelDMK.Controls.Add(pictureBox5);
            panelDMK.Controls.Add(txtMkMoi);
            panelDMK.Controls.Add(panel4);
            panelDMK.Controls.Add(txtMkMoi2);
            panelDMK.Controls.Add(panel3);
            panelDMK.Controls.Add(btnDoiMK);
            panelDMK.Controls.Add(panel2);
            panelDMK.Controls.Add(button2);
            panelDMK.Controls.Add(panel1);
            panelDMK.Location = new Point(93, 54);
            panelDMK.Name = "panelDMK";
            panelDMK.Size = new Size(407, 511);
            panelDMK.TabIndex = 21;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel14.BackColor = Color.Transparent;
            panel14.Controls.Add(btnMinimize);
            panel14.Controls.Add(btnClose);
            panel14.Location = new Point(654, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(96, 36);
            panel14.TabIndex = 22;
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
            // FormDoiMK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgdangnhap;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(751, 612);
            Controls.Add(panel14);
            Controls.Add(panelDMK);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoiMK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDoiMK";
            Load += FormDoiMK_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelDMK.ResumeLayout(false);
            panelDMK.PerformLayout();
            panel14.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtMkCu;
        private TextBox txtMkMoi;
        private TextBox txtMkMoi2;
        private Button btnDoiMK;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panelDMK;
        private Panel panel14;
        private Button btnMinimize;
        private Button btnClose;
    }
}