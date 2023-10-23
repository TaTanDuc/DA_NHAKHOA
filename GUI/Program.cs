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

            frmDangNhap dangNhap = new frmDangNhap();
<<<<<<< HEAD
            frmTrangChu_new trangChu_New = new frmTrangChu_new();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(trangChu_New);
                dangNhap.Close();
            }
=======
            Application.Run(new frmDieuTri());
            //if (dangNhap.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new frmTrangChu_new());
            //    dangNhap.Close();
            //}
           
>>>>>>> 810a416bec068367faf13dca029641ea83405b73
        }
    }
}
