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
        private readonly HoaDon_Services hoaDon_Services = new HoaDon_Services();
        private readonly PhieuKham_Services phieuKham_Services = new PhieuKham_Services();
        Bill bill;
        public frmHoaDon(int id)
        {
            InitializeComponent();
            this.bill = hoaDon_Services.GetByTID(id);
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            label3.Text = bill.BillID.ToString();
            label5.Text = bill.TicketID.ToString();

            label7.Text = bill.ExamDetail.ExamTicket.Customer.FullName;
            label9.Text = bill.InvoiceDate?.ToString("dd/MM/yyyy");

            label11.Text = $"Chẩn Đoán:{bill.ExamDetail.Treatment.Diagnose.DiagnosticContent}\n" +
                            $"Điều Trị: {bill.ExamDetail.Treatment.TreatmentContent}\n" +
                            $"Đơn Giá: {bill.ExamDetail.Treatment.UnitPrice}/{bill.ExamDetail.Treatment.Unit}\n" +
                            $"Số Lượng: {bill.ExamDetail.Quantity}";

            label13.Text = bill.ExamDetail.Total.ToString();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
