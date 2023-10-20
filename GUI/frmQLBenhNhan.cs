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
    public partial class frmQLBenhNhan : Form
    {
        private readonly BenhNhanServices benhNhanServices = new BenhNhanServices();
        public frmQLBenhNhan()
        {
            InitializeComponent();
        }

        private void frmQLBenhNhan_Load(object sender, EventArgs e)
        {
            foreach (var item in benhNhanServices.GetAll())
            {
                int index = dataGridView1.Rows.Add(item);
                dataGridView1.Rows[index].Cells[0].Value = item.CustomerID;

            }
        }
    }
}
