using BUS;
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
    public partial class frmTrangChu_new : Form
    {
        private readonly PhieuKham_Services phieuKham_Services = new PhieuKham_Services();
        
        public frmTrangChu_new()
        {
            InitializeComponent();
        }
        
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmTrangChu_new_Load(object sender, EventArgs e)
        {
            foreach(var item in phieuKham_Services.GetToday())
            {
                var index = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[index].Cells[1].Value = item.Customer.FullName;
                guna2DataGridView1.Rows[index].Cells[2].Value = item.Customer.BirthDay;
                guna2DataGridView1.Rows[index].Cells[3].Value = item.Customer.Phone;
                guna2DataGridView1.Rows[index].Cells[4].Value = item.AppointmentDate;
                guna2DataGridView1.Rows[index].Cells[5].Value = item.Status.StatusName;

            }
        }

    

        private void btnquanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmql = new frmQLNhanVien();
            this.Hide();
            nv.ShowDialog();
            nv.Dispose();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            frmLichKham lichKham = new frmLichKham();
            this.Hide();
            lichKham.ShowDialog();
            lichKham.Dispose();
            this.Show();
        }
        private void btnquanLyDichVu_Click(object sender, EventArgs e)
        {
            FrmQLDichVu nv = new FrmQLDichVu();
            nv.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmNoiDungKham frmNoiDungKham = new frmNoiDungKham();
            this.Hide();
            frmNoiDungKham.ShowDialog();
            frmNoiDungKham.Dispose();
            this.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            frmQLVatLieu qLVatLieu = new frmQLVatLieu();
            this.Hide();
            qLVatLieu.ShowDialog();
            qLVatLieu.Dispose();
            this.Show();
        }
    }
}
