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
        private readonly Storage_Service vatLieu_Service = new Storage_Service();
        public frmQLVatLieu()
        {
            InitializeComponent();
        }

        private void gnbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLVatLieu_Load(object sender, EventArgs e)
        {

        }

        private void gnbtnThemMoi_Click(object sender, EventArgs e)
        {
            frmPhieuNX FrmPhieuNX = new frmPhieuNX();
            this.Hide();
            FrmPhieuNX.ShowDialog();
            this.Show();
        }
        private void LoadList()
        {

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
