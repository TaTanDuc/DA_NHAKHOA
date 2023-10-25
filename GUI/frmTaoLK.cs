using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTaoLK : Form
    {
        private readonly DichVu_Services dichVu_Services = new DichVu_Services();
        private readonly BenhNhanServices benhNhanServices = new BenhNhanServices();
        private readonly PhieuKham_Services phieuKham_Services = new PhieuKham_Services();
        private readonly HoaDon_Services hoaDon_Services = new HoaDon_Services();
        public frmTaoLK()
        {
            InitializeComponent();
        }

        public string GioiTinh()
        {
            if (guna2CustomRadioButton1.Checked == true)
                return "m";
            else
                return "f";
        }

        public void CbxTreatment()
        {
            guna2ComboBox2.DataSource = dichVu_Services.GetTrD(guna2ComboBox1.SelectedIndex + 1);
            guna2ComboBox2.ValueMember = "TreatmentID";
            guna2ComboBox2.DisplayMember = "TreatmentContent";
        }

        private void frmNoiDungKham_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.DataSource = dichVu_Services.GetAllDiagnose();
            guna2ComboBox1.ValueMember = "DiagnoseID";
            guna2ComboBox1.DisplayMember = "DiagnosticContent";
            CbxTreatment();

            guna2CustomRadioButton1.Checked = true;
            label5.Text = phieuKham_Services.GetTicketID().ToString();
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "" || guna2TextBox5.Text == "" || guna2TextBox6.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Thông Báo",MessageBoxButtons.OK);
                return;
            }
                
            if (benhNhanServices.FindByID(guna2TextBox5.Text) == null)
                benhNhanServices.AddOrUpdateDuc(guna2TextBox5.Text,guna2TextBox1.Text,GioiTinh(),guna2DateTimePicker2.Value,guna2TextBox3.Text);
            if (MessageBox.Show("Bạn có muốn tạo?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                phieuKham_Services.SaveDetails(guna2TextBox5.Text,guna2DateTimePicker2.Value, guna2ComboBox1.SelectedIndex + 1, guna2ComboBox2.SelectedIndex + 1, Convert.ToInt32(guna2TextBox6.Text),Convert.ToInt32(label9.Text));
                hoaDon_Services.Add(guna2DateTimePicker2.Value);
            }
        }

        private void guna2ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            CbxTreatment();
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Enabled = false;
            label5.Text = phieuKham_Services.GetTicketID().ToString();
            var customer = benhNhanServices.FindByID(guna2TextBox5.Text);
            if ( customer != null)
            {
                guna2TextBox1.Text = customer.FullName;
                
                if ( customer.Sex.Equals("m")) 
                {
                    guna2CustomRadioButton1.Checked = true;
                }
                if (customer.Sex.Equals("f"))
                {
                    guna2CustomRadioButton2.Checked = true;
                }

                guna2DateTimePicker1.Value = customer.BirthDay.Value;
                guna2TextBox3.Text = customer.Phone;
            }
        }

        private void guna2ComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            var price = dichVu_Services.GetPrice(guna2ComboBox1.SelectedIndex + 1, guna2ComboBox2.SelectedIndex + 1);
            if ( price != null )
            {
                label6.Text = price.UnitPrice.ToString();
                label7.Text = price.Unit.ToString();
            }
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox6.Text == "")
                return;
            else label9.Text = (Convert.ToInt32(label6.Text) * Convert.ToInt32(guna2TextBox6.Text)).ToString();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
