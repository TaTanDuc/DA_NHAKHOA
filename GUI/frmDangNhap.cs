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
    public partial class frmDangNhap : Form
    {
        private readonly LogIn_Services logIn_Services = new LogIn_Services();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void tolstxtTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            gntxtTaiKhoan.Focus();
        }

        private void gnbtnDangNhap_Click(object sender, EventArgs e)
        {
            var temp = logIn_Services.LogIn(gntxtTaiKhoan.Text, gntxtMatKhau.Text);
            switch (temp)
            {
                case 1:
                    this.DialogResult = DialogResult.OK;
                    break;
                case 0:
                    MessageBox.Show("Sai thông tin đăng nhập!", "Lỗi");
                    gntxtTaiKhoan.Focus();
                    break;
            }
        }

        private void gnbtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
