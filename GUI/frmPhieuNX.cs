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
        private readonly  Storage_Service vatLieu_Service = new Storage_Service();
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
            /*try
            {
                var listTicket = vatLieu_Service.GetAllTicket();
                var listTool = vatLieu_Service.GetAll();
                BindGrid(listTicket);
                FillCmbListTool(listTool);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void gnbtnThoat_Click(object sender, EventArgs e)
        {
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
            /*List<ImportExportTicket> imp = new List<ImportExportTicket>();
            imp = vatLieu_Service.GetAllTicket();
            BindGrid(imp);*/
        }

        private void gnbtnThen_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (gntxtMa.Text == "" ||  gntxtSL.Text == "")
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
                    TaM_ID = int.Parse(gncmbTenThietBi.SelectedValue.ToString()),
                    IorE = gncmbTrangThai.Text,
                    IEDate = gndateNgay.Value,
                    Quantity = Convert.ToInt32(gntxtSL.Text),
                    Total = (vatLieu_Service.GetPriceID(Convert.ToInt32(gncmbTenThietBi.SelectedValue)).UnitPrice * Convert.ToInt32(gntxtSL.Text))

                };
                vatLieu_Service.AddTicket(item);
                LoadList();
                MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                fresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }*/
        }

        private int getSelectedRow(string ID)
        {
            for (int i = 0; i < gndgvNhapXuat.Rows.Count; i++)
            {
                if (gndgvNhapXuat.Rows[i].Cells[0].Value.ToString() == ID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void gnbtnSua_Click(object sender, EventArgs e)
        {
            /*int selectedRow = getSelectedRow(gntxtMa.Text);
            if (selectedRow != -1)
            {
                var item = new ImportExportTicket()
                {
                    IETicketID = Convert.ToInt32(gntxtMa.Text),
                    TaM_ID = int.Parse(gncmbTenThietBi.SelectedValue.ToString()),
                    IorE = gncmbTrangThai.Text,
                    IEDate = gndateNgay.Value,
                    Quantity = Convert.ToInt32(gntxtSL.Text),
                    Total = (vatLieu_Service.GetPriceID(Convert.ToInt32(gncmbTenThietBi.SelectedValue)).UnitPrice * Convert.ToInt32(gntxtSL.Text))

                };
                vatLieu_Service.addOrUpdateIMP(item);
                LoadList();
                fresh();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

        }

        private void gnbtnXoa_Click(object sender, EventArgs e)
        {
            /*var context = new NhaKhoaDB();
            try
            {
                int id = Convert.ToInt32(gntxtMa.Text);
                ImportExportTicket dbDelete = context.ImportExportTickets.FirstOrDefault(p => p.IETicketID == id);
                if (dbDelete != null)
                {
                    DialogResult d = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        context.ImportExportTickets.Remove(dbDelete);
                        context.SaveChanges();
                        LoadList();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                    throw new Exception("Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }*/
        }

        private void gntxtSL_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
