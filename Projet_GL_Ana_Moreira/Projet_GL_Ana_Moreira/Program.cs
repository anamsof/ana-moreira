using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        //    Form f = new PagePrincipale();
            Application.Run(new JournalDeBord());
        //    f.Visible = false;
         //   Form login =new PageLogin();
           // login.Show();
        }
    }
}
