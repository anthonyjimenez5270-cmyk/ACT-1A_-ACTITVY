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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList();
            studentList.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
