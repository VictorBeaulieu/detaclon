using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detaclon
{

    static class Program
    {
        static public bool login_succeed = false;
        static public bool run = false;
        static public string user_role = "";
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]

        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            do
            {
                Application.Run(new LoginForm());
                if (login_succeed) Application.Run(new ConsultingForm());
            }
            while (run);
        }
    }
}
