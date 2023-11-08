using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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
        private readonly Schedule_Services phieuKham_Services = new Schedule_Services();
        
        public frmTrangChu_new()
        {
            InitializeComponent();
        }
        
        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
        /*public void reload(List<ExamTicket> list)
        {
            guna2DataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                var index = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[index].Cells[0].Value = item.Customer.FullName;
                guna2DataGridView1.Rows[index].Cells[1].Value = item.Customer.BirthDay;
                guna2DataGridView1.Rows[index].Cells[2].Value = item.Customer.Phone;
                guna2DataGridView1.Rows[index].Cells[3].Value = item.AppointmentDate;
                guna2DataGridView1.Rows[index].Cells[4].Value = item.Status.StatusName;

            }
        }*/

        private void frmTrangChu_new_Load(object sender, EventArgs e)
        {
            
        }

        private void btnquanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien_new nv = new frmQLNhanVien_new();
            this.Hide();
            nv.ShowDialog();
            nv.Dispose();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Đăng Xuất?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                frmDangNhap frmDangNhap = new frmDangNhap();
                this.Hide();
                if (frmDangNhap.ShowDialog() != DialogResult.OK)
                    this.Close();
                else this.Show();
            }
            else return;
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
            frmDieuTri dieuTri = new frmDieuTri();
            this.Hide();
            dieuTri.ShowDialog();
            dieuTri.Dispose();
            this.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmCreateAppointment frmNoiDungKham = new frmCreateAppointment();
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
