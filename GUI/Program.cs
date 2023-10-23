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
            frmTrangChu_new trangChu_New = new frmTrangChu_new();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(trangChu_New);
                dangNhap.Close();
            }
        }
    }
}
