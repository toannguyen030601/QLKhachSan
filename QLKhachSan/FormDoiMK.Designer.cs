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
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.turn_off;
            pictureBox1.Location = new Point(223, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 72);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(184, 102);
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
            txtEmail.Location = new Point(62, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 32);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "Email nhân viên";
            txtEmail.Enter += textBox1_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtMkCu
            // 
            txtMkCu.BackColor = SystemColors.Control;
            txtMkCu.BorderStyle = BorderStyle.None;
            txtMkCu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMkCu.Location = new Point(62, 240);
            txtMkCu.Name = "txtMkCu";
            txtMkCu.Size = new Size(300, 32);
            txtMkCu.TabIndex = 7;
            txtMkCu.Text = "Mật khẩu cũ";
            txtMkCu.Enter += txtMkCu_Enter;
            txtMkCu.Leave += txtMkCu_Leave;
            // 
            // txtMkMoi
            // 
            txtMkMoi.BackColor = SystemColors.Control;
            txtMkMoi.BorderStyle = BorderStyle.None;
            txtMkMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMkMoi.Location = new Point(62, 324);
            txtMkMoi.Name = "txtMkMoi";
            txtMkMoi.Size = new Size(300, 32);
            txtMkMoi.TabIndex = 8;
            txtMkMoi.Text = "Mật khẩu mới";
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
            txtMkMoi2.Location = new Point(62, 394);
            txtMkMoi2.Name = "txtMkMoi2";
            txtMkMoi2.Size = new Size(300, 32);
            txtMkMoi2.TabIndex = 9;
            txtMkMoi2.Text = "Nhập lại mật khẩu";
            txtMkMoi2.Enter += txtMkMoi2_Enter;
            txtMkMoi2.Leave += txtMkMoi2_Leave;
            // 
            // btnDoiMK
            // 
            btnDoiMK.BackColor = Color.DarkOrange;
            btnDoiMK.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoiMK.ForeColor = SystemColors.ControlText;
            btnDoiMK.Location = new Point(184, 457);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(178, 54);
            btnDoiMK.TabIndex = 10;
            btnDoiMK.Text = "Đổi Mật Khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(184, 517);
            button2.Name = "button2";
            button2.Size = new Size(178, 45);
            button2.TabIndex = 11;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(62, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 3);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(62, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 3);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(62, 362);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 3);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(62, 432);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 3);
            panel4.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user1;
            pictureBox5.Location = new Point(15, 178);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 33);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.user1;
            pictureBox6.Location = new Point(15, 248);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 33);
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user1;
            pictureBox2.Location = new Point(15, 332);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user1;
            pictureBox3.Location = new Point(15, 402);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 33);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // FormDoiMK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 574);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(btnDoiMK);
            Controls.Add(txtMkMoi2);
            Controls.Add(txtMkMoi);
            Controls.Add(txtMkCu);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormDoiMK";
            Text = "FormDoiMK";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
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
    }
}