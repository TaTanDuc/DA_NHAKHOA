using BUS;
using DAL.Entities;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
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
        private readonly User_Services user_Services = new User_Services();
        private readonly Schedule_Services schedule_Services = new Schedule_Services();
        private readonly Details_Services details_Services = new Details_Services();
        public static frmCreateAppointment instance;
        public frmCreateAppointment()
        {
            InitializeComponent();
            instance = this;
        }

        private void update(User user)
        {
            if (user != null) 
            {
                guna2TextBox1.Text = user.PermissionID + user.UserID.ToString();
                guna2TextBox2.Text = user.FullName.ToString();
                guna2TextBox3.Text = user.Phone.ToString();

                if (user.Sex == "f")
                    guna2RadioButton2.Checked = true;
                else guna2RadioButton1.Checked = true;

                dpBirthDay.Value = user.BirthDay.Value;
            }
            
        }

        private void reset()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            dpBirthDay.Value = DateTime.Today;
            dpAppointment.Value = DateTime.Now;
            guna2RadioButton2.Checked = true;
        }

        private void AddToDgv(Service service)
        {
                int index = dgvService.Rows.Add();
                dgvService.Rows[index].Cells[0].Value = service.ServiceCategory.CategoryName;
                dgvService.Rows[index].Cells[1].Value = service.ServiceName;
                dgvService.Rows[index].Cells[2].Value = service.ServiceUnitPrice;
                dgvService.Rows[index].Cells[3].Value = service.ServiceUnit;
                dgvService.Rows[index].Cells[5].Value = 0;
                dgvService.Rows[index].Cells[6].Value = service.CategoryID;
                dgvService.Rows[index].Cells[7].Value = service.ServiceID;
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
            for (int i = 0; i < dgvService.RowCount; i++)
            {
                try
                {
                    dgvService.Rows[i].Cells[5].Value = Convert.ToInt32(dgvService.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvService.Rows[i].Cells[4].Value);
                    total = Convert.ToInt32(dgvService.Rows[i].Cells[5].Value) + total;
                }
                catch(Exception ex)
                {
                    if (ex is FormatException)
                        MessageBox.Show("Chỉ Nhập Số!", "Cảnh Báo!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show($"{ex}");
                }
            }
            txtTotal.Text = $"Tổng: {total.ToString()}";
        }

        private void frmNoiDungKham_Load(object sender, EventArgs e)
        {
            dpBirthDay.Value = DateTime.Today;
            dpAppointment.Value = DateTime.Now;
            guna2RadioButton2.Checked = true;
        }

        private void guna2ComboBox2_SelectedValueChanged(object sender, EventArgs e)
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

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvService.CurrentCell == null)
                return;
            dgvService.Rows.RemoveAt(dgvService.CurrentCell.RowIndex);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hủy Đăng Kí Lịch Khám?","Thông Báo!",MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                update(user_Services.findByID(guna2TextBox1.Text.Substring(0, 2), Convert.ToInt32(guna2TextBox1.Text.Substring(2))));
            }
            catch(Exception ex)
            {
                if (ex is ArgumentOutOfRangeException)
                    update(user_Services.findByPhone(guna2TextBox3.Text));
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (user_Services.validateUser(guna2TextBox1.Text.Substring(0, 2), Convert.ToInt32(guna2TextBox1.Text.Substring(2))) is false)
                {
                    MessageBox.Show("Không tồn tại khách hàng!", "Thông Báo!", MessageBoxButtons.OK);
                }
                else if (dgvService.RowCount <= 0)
                {
                    MessageBox.Show("Vui Lòng Chọn Ít Nhất Một Dịch Vụ!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    List<ServicesDetail> list = new List<ServicesDetail>();
                    var schedule = new Schedule() { StatusID = "NC" ,Appointment = dpAppointment.Value, PermissionID = guna2TextBox1.Text.Substring(0,2), UserID = Convert.ToInt32(guna2TextBox1.Text.Substring(2))};

                    for (int i = 0; i < dgvService.RowCount; i++)
                    {
                        list.Add(new ServicesDetail()
                        {
                            Appointment = schedule.Appointment,
                            PermissionID = schedule.PermissionID,
                            UserID = schedule.UserID,
                            CategoryID = dgvService.Rows[i].Cells[6].Value.ToString(),
                            ServiceID = Convert.ToInt32(dgvService.Rows[i].Cells[7].Value),
                            Quantity = Convert.ToInt32(dgvService.Rows[i].Cells[4].Value),
                            Total = Convert.ToInt64(dgvService.Rows[i].Cells[5].Value)
                        });
                    }
                    schedule_Services.Add(schedule);
                    details_Services.autoAddDetail(schedule, list);
                    MessageBox.Show("Tạo Lịch Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                    reset();
                }
            }
            catch (Exception ex)
            {
                if (ex is ArgumentOutOfRangeException)
                    MessageBox.Show("Không tồn tại khách hàng!", "Thông Báo!", MessageBoxButtons.OK);
                else throw new Exception(ex.Message);
            }
        }
    }
}
