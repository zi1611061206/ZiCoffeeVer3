using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCoffe.DAO;
using ZiCoffe.GUI;

namespace ZiCoffe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (AccountDAO.Instance.CountAccount() > 0)
            {
                Application.Run(new formLogin());
            }
            else
            {
                Application.Run(new formFirstUse());
            }
        }
    }
}
