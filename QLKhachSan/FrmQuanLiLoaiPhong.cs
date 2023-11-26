using BUS_qlks;
using DTO_qlks;
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
        BUS_LoaiPhong bUS_LoaiPhong = new BUS_LoaiPhong();
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
            dgvLoaiPhong.DataSource = bUS_LoaiPhong.DanhSachLoaiPhong();
            dgvLoaiPhong.Columns[0].HeaderText = "Mã Loại Phòng";
            dgvLoaiPhong.Columns[1].HeaderText = "Tên Loại Phòng";
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
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void FrmQuanLiLoaiPhong_Load(object sender, EventArgs e)
        {
            SetValues();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetValues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng điền Mã Loại Phòng");
            }
            else
            {
                if (string.IsNullOrEmpty(txtLoaiPhong.Text))
                {
                    MessageBox.Show("Vui lòng điền Tên Loại Phòng");
                }
                else
                {
                    DTO_LoaiPhong lp = new DTO_LoaiPhong(txtID.Text, txtLoaiPhong.Text);
                    bUS_LoaiPhong.LuuLoaiPhong(lp);
                    MessageBox.Show("Lưu thành công");
                    SetValues();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLock();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtID.Text = dgvLoaiPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtLoaiPhong.Text = dgvLoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                bUS_LoaiPhong.XoaLoaiPhong(txtID.Text);
                MessageBox.Show("Xóa thành công");
                SetValues();
            }

        }

        private void btnSoDo_Click(object sender, EventArgs e)
        {
            FrmPhong frm = new FrmPhong();
            frm.ShowDialog();
            this.Close();
        }
    }
}
