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
    public partial class frmQLVatLieu : Form
    {
        private readonly VatLieu_Service vatLieu_Service = new VatLieu_Service();
        public frmQLVatLieu()
        {
            InitializeComponent();
        }

        private void gnbtnThoat_Click(object sender, EventArgs e)
        {
            
            frmTrangChu_new FrmTrangChu_New = new frmTrangChu_new();
            FrmTrangChu_New.ShowDialog();
            this.Close();
        }

        private void frmQLVatLieu_Load(object sender, EventArgs e)
        {
            try
            {
                var listTool = vatLieu_Service.GetAll();              
                BindGrid(listTool);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BindGrid(List<ToolAndMaterial> toolAndMaterials)
        {
            gndgvQLVL.Rows.Clear();
            foreach(var item in toolAndMaterials)
            {
                int index = gndgvQLVL.Rows.Add();
                gndgvQLVL.Rows[index].Cells[0].Value = item.TaM_ID;
                gndgvQLVL.Rows[index].Cells[1].Value = item.Content;
                gndgvQLVL.Rows[index].Cells[2].Value = item.Unit;
                gndgvQLVL.Rows[index].Cells[3].Value = item.UnitPrice;

            }
        }

        private void gnbtnThemMoi_Click(object sender, EventArgs e)
        {
            frmPhieuNX FrmPhieuNX = new frmPhieuNX();
            this.Hide();
            FrmPhieuNX.ShowDialog();
            this.Show();
        }

        public string id, content, unit, price;
        public int flag;
        private void LoadList()
        {
            List<ToolAndMaterial> tol = new List<ToolAndMaterial>();
            tol = vatLieu_Service.GetAll();
            BindGrid(tol);
        }
        private void gnbtnQLDungCu_Click(object sender, EventArgs e)
        {
            frmThemVatLieu FrmThemVatLieu = new frmThemVatLieu();
            this.Hide();
            FrmThemVatLieu.ShowDialog();
            LoadList();
            this.Show();
        }
    }
}
