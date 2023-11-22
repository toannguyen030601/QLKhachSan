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
    public partial class FrmQuanLiDSPhong : Form
    {
        BUS_Phong bus_Phong = new BUS_Phong();
        public FrmQuanLiDSPhong()
        {
            InitializeComponent();
        }
        private void SetValues()
        {
            txtMaPhong.Text = string.Empty;
            txtTenPhong.Text = string.Empty;
            txtGia.Text = string.Empty;
            rdoDaThue.Checked = false;
            rdoTrong.Checked = true;
            Lock();
            dgvDSPhong.DataSource = bus_Phong.DanhSachPhong();
            dgvDSPhong.Columns[0].HeaderText = "Mã Phòng";
            dgvDSPhong.Columns[1].HeaderText = "Tên Phòng";
            dgvDSPhong.Columns[2].HeaderText = "Giá";
            dgvDSPhong.Columns[3].HeaderText = "Trạng Thái";
            dgvDSPhong.Columns[4].HeaderText = "Mã Loại Phòng";
            DataTable dataTable = new DataTable();
            dataTable = bus_Phong.DanhSachPhong();

            // Assuming "Mã Loại Phòng" is the column name in the DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                string maLoaiPhong = row[4].ToString();

                // Check if the value is not already in the ComboBox
                if (!cbMaLoaiPhong.Items.Contains(maLoaiPhong))
                {
                    cbMaLoaiPhong.Items.Add(maLoaiPhong);
                }
            }
            cbMaLoaiPhong.SelectedIndex = -1;
        }
        private void Lock()
        {
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtGia.Enabled = false;
            rdoDaThue.Enabled = false;
            rdoTrong.Enabled = false;
            cbMaLoaiPhong.Enabled = false;
            btnLuu.Enabled = false;
            btnMoi.Enabled = true;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void UnLock()
        {
            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtGia.Enabled = true;
            rdoDaThue.Enabled = true;
            rdoTrong.Enabled = true;
            cbMaLoaiPhong.Enabled = true;
            btnLuu.Enabled = true;
            btnMoi.Enabled = false;
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void FrmQuanLiDSPhong_Load(object sender, EventArgs e)
        {
            SetValues();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn xóa", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                bus_Phong.XoaPhong(txtMaPhong.Text);
                SetValues();
            }
            SetValues();
        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1&&e.RowIndex < dgvDSPhong.Rows.Count-1)
            {
                txtMaPhong.Text = dgvDSPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenPhong.Text = dgvDSPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGia.Text = dgvDSPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                bool TrangThai = Convert.ToBoolean(dgvDSPhong.Rows[e.RowIndex].Cells[3].Value);
                string maLoaiPhong = dgvDSPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbMaLoaiPhong.SelectedItem = maLoaiPhong;
                if (TrangThai != null)
                {
                    if (TrangThai)
                    {
                        rdoDaThue.Checked = true;
                    }
                    else
                    {
                        rdoTrong.Checked = true;
                    }
                }
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLock();
            txtMaPhong.Enabled = false;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            SetValues();
            UnLock();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSoDo_Click(object sender, EventArgs e)
        {
            FrmPhong frm = new FrmPhong();
            frm.ShowDialog();
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenPhong.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phòng");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtGia.Text))
                    {
                        MessageBox.Show("Vui lòng nhập giá phòng");
                    }
                    else
                    {
                        if(!double.TryParse(txtGia.Text,out double giaPhong))
                        {
                            MessageBox.Show("Vui lòng Giá phòng là số");
                        }
                        else
                        {
                            if (cbMaLoaiPhong.SelectedIndex == -1)
                            {
                                MessageBox.Show("Vui lòng chọn loại phòng");
                            }
                            else
                            {
                                DTO_Phong p = new DTO_Phong();
                                p.MaPhong = txtMaPhong.Text;
                                p.TenPhong = txtTenPhong.Text;
                                p.Gia = double.Parse(txtGia.Text);
                                if (rdoDaThue.Checked)
                                {
                                    p.TrangThai = true;
                                }
                                else
                                {
                                    p.TrangThai = false;
                                }

                                p.MaLoaiPhong = cbMaLoaiPhong.SelectedItem.ToString();
                                bus_Phong.LuuPhong(p);
                                MessageBox.Show("Lưu thành công");
                                SetValues();
                            }
                        }
                    }
                }
            }
        }
    }
}
