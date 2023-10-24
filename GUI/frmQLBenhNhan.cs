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
    public partial class frmQLBenhNhan : Form
    {
        private readonly BenhNhanServices benhNhanServices = new BenhNhanServices();
        public frmQLBenhNhan()
        {
            InitializeComponent();
        }

        private void BindGrid(List<Customer> listCustomer)
        {
            dgvBenhNhan.Rows.Clear();
            foreach (var item in listCustomer)
            {
                int index = dgvBenhNhan.Rows.Add();
                dgvBenhNhan.Rows[index].Cells[0].Value = item.CustomerID;
                dgvBenhNhan.Rows[index].Cells[1].Value = item.FullName;
                if (rdbtnNam.Checked)
                {
                    dgvBenhNhan.Rows[index].Cells[2].Value = "Nam";
                }
                if (rdbtnNu.Checked)
                {
                    dgvBenhNhan.Rows[index].Cells[2].Value = "Nữ";
                }
                dgvBenhNhan.Rows[index].Cells[3].Value = item.BirthDay;
                dgvBenhNhan.Rows[index].Cells[4].Value = item.Address;

            }
        }
        private void frmQLBenhNhan_Load(object sender, EventArgs e)
        {
            foreach (var item in benhNhanServices.GetAll())
            {
                int index = dgvBenhNhan.Rows.Add(item);
                dgvBenhNhan.Rows[index].Cells[0].Value = item.CustomerID;
                
            }
        }
        
        private void tlsbtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhaKhoaDB context = new NhaKhoaDB();
                Customer cus = new Customer();
                cus.CustomerID = txtMaBenhNhan.Text;
                cus.FullName = txtTen.Text;
                if (rdbtnNam.Checked)
                {
                    cus.Sex = "Nam";
                }
                if (rdbtnNu.Checked)
                {
                    cus.Sex = "Nữ";
                }
                //cus.BirthDay = txtNgay.Text;
                cus.Address = txtDiaChi.Text;
                context.SaveChanges();
                MessageBox.Show("Thêm mới thành công!");
                context = new NhaKhoaDB();
                BindGrid(context.Customers.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
