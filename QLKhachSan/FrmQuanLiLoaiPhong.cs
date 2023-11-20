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
    public partial class FrmQuanLiLoaiPhong : Form
    {
        public FrmQuanLiLoaiPhong()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetValues()
        {
            txtID.Text = string.Empty;
            txtLoaiPhong.Text = string.Empty;
            Lock();
        }
        private void Lock()
        {
            txtID.Enabled = false;
            txtLoaiPhong.Enabled = false;
            btnLuu.Enabled = false;
            btnMoi.Enabled = true;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void UnLock()
        {
            txtID.Enabled = true;
            txtLoaiPhong.Enabled = true;
            btnLuu.Enabled = true;
            btnMoi.Enabled = false;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            SetValues();
            UnLock();
            btnXoa.Enabled=false;
            btnSua.Enabled=false;
        }

        private void FrmQuanLiLoaiPhong_Load(object sender, EventArgs e)
        {
            SetValues();
        }
    }
}
