using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detaclon
{
    public partial class ConsultingForm : Form
    {
        public ConsultingForm()
        {
            InitializeComponent();
            switch (Program.user_role)
            {
                case "ADMIN":

                    break;

                case "Patron":

                    break;

                case "Employé":
                    
                    break;

                case "Chef de magasin":
                   
                    break;


            }
        }

    }
}
