using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            panelDangnhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDangnhap.Width, panelDangnhap.Height, 20, 20));
            btnDangnhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDangnhap.Width, btnDangnhap.Height, 10, 10));
        }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
