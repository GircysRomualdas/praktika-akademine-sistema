using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGroup f = new AdminGroup();
            f.ShowDialog();
            f = null;
            this.Show(); // close
        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSubject f = new AdminSubject();
            f.ShowDialog();
            f = null;
            this.Show(); // close
        }

        private void buttonProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProfessor f = new AdminProfessor();
            f.ShowDialog();
            f = null;
            this.Show(); // close
        }

        private void Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminStudent f = new AdminStudent();
            f.ShowDialog();
            f = null;
            this.Show(); // close
        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course f = new Course();
            f.ShowDialog();
            f = null;
            this.Show(); // close
        }
    }
}
