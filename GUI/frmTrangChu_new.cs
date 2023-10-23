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
            foreach(var item in phieuKham_Services.GetAll())
            {
                var index = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[index].Cells[1].Value = item.Customer.FullName;
                guna2DataGridView1.Rows[index].Cells[2].Value = item.Customer.BirthDay;
                guna2DataGridView1.Rows[index].Cells[3].Value = item.AppointmentDate;
            }
        }

    

        private void btnquanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien nv = new frmQLNhanVien();
            nv.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnquanLyDichVu_Click(object sender, EventArgs e)
        {
            FrmQLDichVu nv = new FrmQLDichVu();
            nv.ShowDialog();
        }
    }
}
