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
        private readonly PhieuKham_Services phieuKham_Services = new PhieuKham_Services();
        private readonly Status_Services status_Services = new Status_Services();
        public frmLichKham()
        {
            InitializeComponent();
        }

        private void update(List<ExamTicket> list)
        {
            guna2DataGridView1.Rows.Clear();

            foreach (var item in list)
            {
                var index = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[index].Cells[0].Value = item.TicketID;
                guna2DataGridView1.Rows[index].Cells[1].Value = item.Customer.FullName;
                guna2DataGridView1.Rows[index].Cells[2].Value = item.Customer.Phone;
                guna2DataGridView1.Rows[index].Cells[3].Value = item.AppointmentDate;
                guna2DataGridView1.Rows[index].Cells[4].Value = item.Status.StatusName;
            }
        }

        private void frmQLLichKham_Load(object sender, EventArgs e)
        {
            update(phieuKham_Services.GetAll());
            guna2ComboBox1.DataSource = status_Services.GetAll();
            guna2ComboBox1.ValueMember = "StatusID";
            guna2ComboBox1.DisplayMember = "StatusName";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            update(phieuKham_Services.Find(guna2TextBox1.Text, guna2DateTimePicker1.Value.Date, Convert.ToInt32(guna2ComboBox1.SelectedValue)));
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            update(phieuKham_Services.GetAll());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
    }
}
