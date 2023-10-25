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
using DAL.Entities;
namespace GUI
{
    public partial class frmChanDoan : Form
    {
        private readonly DichVu_Services dichVu_Services = new DichVu_Services();
        public frmChanDoan()
        {
            InitializeComponent();
        }

        public void reLoad()
        {
            dgvChanDoan.Rows.Clear();
            foreach (var item in dichVu_Services.GetAllDiagnose())
            {
                var index = dgvChanDoan.Rows.Add();

                dgvChanDoan.Rows[index].Cells[0].Value = item.DiagnoseID;
                dgvChanDoan.Rows[index].Cells[1].Value = item.DiagnosticContent;

            }
        }

        private void frmChanDoan_Load(object sender, EventArgs e)
        {
            reLoad();
        }
        private void refres()
        {
            txtChanDoanID.Clear();
            txtPhuongThuc.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var diagnose = new Diagnose() { DiagnoseID = Convert.ToInt32(txtChanDoanID.Text), DiagnosticContent = txtPhuongThuc.Text };
                if (txtChanDoanID.Text == "")
                {
                    throw new Exception("Vui lòng điền thông tin vào ô trống");
                }

                if (dichVu_Services.GetDiagnose(Convert.ToInt32(txtChanDoanID.Text)) != null)
                    MessageBox.Show("Đã tồn tại ID!", "Thông Báo", MessageBoxButtons.OK);
                else dichVu_Services.addOrUpdateDiagnose(diagnose);

                refres();
                reLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            var diagnose = new Diagnose() { DiagnoseID = Convert.ToInt32(txtChanDoanID.Text), DiagnosticContent = txtPhuongThuc.Text };
            if (dichVu_Services.GetDiagnose(Convert.ToInt32(txtChanDoanID.Text)) != null)
            {
                dichVu_Services.addOrUpdateDiagnose(diagnose);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refres();
            reLoad();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var diagnose = new Diagnose() { DiagnoseID = Convert.ToInt32(txtChanDoanID.Text), DiagnosticContent = txtPhuongThuc.Text };
                if (dichVu_Services.GetDiagnose(Convert.ToInt32(txtChanDoanID.Text)) != null)
                {
                    
                    DialogResult dr = MessageBox.Show("Xóa dịch vụ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dichVu_Services.removeDiagnose(diagnose);
                        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại ID!","Thông Báo",MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refres() ;
            reLoad();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
