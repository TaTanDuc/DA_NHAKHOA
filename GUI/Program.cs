using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
/*
            frmDangNhap dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmTrangChu_new());
                dangNhap.Close();
            }
<<<<<<< HEAD
*/
           Application.Run(new frmQLVatLieu());
=======
>>>>>>> 4208c02807bcb99619b007c4c1f1660ef7b75f18
        }
    }
}
