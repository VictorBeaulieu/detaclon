using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using MessageBox = System.Windows.MessageBox;

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
                    display_store();
                    display_view_store();
                    break;

                case "patron":
                    Console.WriteLine("patron");
                    display_store();
                    display_view_store();
                    break;

                case "chef de magasin":
                    Console.WriteLine("Chef de magasin");                    
                    magasinToolStripMenuItem.Enabled = false;
                    utilisateurToolStripMenuItem.Enabled = false;
                    display_aisle();
                    display_view_aisle();
                    break;

                case "employé":                    
                    Console.WriteLine("Employé");                      
                    magasinToolStripMenuItem.Enabled = false;
                    rayonToolStripMenuItem.Enabled = false;
                    utilisateurToolStripMenuItem.Enabled = false;
                    display_product();
                    display_view_product();
                    break;
            }
            
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Program.run = false;
            this.Close();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_user();
            display_view_user();
        }
        private void deconnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.run = true;
            this.Close();
        }
        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_product();
            display_view_product();
        }
        private void rayonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_aisle();
            display_view_aisle();
            
        }
        private void magasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_store();
            display_view_store();
        }
        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = false;
        }



        private void display_product()
        {
            dataGridView.Visible = true;
            string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            SqlConnection connection;
            DataTable table = new DataTable();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Nom,Quantité FROM [PRODUCT]", connection))
            {
                connection.Open();

                adapter.Fill(table);
                connection.Close();
            }
            dataGridView.DataSource = table;
            
        }
        private void display_aisle()
        {
            dataGridView.Visible = true;
            string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            SqlConnection connection;
            DataTable table = new DataTable();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Magasin,Rayon,Produit FROM [AISLE]", connection))
            {
                connection.Open();

                adapter.Fill(table);
                connection.Close();
            }
            dataGridView.DataSource = table;
        }
        private void display_store()
        {
            dataGridView.Visible = true;
            string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            SqlConnection connection;
            DataTable table = new DataTable();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Ville,Nom,Prénom FROM [STORE]", connection))
            {
                connection.Open();

                adapter.Fill(table);
                connection.Close();
            }
            dataGridView.DataSource = table;
        }
        private void display_user()
        {
            dataGridView.Visible = true;
            string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            SqlConnection connection;
            DataTable table = new DataTable();
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT FirstName,LastName,Role FROM [USER]", connection))
            {
                connection.Open();

                adapter.Fill(table);
                connection.Close();
            }
            dataGridView.DataSource = table;
        }

        private void display_view_product()
        {
            btn_add_product.Visible = true;
            btn_add_aisle.Visible = false;
            btn_add_store.Visible = false;
            btn_add_user.Visible = false;

            btn_del_product.Visible = true;
            btn_del_aisle.Visible = false;
            btn_del_store.Visible = false;
            btn_del_user.Visible = false;
        }
        private void display_view_aisle()
        {
            btn_add_product.Visible = false;
            btn_add_aisle.Visible = true;
            btn_add_store.Visible = false;
            btn_add_user.Visible = false;

            btn_del_product.Visible = false;
            btn_del_aisle.Visible = true;
            btn_del_store.Visible = false;
            btn_del_user.Visible = false;
        }
        private void display_view_store()
        {
            btn_add_product.Visible = false;
            btn_add_aisle.Visible = false;
            btn_add_store.Visible = true;
            btn_add_user.Visible = false;

            btn_del_product.Visible = false;
            btn_del_aisle.Visible = false;
            btn_del_store.Visible = true;
            btn_del_user.Visible = false;
        }
        private void display_view_user()
        {
            btn_add_product.Visible = false;
            btn_add_aisle.Visible = false;
            btn_add_store.Visible = false;
            btn_add_user.Visible = true;

            btn_del_product.Visible = false;
            btn_del_aisle.Visible = false;
            btn_del_store.Visible = false;
            btn_del_user.Visible = true;
        }

        private void btn_del_product_Click(object sender, EventArgs e)
        {


            if (dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].HeaderText == "Nom")
            {
                
                
                string caption = "Suppresion de produit";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                string str = "Voulez supprimer le produit \"" + dataGridView.CurrentCell.Value.ToString() + "\" ?";
                MessageBoxResult result = MessageBox.Show(str,caption,button, icon);
                switch (result)
                {
                    
                    case MessageBoxResult.Yes:
                        //DELETE FROM[PRODUCT] WHERE Nom = 'Tomate'

                        string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
                        string query = "DELETE FROM[PRODUCT] WHERE Nom = '"+@dataGridView.CurrentCell.Value.ToString()+"'";

                        SqlConnection connection;
                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            Console.WriteLine(query);
                            //cmd.Parameters.AddWithValue("@Nom", dataGridView.CurrentCell.Value.ToString());
                            connection.Open();
                            cmd.ExecuteScalar();
                            connection.Close();
                        }
                        display_product();
                        break;
                    case MessageBoxResult.No:
                        break;
                    default:
                        break;
                }

            }
        }
        private void btn_del_store_Click(object sender, EventArgs e)
        {
            if (dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].HeaderText == "Ville")
            {
                string caption = "Suppresion de magasin";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                string str = "Voulez supprimer le magasin \"" + dataGridView.CurrentCell.Value.ToString() + "\" ?";
                MessageBoxResult result = MessageBox.Show(str, caption, button, icon);
                switch (result)
                {

                    case MessageBoxResult.Yes:
                        //DELETE FROM[PRODUCT] WHERE Nom = 'Tomate'

                        string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
                        string query = "DELETE FROM [STORE] WHERE[Ville] = '" + @dataGridView.CurrentCell.Value.ToString() + "'";
                        
                        SqlConnection connection;
                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            Console.WriteLine(query);
                            connection.Open();
                            cmd.ExecuteScalar();
                            connection.Close();
                        }
                        display_store();
                        break;
                    case MessageBoxResult.No:
                        break;
                    default:
                        break;
                }
            }
        }
        private void btn_del_aisle_Click(object sender, EventArgs e)
        {

        }
        private void btn_del_user_Click(object sender, EventArgs e)
        {
            if (dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].HeaderText == "FirstName")
            {
                string caption = "Suppresion d'utiliateur";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                string str = "Voulez supprimer l'utilisateur \"" + dataGridView.CurrentCell.Value.ToString() + "\" ?";
                MessageBoxResult result = MessageBox.Show(str, caption, button, icon);
                switch (result)
                {

                    case MessageBoxResult.Yes:


                        string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
                        string query = "DELETE FROM [USER] WHERE[FirstName] = '" + @dataGridView.CurrentCell.Value.ToString() + "'";

                        SqlConnection connection;
                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            Console.WriteLine(query);
                            connection.Open();
                            cmd.ExecuteScalar();
                            connection.Close();
                        }
                        display_user();
                        break;
                    case MessageBoxResult.No:
                        break;
                    default:
                        break;
                }
            }
            if (dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].HeaderText == "LastName")
            {
                string caption = "Suppresion d'utiliateur";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                string str = "Voulez supprimer l'utilisateur \"" + dataGridView.CurrentCell.Value.ToString() + "\" ?";
                MessageBoxResult result = MessageBox.Show(str, caption, button, icon);
                switch (result)
                {

                    case MessageBoxResult.Yes:


                        string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
                        string query = "DELETE FROM [USER] WHERE[LastName] = '" + @dataGridView.CurrentCell.Value.ToString() + "'";

                        SqlConnection connection;
                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            Console.WriteLine(query);
                            connection.Open();
                            cmd.ExecuteScalar();
                            connection.Close();
                        }
                        display_user();
                        break;
                    case MessageBoxResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        private void btn_add_aisle_Click(object sender, EventArgs e)
        {
            display_aisle();
        }
        private void btn_add_product_Click(object sender, EventArgs e)
        {
            AddingProductForm form = new AddingProductForm();
            form.FormClosed += new FormClosedEventHandler(AddingProductForm_FormClosed);
            form.Show();
        }
        private void btn_add_store_Click(object sender, EventArgs e)
        {
            AddingStoreForm form = new AddingStoreForm();
            form.FormClosed += new FormClosedEventHandler(AddingStoreForm_FormClosed);
            form.Show();
        }
        private void btn_add_user_Click(object sender, EventArgs e)
        {
            AddingUserForm form = new AddingUserForm();
            form.FormClosed += new FormClosedEventHandler(AddingUserForm_FormClosed);
            form.Show();
        }




        void AddingProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            display_product();
        }
        void AddingStoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            display_store();
        }
        void AddingUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            display_user();
        }

        
    }
}

