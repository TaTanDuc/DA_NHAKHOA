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
    public partial class frmDieuTri : Form
    {
        private readonly DichVu_Services dichVU_Services = new DichVu_Services();

        public frmDieuTri()
        {
            InitializeComponent();
        }

        private void frmDieuTri_Load(object sender, EventArgs e)
        {
            foreach (var item in dichVU_Services.GetAllTreatment())
            {
                var index = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[index].Cells[0].Value = item.TreatmentID;
                guna2DataGridView1.Rows[index].Cells[1].Value = item.DiagnoseID;
                guna2DataGridView1.Rows[index].Cells[2].Value = item.TreatmentContent;
                guna2DataGridView1.Rows[index].Cells[3].Value = item.Unit;
                guna2DataGridView1.Rows[index].Cells[4].Value = item.UnitPrice;
            }
        }
    }
}
