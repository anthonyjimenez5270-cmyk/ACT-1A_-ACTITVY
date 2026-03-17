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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbSection.Items.AddRange(new string[] { "1A", "1B", "1C", "1D" });

            cmbCourse.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string course = cmbCourse.SelectedItem?.ToString();
            string section = cmbSection.SelectedItem?.ToString();
            int age;

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty
                (lastname) ||
                string.IsNullOrEmpty(course) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all Fields");
                return;
            }
            if (!int.TryParse(txtAge.Text.Trim(), out age));
            {
                
                MessageBox.Show("Please enter a valid age");
                return;
            }
            
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = "INSERT INTO students (firstname, lastname, course, section, age)" +
                "VALUES (@firstname, @lastname, @course, @section, @age)";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@age", age);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added succssfully!");
                txtFirstName.Clear();
                txtLastName.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtAge.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { db.Close(); }
        }

    }
}
