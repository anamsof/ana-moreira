using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_GL_Ana_Moreira
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            // SINGLETON
           // MySingleton mySingleton = MySingleton.Instance;
           // mySingleton.DoSomething();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
     
            Application.Run(new PagePrincipale());
        
        }
    }
   /* public class MySingleton
    {
        private static MySingleton instance = null;
        private MySingleton() { }

        public static MySingleton Instance {
            get
            {
                if (instance == null )
                {
                    instance = new MySingleton(); 
                }
                 return instance; 
            } 
        }
        public void DoSomething(){ // show }
    }
}
   */