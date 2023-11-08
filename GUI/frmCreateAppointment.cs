using BUS;
using DAL.Entities;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCreateAppointment : Form
    {
        private readonly Service_Services service_Services = new Service_Services();
        public static frmCreateAppointment instance;
        public frmCreateAppointment()
        {
            InitializeComponent();
            instance = this;
        }

        private void AddToDgv(Service service)
        {
                int index = dgvService.Rows.Add();
                dgvService.Rows[index].Cells[0].Value = service.ServiceCategory.CategoryName;
                dgvService.Rows[index].Cells[1].Value = service.ServiceName;
                dgvService.Rows[index].Cells[2].Value = service.ServiceUnitPrice;
                dgvService.Rows[index].Cells[3].Value = service.ServiceUnit;
                dgvService.Rows[index].Cells[5].Value = 0;
        }

        public void checkDuplicate(Service service)
        {
            for(int i = 0; i < dgvService.RowCount; i++)
            {
                if (dgvService.Rows[i].Cells[1].Value.Equals(service.ServiceName))
                {
                    MessageBox.Show("Đã Tồn Tại Dịch Vụ!", "Thông Báo!", MessageBoxButtons.OK);
                    return;
                }
            }
            AddToDgv(service);
        }

        private void Total()
        {
            int total = 0;
            for (int i = 0;i < dgvService.RowCount; i++)
            {
                dgvService.Rows[i].Cells[5].Value = Convert.ToInt32(dgvService.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvService.Rows[i].Cells[4].Value);
                total = Convert.ToInt32(dgvService.Rows[i].Cells[5].Value) + total;
            }
            txtTotal.Text = $"Tổng: {total.ToString()}";
        }

        private void frmNoiDungKham_Load(object sender, EventArgs e)
        {
            dpBirthDay.Value = DateTime.Today;
            dpAppointment.Value = DateTime.Now;
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void guna2ComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
        
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddServices frmAddServices = new AddServices();
            frmAddServices.ShowDialog();
        }

        private void dgvService_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Total();
        }
    }
}
