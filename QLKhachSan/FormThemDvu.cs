using BUS_qlks;
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
    public partial class FormThemDvu : Form
    {
        public FormThemDvu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        BUS_Dichvu busdv = new BUS_Dichvu();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void danhsachDvu()
        {
            dataGridView1.DataSource = busdv.DanhsachDvu();

        }
        private void FormThemDvu_Load(object sender, EventArgs e)
        {
            danhsachDvu();
            btnPhai.Click += btnPhai_Click;
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            // Thêm các cột cho dataGridViewDestination nếu chưa có
            if (dataGridView2.Columns.Count == 0)
            {
                dataGridView2.Columns.Add("Column1", "Loaidichvu");
                dataGridView2.Columns.Add("Column2", "tendichvu");
                dataGridView2.Columns.Add("Column3", "Soluong");
                // Thêm các cột khác nếu cần
            }
            // Lấy chỉ mục của dòng được chọn trong DataGridView nguồn
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

            // Lấy dữ liệu từ các ô của dòng được chọn
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            // Thêm dữ liệu vào DataGridView đích
            dataGridView2.Rows.Add(selectedRow.Cells[0].Value, selectedRow.Cells[1].Value, selectedRow.Cells[2].Value);

            // Xóa dòng được chọn khỏi DataGridView nguồn
            dataGridView1.Rows.RemoveAt(selectedRowIndex);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
