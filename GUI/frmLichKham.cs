using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLichKham : Form
    {
        private readonly Schedule_Services phieuKham_Services = new Schedule_Services();
        private readonly Status_Services status_Services = new Status_Services();
        public frmLichKham()
        {
            InitializeComponent();
        }

        private void frmQLLichKham_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = guna2DataGridView1.SelectedCells[0].RowIndex;
            frmHoaDon frmHoaDon = new frmHoaDon(Convert.ToInt32(guna2DataGridView1.Rows[index].Cells[0].Value));
            this.Hide();
            frmHoaDon.ShowDialog();
            frmHoaDon.Dispose();
            this.Show();
        }

        private void khámToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void chưaKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
