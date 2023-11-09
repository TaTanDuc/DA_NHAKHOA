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
        private readonly Schedule_Services schedule_Services = new Schedule_Services();
        private readonly Status_Services status_Services = new Status_Services();
        public frmLichKham()
        {
            InitializeComponent();
        }

        private void update(Schedule schedule)
        {
            dgvAllSchedule.Rows.Clear();
            int index = dgvAllSchedule.Rows.Add();
            dgvAllSchedule.Rows[index].Cells[0].Value = schedule.User.FullName;
            dgvAllSchedule.Rows[index].Cells[1].Value = schedule.User.Phone;
            dgvAllSchedule.Rows[index].Cells[2].Value = schedule.Appointment;
            dgvAllSchedule.Rows[index].Cells[3].Value = schedule.Status.StatusName;
        }

        private void frmQLLichKham_Load(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = DateTime.Now;
            foreach(var item in schedule_Services.getAll())
            {
                update(item);
            }
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
            int index = dgvAllSchedule.SelectedCells[0].RowIndex;
            frmInvoice frmHoaDon = new frmInvoice(Convert.ToInt32(dgvAllSchedule.Rows[index].Cells[0].Value));
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
