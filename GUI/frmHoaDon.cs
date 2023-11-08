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
    public partial class frmHoaDon : Form
    {
        private readonly Invoice_Services hoaDon_Services = new Invoice_Services();
        private readonly Schedule_Services phieuKham_Services = new Schedule_Services();
        public frmHoaDon(int id)
        {
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
