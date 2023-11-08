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
using BUS;

namespace GUI
{
    public partial class AddServices : Form
    {
        private readonly Service_Services service_Services = new Service_Services();
        public AddServices()
        {
            InitializeComponent();
        }

        private void update()
        {
            cbServices.DataSource = service_Services.getServices(cbCategory.SelectedValue.ToString());
            cbServices.ValueMember = "ServiceID";
            cbServices.DisplayMember = "ServiceName";
        }

        private void AddServices_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = service_Services.getCategories();
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DisplayMember = "CategoryName";

            update();
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            update();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thêm Dịch Vụ?","Thông Báo!",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frmCreateAppointment.instance.checkDuplicate(service_Services.getService(cbCategory.SelectedValue.ToString(),Convert.ToInt32(cbServices.SelectedValue)));
            }
        }
    }
}
