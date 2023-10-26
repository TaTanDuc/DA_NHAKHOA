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
    public partial class frmDieuTri : Form
    {
        private readonly DichVu_Services dichVU_Services = new DichVu_Services();

        public frmDieuTri()
        {
            InitializeComponent();
        }
        
        public void clear()
        {
            txtChanDoanID.Clear();
            txtDieuTriID.Clear();
            txtDonVi.Clear();
            txtGia.Clear();
        }

        public void reLoad()
        {
            guna2DataGridView1.Rows.Clear();   
            foreach (var item in dichVU_Services.GetAllTreatment())
            {
                var index = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[index].Cells[0].Value = item.DiagnoseID;
                guna2DataGridView1.Rows[index].Cells[1].Value = item.TreatmentID;
                guna2DataGridView1.Rows[index].Cells[2].Value = item.TreatmentContent;
                guna2DataGridView1.Rows[index].Cells[3].Value = item.Unit;
                guna2DataGridView1.Rows[index].Cells[4].Value = item.UnitPrice;

                cmbPhuongThuc.DataSource = dichVU_Services.GetAllDiagnose();
                cmbPhuongThuc.ValueMember = "DiagnoseID";
                cmbPhuongThuc.DisplayMember = "DiagnosticContent";
            }
        }

        private void frmDieuTri_Load(object sender, EventArgs e)
        {
            reLoad();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtDieuTriID.Text == "" || txtChanDoanID.Text == "" || txtDonVi.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin");
                return;
            }
            var treatment = new Treatment() { DiagnoseID = cmbPhuongThuc.SelectedIndex + 1 , TreatmentID = Convert.ToInt32(txtDieuTriID.Text) , TreatmentContent = txtChanDoanID.Text, Unit = txtDonVi.Text, UnitPrice = Convert.ToInt32(txtGia.Text) };
            
            if (dichVU_Services.GetTreatment(Convert.ToInt32(cmbPhuongThuc.SelectedIndex + 1),Convert.ToInt32(txtDieuTriID.Text)) == null)
            {
                dichVU_Services.addOrUpdateTreatment(treatment);
                MessageBox.Show("Thêm thành công!","Thông Báo",MessageBoxButtons.OK);
            }
            else MessageBox.Show("Đã tồn tại mã điều trị", "Thông Báo", MessageBoxButtons.OK);
            reLoad();
            clear();
        }

        private void btnChanDoan_Click(object sender, EventArgs e)
        {
            frmChanDoan chanDoan = new frmChanDoan();
            this.Hide();
            chanDoan.ShowDialog();
            chanDoan.Dispose();
            this.Show();
            reLoad();
            clear();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (txtDieuTriID.Text == "" || txtChanDoanID.Text == "" || txtDonVi.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin");
                return;
            }
            var treatment = new Treatment() { DiagnoseID = cmbPhuongThuc.SelectedIndex + 1, TreatmentID = Convert.ToInt32(txtDieuTriID.Text), TreatmentContent = txtChanDoanID.Text, Unit = txtDonVi.Text, UnitPrice = Convert.ToInt32(txtGia.Text) };
            
            if (dichVU_Services.GetTreatment(Convert.ToInt32(cmbPhuongThuc.SelectedIndex + 1), Convert.ToInt32(txtDieuTriID.Text)) != null)
            {
                dichVU_Services.addOrUpdateTreatment(treatment);
                MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Không tồn tại mã điều trị", "Thông Báo", MessageBoxButtons.OK);
            reLoad();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDieuTriID.Text == "" || txtChanDoanID.Text == "" || txtDonVi.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin");
                return;
            }
            var treatment = new Treatment() { DiagnoseID = cmbPhuongThuc.SelectedIndex + 1, TreatmentID = Convert.ToInt32(txtDieuTriID.Text), TreatmentContent = txtChanDoanID.Text, Unit = txtDonVi.Text, UnitPrice = Convert.ToInt32(txtGia.Text) };
            
            if (dichVU_Services.GetTreatment(Convert.ToInt32(cmbPhuongThuc.SelectedIndex + 1), Convert.ToInt32(txtDieuTriID.Text)) != null)
            {
                dichVU_Services.removeTreatment(treatment);
                MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Không tồn tại mã điều trị", "Thông Báo", MessageBoxButtons.OK);
            reLoad();
            clear();
        }
    }
}
