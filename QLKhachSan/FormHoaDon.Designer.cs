namespace QLKhachSan
{
    partial class FormHoaDon
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel14 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            label1 = new Label();
            menu = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            txtTim = new TextBox();
            btnTim = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 38);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(705, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(96, 36);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.minimize1;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(27, 4);
            button1.Name = "button1";
            button1.Size = new Size(25, 28);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.close2;
            button2.Location = new Point(58, 4);
            button2.Name = "button2";
            button2.Size = new Size(27, 28);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel14.Controls.Add(btnMinimize);
            panel14.Controls.Add(btnMaximize);
            panel14.Controls.Add(btnClose);
            panel14.Location = new Point(1764, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(141, 38);
            panel14.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.minimize1;
            btnMinimize.ImageAlign = ContentAlignment.BottomCenter;
            btnMinimize.Location = new Point(3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 28);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.maximize1;
            btnMaximize.Location = new Point(46, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(37, 28);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.close2;
            btnClose.Location = new Point(89, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 28);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 2;
            label1.Text = "Hóa Đơn";
            // 
            // menu
            // 
            menu.Image = Properties.Resources.bar;
            menu.Location = new Point(4, 2);
            menu.Margin = new Padding(4, 3, 4, 3);
            menu.Name = "menu";
            menu.Size = new Size(50, 33);
            menu.SizeMode = PictureBoxSizeMode.CenterImage;
            menu.TabIndex = 1;
            menu.TabStop = false;
            menu.Click += menu_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(699, 370);
            dataGridView1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(115, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtTim
            // 
            txtTim.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTim.Location = new Point(500, 45);
            txtTim.Multiline = true;
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Tìm khách hàng";
            txtTim.Size = new Size(254, 35);
            txtTim.TabIndex = 4;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.Transparent;
            btnTim.FlatAppearance.BorderSize = 2;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Image = Properties.Resources.search;
            btnTim.Location = new Point(760, 44);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(50, 36);
            btnTim.TabIndex = 5;
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Silver;
            ClientSize = new Size(813, 501);
            Controls.Add(btnTim);
            Controls.Add(txtTim);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            Load += FormHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel14;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Label label1;
        private PictureBox menu;
        private System.Windows.Forms.Timer sidebarTransition;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTim;
        private Button btnTim;
        private Panel panel2;
        private Button button1;
        private Button button2;
    }
}