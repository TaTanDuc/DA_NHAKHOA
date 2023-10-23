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
    public partial class frmPhieuNX : Form
    {
        private readonly  VatLieu_Service vatLieu_Service = new VatLieu_Service();
        public frmPhieuNX()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuNX_Load(object sender, EventArgs e)
        {
            try
            {
                var listTicket = vatLieu_Service.GetAllTicket();
                var listTool = vatLieu_Service.GetAll();
                BindGrid(listTicket);
                FillCmbListTool(listTool);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillCmbListTool(List<ToolAndMaterial> tol)
        {
            tol.Insert(0, new ToolAndMaterial());
            this.gncmbTenThietBi.DataSource = tol;
            this.gncmbTenThietBi.DisplayMember = "Content";
            this.gncmbTenThietBi.ValueMember = "TaM_ID";
        }

        private void BindGrid(List<ImportExportTicket> importExportTickets)
        {
            gndgvNhapXuat.Rows.Clear();
            foreach (var item in importExportTickets)
            {
                int index = gndgvNhapXuat.Rows.Add();
                gndgvNhapXuat.Rows[index].Cells[0].Value = item.IETicketID;
                gndgvNhapXuat.Rows[index].Cells[1].Value = item.ToolAndMaterial.Content;
                gndgvNhapXuat.Rows[index].Cells[2].Value = item.IorE;
                gndgvNhapXuat.Rows[index].Cells[3].Value = item.IEDate;
                gndgvNhapXuat.Rows[index].Cells[4].Value = item.Quantity;
                gndgvNhapXuat.Rows[index].Cells[5].Value = item.Total;

            }
        }

        private void gnbtnThoat_Click(object sender, EventArgs e)
        {
            frmQLVatLieu FrmQLVatLieu = new frmQLVatLieu();
            FrmQLVatLieu.ShowDialog();
            this.Close();
        }

        private void gndgvNhapXuat_SelectionChanged(object sender, EventArgs e)
        {
            if (gndgvNhapXuat.SelectedRows.Count > 0)
            {
                DataGridViewRow selecttedRows = gndgvNhapXuat.SelectedRows[0];
                string ma = Convert.ToString(selecttedRows.Cells[0].Value);
                string ten = Convert.ToString(selecttedRows.Cells[1].Value);
                string trangThai = Convert.ToString(selecttedRows.Cells[2].Value);
                string ngay = Convert.ToString(selecttedRows.Cells[3].Value);
                string sl = Convert.ToString(selecttedRows.Cells[4].Value);
                string dg = Convert.ToString(selecttedRows.Cells[5].Value);
                
                gntxtMa.Text = ma;
                gncmbTenThietBi.Text = ten;
                gncmbTrangThai.Text = trangThai;
                gndateNgay.Text = ngay;
                gntxtSL.Text = sl;
                gntxtGia.Text = dg;
            }
        }

        private void fresh()
        {
            gntxtMa.Clear();
            gncmbTenThietBi.SelectedValue = 1;
            gntxtGia.Clear();
            gntxtSL.Clear();
            gncmbTrangThai.SelectedValue = 1;
            
        }

        private void LoadList()
        {
            List<ImportExportTicket> imp = new List<ImportExportTicket>();
            imp = vatLieu_Service.GetAllTicket();
            BindGrid(imp);
        }

        private void gnbtnThen_Click(object sender, EventArgs e)
        {
            try
            {
                if (gntxtMa.Text == "" ||  gntxtGia.Text == "" || gntxtSL.Text == "")
                {
                    throw new Exception("Vui lòng điền thông tin vào ô trống");
                }
                foreach (DataGridViewRow i in gndgvNhapXuat.Rows)
                {
                    if (gntxtMa.Text == gndgvNhapXuat.Rows[i.Index].Cells[0].Value.ToString())
                        throw new Exception("ID đã tồn tại");
                }
                
                var item = new ImportExportTicket()
                {
                   IETicketID = Convert.ToInt32(gntxtMa.Text),
                   TaM_ID = Convert.ToInt32(gncmbTenThietBi.Text),
                   IorE = gncmbTrangThai.Text,
                   IEDate = gndateNgay.Value,
                   Quantity = Convert.ToInt32(gntxtSL.Text),
                   Total = Convert.ToInt64(gntxtGia.Text)

                };
                vatLieu_Service.AddTicket(item);
                LoadList();
                MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
