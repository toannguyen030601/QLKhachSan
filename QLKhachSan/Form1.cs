using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //controldrag
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseUp += panel1_MouseUp;
            panel1.MouseMove += panel1_Move;

            //last lick button
            lastClickedButton = btnTrangChu;
            SetFormShape();

        }

        //email dangnhap
        public static string email;
        BUS_qlks.Class1 busnv = new BUS_qlks.Class1();

        //border-radius form
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,        // x-coordinate of upper-left corner
            int nTopRect,         // y-coordinate of upper-left corner
            int nRightRect,       // x-coordinate of lower-right corner
            int nBottomRect,      // y-coordinate of lower-right corner
            int nWidthEllipse,    // width of ellipse
            int nHeightEllipse    // height of ellipse
        );
        private void SetFormShape()
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            }
            else
            {
                this.Region = null;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetFormShape();
        }

        //đóng mở menu
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 250)
                {
                    sidebarTransition.Stop();
                }
            }
        }
        private void menu_Click(object sender, EventArgs e)
        {
            sidebarExpand = !sidebarExpand;
            sidebarTransition.Start();
        }

        // mở form con
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock= DockStyle.Fill;
            childForm.FormBorderStyle= FormBorderStyle.None;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        

        //dragcontrol
        private Point mouseOffset;
        private bool isMouseDown = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void panel1_Move(object sender, EventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }


        //form load
        private void Form1_Load(object sender, EventArgs e)
        {
            //
            OpenChildForm(new FormTrangChu());

            infocuaban();
        }

        // đóng mở form
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Properties.Resources.normalcontrol;
            }
            else
            {
                WindowState= FormWindowState.Normal;
                btnMaximize.Image = Properties.Resources.maximize1;
            }
        }

        // click buttom
        private Button lastClickedButton;
        private void ChangeColor(Button button)
        {
            // Kiểm tra xem có button nào được click trước đó không
            if (lastClickedButton != null)
            {
                // Đặt màu nền của button trước đó về màu mặc định
                lastClickedButton.BackColor = SystemColors.ScrollBar;
            }

            // Đặt màu nền của button mới được click
            button.BackColor = Color.DarkGray;
            // Lưu trữ button mới được click
            lastClickedButton = button;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeColor((Button)sender);
            OpenChildForm(new FormTrangChu());
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ChangeColor((Button)sender);
            OpenChildForm(new NhanVien());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnInfoDangnhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInfoDangnhap_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnInfoDangnhap, "Thông tin của bạn");
        }

        private void btnInfoDangnhap_MouseLeave(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Hide(btnInfoDangnhap);
        }

        public void infocuaban()
        {
            FormThemSuaNhanVien f = new FormThemSuaNhanVien(false);
            string saveDirectory = Application.StartupPath;
            DataTable data = busnv.thongtinnhanvien(email);
            string imagePath = saveDirectory + data.Rows[0][8].ToString();
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                picAvatar.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Nếu không có hình ảnh hoặc đường dẫn không hợp lệ, bạn có thể hiển thị một hình ảnh mặc định hoặc để picHinhanh là null.
                picAvatar.Image = Properties.Resources.hinhanh; // hoặc hiển thị hình mặc định picHinhanh.Image = Properties.Resources.defaultImage;
            }
            lblTen.Text = data.Rows[0][2].ToString();
            string chucvu = data.Rows[0][4].ToString().Trim();

            if (chucvu != "Admin")
            {
                btnNhanVien.Visible = false;
            }
            else
            {
                btnNhanVien.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeColor((Button)sender);
            OpenChildForm(new QLDichvu());
            /*QLDichvu qLDichvu = new QLDichvu();
            qLDichvu.ShowDialog();*/
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ChangeColor((Button)sender);
            OpenChildForm(new QLLoaiDichVu());
            /*QLLoaiDichVu qLLoaiDichVu = new QLLoaiDichVu();
            qLLoaiDichVu.ShowDialog();*/
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}