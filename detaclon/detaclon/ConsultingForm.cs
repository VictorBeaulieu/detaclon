using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
                    
                    Console.WriteLine("ADMIN");
                    
                    break;

                case "patron":
                    Console.WriteLine("patron");
                   
                    break;

                case "chef de magasin":

                    Console.WriteLine("Chef de magasin");
                    magasinToolStripMenuItem.Enabled = false;



                    break;

                case "employé":
                    Console.WriteLine("Employé");
                    
                    Console.WriteLine();
                    
                    magasinToolStripMenuItem.Enabled = false;
                    rayonToolStripMenuItem.Enabled = false;
                        
                        break;
            }

            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Program.run = false;
            this.Close();
        }


        private void deconnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.run = true;
            this.Close();
        }
    }
}
