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
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
