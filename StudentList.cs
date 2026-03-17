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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            Loadstudent();
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbSection.Items.AddRange(new string[] { "1A", "1B", "1C", "1D" });

            cmbCourse.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;

        }

        private void Loadstudent()
        {
            string search = txtSearch.Text.Trim();

            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"SELECT id, firstname, lastname, course, section, age
                FROM student
                WHERE firstname LIKE @search
                OR lastname Like @search
                OR course LIKE @search
                OR section LIKE @search";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();
                adapter.Fill(table);
                dgvStudents.DataSource = table;

                dgvStudents.Columns["id"].HeaderText = "Student ID";
                dgvStudents.Columns["firstname"].HeaderText = "First Name";
                dgvStudents.Columns["lastname"].HeaderText = "Last Name";
                dgvStudents.Columns["course"].HeaderText = "Course";
                dgvStudents.Columns["section"].HeaderText = "Section";
                dgvStudents.Columns["age"].HeaderText = "Age";

                adapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }


        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtID.Text = row.Cells["id"].Value.ToString();
                txtFirstname.Text = row.Cells["firstname"].Value.ToString();
                txtLastname.Text = row.Cells["lastname"].Value.ToString();
                cmbCourse.Text = row.Cells["course"].Value.ToString();
                cmbSection.Text = row.Cells["section"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
            }

            string firstname = txtFirstname.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            string course = cmbCourse.SelectedIndex.ToString();
            string section = cmbSection.SelectedIndex.ToString();
            int age;
            int ID;

            if (!int.TryParse(txtID.Text, out ID))
            {
                MessageBox.Show("Please Click Record to Update");
            }

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(course) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all Fields");
                return;
            }
            if (!int.TryParse(txtAge.Text.Trim(), out age)) ;
            {

                MessageBox.Show("Please enter a valid age");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = @"UPDATE student
                SET firstname=@firstname,
                    lastname=@lastname,
                    course=@course,
                    section=@section,
                    age=@age
                WHERE id=@id";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastname);
                    cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                    cmd.Parameters.AddWithValue("@section", cmbSection.Text);
                    cmd.Parameters.AddWithValue("@age", cmbSection.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successfully!");

                    txtFirstname.Clear();
                    txtAge.Clear();
                    txtID.Clear();
                    txtLastname.Clear();
                    cmbCourse.SelectedIndex = -1;
                    cmbSection.SelectedIndex = -1;

                    Loadstudent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR;" + ex.Message);
            }
            finally { db.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID;

            if (!int.TryParse(txtID.Text, out ID))
            {
                MessageBox.Show("Please select a student first");
                return;
            }
            DialogResult result = MessageBox.Show("Are you Sure you want to delete this student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "DELETE FROM student WHERE id=@id";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@id", ID);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Student deleted successfully!");

                txtID.Clear();
                txtLastname.Clear();
                txtFirstname.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtAge.Clear();
                Loadstudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally { db.Close(); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Loadstudent();
        }
    }
}
