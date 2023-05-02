using BLL;
using GUI.Báo_cáo_thống_kê;
using GUI.Chức_năng;
using GUI.Hệ_thống;
using GUI.Hoá_đơn;
using GUI.Quản_lý;
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
            Application.Run(new LoginForm());
        }
    }
}
