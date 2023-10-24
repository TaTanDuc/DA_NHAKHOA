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
    public partial class FrmQLDichVu : Form
    {
        private readonly DichVu_Services dichVu_Services = new DichVu_Services();
        public FrmQLDichVu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gnbtnThoat_Click(object sender, EventArgs e)
        {
            FrmTrangChu frmTrangChu = new FrmTrangChu();
            frmTrangChu.ShowDialog();
            this.Close();
        }

        private void FrmQLDichVu_Load(object sender, EventArgs e)
        {
           
            
                try
                {

                    var dsChuanDoan = dichVu_Services.GetAllDiagnose();
                    var dsDieuTri = dichVu_Services.GetAllTreatment();
                    BindGrid(dsDieuTri);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }


        private void BindGrid(List<Treatment> dsDieuTri)
        {
            gndgvDSDieuTri.Rows.Clear();
            foreach (var item in dsDieuTri)
            {
                int index = gndgvDSDieuTri.Rows.Add();
                gndgvDSDieuTri.Rows[index].Cells[0].Value = item.TreatmentID;
                gndgvDSDieuTri.Rows[index].Cells[1].Value = item.DiagnoseID;
                gndgvDSDieuTri.Rows[index].Cells[2].Value = item.Diagnose.DiagnosticContent;
                gndgvDSDieuTri.Rows[index].Cells[3].Value = item.TreatmentContent;
                gndgvDSDieuTri.Rows[index].Cells[4].Value = item.Unit;
                gndgvDSDieuTri.Rows[index].Cells[5].Value = item.UnitPrice;
            }
        }

        private void RefreshC()
        {
            gntxtMa.Clear();
            gntxtMaChuanDoan.Clear();
            gntxtChuanDoan.Clear();
            gntxtNoiDung.Clear();
            gntxtDVT.Clear();
            gntxtDonGia.Clear();
        }
        private void LoadList()
        {
            List<Treatment> treatments = new List<Treatment>();
            List<Diagnose> diagnoses = new List<Diagnose>();
            treatments = dichVu_Services.GetAllTreatment();
            diagnoses = dichVu_Services.GetAllDiagnose();
            BindGrid(treatments);
        }

        private void gnbtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gntxtDonGia.Text == "" || gntxtChuanDoan.Text == "" || gntxtMa.Text == "" || gntxtMaChuanDoan.Text == "" || 
                    gntxtNoiDung.Text == ""|| gntxtDVT.Text == "")
                {
                    throw new Exception("Vui lòng điền thông tin vào ô trống");
                }

                int selectedRow = getSelectedRow(gntxtMa.Text,gntxtMaChuanDoan.Text);
                if (selectedRow == -1)
                {
                    selectedRow = gndgvDSDieuTri.Rows.Add();
                    insertUpdate(selectedRow);
                }
               

              //  LoadList();
                Refresh();
                /*    var treatment = new Treatment()
                {
                    TreatmentID = Convert.ToInt32(gntxtMa.Text),
                    TreatmentContent = gntxtNoiDung.Text,
                    Unit = gntxtDVT.Text,
                    UnitPrice = Convert.ToInt32(gntxtDonGia.Text)

                };
                dichVu_Services.addOrUpdateTreatment(treatment);

                var diagnose = new Diagnose()
                {
                    DiagnoseID = Convert.ToInt32(gntxtMaChuanDoan.Text),
                    DiagnosticContent = gntxtChuanDoan.Text
                };

                dichVu_Services.addOrUpdateDiagnose(diagnose);
                LoadList();
                MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                Refresh();
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private int getSelectedRow(string diagnoseID, string treatmentID)
        {
            for (int i = 0; i < gndgvDSDieuTri.Rows.Count; i++)
            {
                if (gndgvDSDieuTri.Rows[i].Cells[0].Value.ToString() == treatmentID && gndgvDSDieuTri.Rows[i].Cells[1].Value.ToString() == diagnoseID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void insertUpdate(int selectedRow)
        {
            gndgvDSDieuTri.Rows[selectedRow].Cells[0].Value = gntxtMa.Text;
            gndgvDSDieuTri.Rows[selectedRow].Cells[1].Value = gntxtMaChuanDoan.Text;
            gndgvDSDieuTri.Rows[selectedRow].Cells[2].Value = gntxtChuanDoan.Text;
            gndgvDSDieuTri.Rows[selectedRow].Cells[3].Value = gntxtNoiDung.Text;
            gndgvDSDieuTri.Rows[selectedRow].Cells[4].Value = gntxtDVT.Text;
            gndgvDSDieuTri.Rows[selectedRow].Cells[5].Value = gntxtDonGia.Text;

        }
        private void gnbtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = getSelectedRow(gntxtMa.Text, gntxtMaChuanDoan.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy dịch vụ!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Xóa dịch vụ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        gndgvDSDieuTri.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gnbtnSua_Click(object sender, EventArgs e)
        {
            int selectedRow = getSelectedRow(gntxtMa.Text, gntxtMaChuanDoan.Text);
            if (selectedRow != -1)
            {
                insertUpdate(selectedRow);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gndgvDSDieuTri_SelectionChanged(object sender, EventArgs e)
        {
            if(gndgvDSDieuTri.SelectedRows.Count > 0)
            {
                DataGridViewRow selecttedRows = gndgvDSDieuTri.SelectedRows[0];
                string maDieuTri = Convert.ToString(selecttedRows.Cells[0].Value);
                string maChuanDoan = Convert.ToString(selecttedRows.Cells[1].Value);
                string chuanDoan = Convert.ToString(selecttedRows.Cells[2].Value);
                string noiDung = Convert.ToString(selecttedRows.Cells[3].Value);
                string dvt = Convert.ToString(selecttedRows.Cells[4].Value);
                string gia = Convert.ToString(selecttedRows.Cells[5].Value);

                gntxtMa.Text = maDieuTri;
                gntxtMaChuanDoan.Text = maChuanDoan;
                gntxtChuanDoan.Text = chuanDoan;
                gntxtNoiDung.Text = noiDung;
                gntxtDVT.Text = dvt;
                gntxtDonGia.Text = gia;
            }
        }

        private void gndgvDSDieuTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
