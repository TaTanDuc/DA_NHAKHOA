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
    public partial class frmQLNhanVien_new : Form
    {
        private readonly NhanVien_Services nhanvien = new NhanVien_Services();
        public frmQLNhanVien_new()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
        private void BindGrid(List<Staff> dsNhanvien)
        {
            dgvDSNV.Rows.Clear();
            foreach (var item in dsNhanvien)
            {
                int index = dgvDSNV.Rows.Add();
                dgvDSNV.Rows[index].Cells[0].Value = item.StaffID;
                dgvDSNV.Rows[index].Cells[1].Value = item.FullName;
                dgvDSNV.Rows[index].Cells[2].Value = item.Phone;
            }
        }

        private void RefreshC()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            
        }
        private void LoadList()
        {
            List<Staff> staffs = new List<Staff>();
            staffs = nhanvien.GetAllStaff();
            List<LogIn> lg = new List<LogIn>();
            lg = nhanvien.GetAllLogIn();
            BindGrid(staffs);
        }

        private int getSelectedRow(string staffid)
        {
            for (int i = 0; i < dgvDSNV.Rows.Count; i++)
            {
                if (dgvDSNV.Rows[i].Cells[0].Value.ToString() == staffid )
                {
                    return i;
                }
            }
            return -1;
        }

        private void insertUpdate(int selectedRow)
        {
            dgvDSNV.Rows[selectedRow].Cells[0].Value = txtMa.Text;
            dgvDSNV.Rows[selectedRow].Cells[1].Value = txtTen.Text;
            dgvDSNV.Rows[selectedRow].Cells[2].Value = txtSDT.Text;
           
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "" || txtTen.Text == "" || txtSDT.Text == "" )
                {
                    throw new Exception("Vui lòng điền thông tin vào ô trống");
                }

                int selectedRow = getSelectedRow(txtMa.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvDSNV.Rows.Add();
                    insertUpdate(selectedRow);
                }
                
                Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }



        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmQLNhanVien_new_Load(object sender, EventArgs e)
        {
            try
            {

                var dsNhanVien  = nhanvien.GetAllStaff();
                var dsMK = nhanvien.GetAllLogIn();
                BindGrid(dsNhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int selectedRow = getSelectedRow(txtMa.Text);
            if (selectedRow != -1)
            {
                insertUpdate(selectedRow);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = getSelectedRow(txtMa.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy dịch vụ!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Xóa dịch vụ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvDSNV.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dgvDSNV.Rows[e.RowIndex];
            txtMa.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
           
        }
    }
}
