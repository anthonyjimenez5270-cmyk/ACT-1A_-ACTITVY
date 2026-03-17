using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_1A_DATABASE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get username and password from textbox, remove extra spaces
            string username = txtUsername.Text.Trim(); //Trim() unhackable
            string password = txtPassword.Text.Trim();
            //Check if username or password is ewmpty
            if (username == "" || password == "") 
            {
                MessageBox.Show("Please enter username and password");
                return; // stop the login process/program
            }
            //call db connection string
            DBConnect dB = new DBConnect();

            try
            {
                dB.Open(); // open Database connection
                //SQL querry to count matching username and password
                string query = "SELECT COUNT(*) FROM users WHERE " +
                    "username=@username AND password=@password";

                //Create MYQL command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, dB.Connection);
                //Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                //Exection query and get results
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1) 
                {
                    //if 1 record found , login sucesssful
                    MessageBox.Show("Login Sucesscful");
                    //Open Dashboard
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    // no Match found
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                //show error message if somthing goes wrong
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                dB.Close(); //close Database connection
            }
        }
    }
}
