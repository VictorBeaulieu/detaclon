﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;

namespace detaclon
{
    public partial class LoginForm : Form
    {

        SqlConnection connection;
        private string connectionString;
        public LoginForm()
        {
            InitializeComponent();
            login_PWD.PasswordChar = '*';
            connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            Program.login_succeed = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Program.run = false;
            this.Close();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [User]", connection))
            {
                connection.Open();
                DataTable userTable = new DataTable();
                adapter.Fill(userTable);
                connection.Close();

                DataRow[] rows = userTable.Select();

                
                
                foreach (DataRow row in rows)
                {
                    
                    string id = row.Field<string>("LoginID");
                    string pwd = row.Field<string>("LoginPWD");
                    if (login_ID.Text.Equals(id) && login_PWD.Text.Equals(pwd))
                    {
                        Program.login_succeed = true;
                        Program.user_role = row.Field<string>("Role");
                        Console.WriteLine(Program.user_role);
                        break;
                    }
                }



            }
            if (Program.login_succeed == true)
            {
                Program.run = true;
                this.Close();
            }
        }
        

    }
}
