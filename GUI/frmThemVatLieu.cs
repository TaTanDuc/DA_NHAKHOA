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
    public partial class frmThemVatLieu : Form
    {
        public frmThemVatLieu()
        {
            InitializeComponent();
        }

        private void gnbtnThoat_Click(object sender, EventArgs e)
        {
            frmQLVatLieu FrmQLVatLieu = new frmQLVatLieu();
            FrmQLVatLieu.ShowDialog();
            this.Close();   
        }
    }
}
