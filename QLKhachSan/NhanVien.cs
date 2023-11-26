using DTO_qlks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLKhachSan
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();

            btnThem.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnThem.Width, btnThem.Height, 20, 20));
            btnSua.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnSua.Width, btnSua.Height, 20, 20));
            btnXoa.Region = Region.FromHrgn(MyUI.CreateRoundRectRgn(0, 0, btnXoa.Width, btnXoa.Height, 20, 20));
        }

        BUS_qlks.Class1 busnv = new BUS_qlks.Class1();
        DTO_nhanvien dtonv= new DTO_nhanvien();

        public static string email;

        private void NhanVien_Load(object sender, EventArgs e)
        {
            Danhsachnhanvien();
        }
        //test
        private void Danhsachnhanvien()
        {
            dataGridView1.DataSource = busnv.danhsachnhanvien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtTim.Text != "")
            {
                DataTable data = busnv.timnhanvien(txtTim.Text);
                if(data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên bạn muốn tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = dataGridView1.CurrentCell.RowIndex;
            string manhanvien = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if(manhanvien != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busnv.XoaNhanVien(manhanvien))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Danhsachnhanvien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaNhanVien f = new FormThemSuaNhanVien(true);
            f.ShowDialog();
            if (f.istrangthai)
            {
                Danhsachnhanvien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormThemSuaNhanVien f = new FormThemSuaNhanVien(false);
            f.layemail = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            f.ShowDialog();
            if (f.istrangthai)
            {
                Danhsachnhanvien();
            }
        }
    }
}
