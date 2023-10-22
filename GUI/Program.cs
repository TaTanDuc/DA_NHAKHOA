using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD

            //frmDangNhap dangNhap = new frmDangNhap();

            //if (dangNhap.ShowDialog() == DialogResult.OK)
            //{
                Application.Run(new frmTrangChu_new());
            //   dangNhap.Close();
            //}
=======
            Application.Run(new FrmQLDichVu());
>>>>>>> 0d6a799df4934247c5ceefbfc617505ee26366cd
        }
    }
}
