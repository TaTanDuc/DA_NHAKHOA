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
    public partial class CreateAccount : Form
    {
        private readonly User_Services user_Services = new User_Services();
        private readonly Permission_Services permission_Services = new Permission_Services();
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtLogin.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            txtPhone.Text = "";
            txtRePass.Text = "";
            dpBirthDay.Value = DateTime.Today;
            rbFemale.Checked = true;
        }

        private string checkSex()
        {
            if (rbFemale.Checked)
                return "f";
            else return "m";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn hủy tạo tài khoản?","Thông Báo!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {   
            if (MessageBox.Show("Tạo Tài Khoản?","Thông Báo!",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (txtLogin.Text == "" || txtName.Text == "" || txtPass.Text == "" || txtPhone.Text == "" || txtRePass.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!", "Thông Báo!", MessageBoxButtons.OK);
                }
                else if (txtPass.Text != txtRePass.Text)
                    MessageBox.Show("Mật Khẩu Nhập Lại Không Đúng!", "Thông Báo!", MessageBoxButtons.OK);
                else
                    switch (user_Services.Check(txtLogin.Text, txtPhone.Text))
                    {
                        case 1:
                            User user = new User()
                            {
                                PermissionID = cbbPermission.SelectedValue.ToString(),
                                UserID = user_Services.AssignUserID(cbbPermission.SelectedValue.ToString()),
                                FullName = txtName.Text,
                                Sex = checkSex(),
                                BirthDay = dpBirthDay.Value,
                                Phone = txtPhone.Text,
                                DateCreated = DateTime.Today,
                                LoginName = txtLogin.Text,
                                Password = txtPass.Text
                            };
                            user_Services.AddUser(user);
                            MessageBox.Show("Tạo Tài Khoản Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                            Reset();
                            break;
                        case -1:
                            MessageBox.Show("Tên Đăng Nhập Không Hợp Lệ!", "Thông Báo!", MessageBoxButtons.OK);
                            break;
                        case -2:
                            MessageBox.Show("Số Điện Thoại Chỉ Nhập Số!", "Thông Báo!", MessageBoxButtons.OK);
                            break;
                        case -3:
                            MessageBox.Show("Số Điện Thoại Đã Tồn Tại!", "Thông Báo!", MessageBoxButtons.OK);
                            break;
                        case -4:
                            MessageBox.Show("Tên Đăng Nhập Đã Tồn Tại!", "Thông Báo!", MessageBoxButtons.OK);
                            break;
                    }
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            cbbPermission.DataSource = permission_Services.GetAll();
            cbbPermission.ValueMember = "PermissionID";
            cbbPermission.DisplayMember = "PermissionName";

            dpBirthDay.Value = DateTime.Today;
            rbFemale.Checked = true;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
