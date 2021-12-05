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
    public partial class AdminStudent : Form
    {
        public AdminStudent()
        {
            InitializeComponent();
        }
        MStudent stud = new MStudent();
        private void AdminStudent_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = stud.LoadGroup();
            comboBoxGroup.DisplayMember = "Name";
            comboBoxGroup.ValueMember = "idgroup";
            comboBoxGroup.DataSource = dt;
            UpdateTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim() == "")
                textBoxUserName.Text = textBoxName.Text.Trim();
            if (textBoxPassword.Text.Trim() == "")
                textBoxPassword.Text = textBoxSurname.Text.Trim();
            if (stud.InserStudent(textBoxName.Text.Trim(), textBoxSurname.Text.Trim(), textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim(), comboBoxGroup.SelectedValue))
            {
                MessageBox.Show("Succsessfully inserted");
            }
            else
            {
                MessageBox.Show("Error accured inserting");
            }
            UpdateTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (stud.DeleteStudent(textBoxName.Text.Trim(), textBoxSurname.Text.Trim(), textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Succsessfully deleted");
            }
            else
            {
                MessageBox.Show("Error accured deleting");
            }
            UpdateTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim() == "")
                textBoxUserName.Text = textBoxName.Text.Trim();
            if (textBoxPassword.Text.Trim() == "")
                textBoxPassword.Text = textBoxSurname.Text.Trim();
            dataGridViewSubject.DataSource = stud.Search(textBoxName.Text.Trim(), textBoxSurname.Text.Trim(), textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim());
        }

        private void buttonAllStudnets_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        public void UpdateTable()
        {
            dataGridViewSubject.DataSource = stud.GetTable();
        }
    }
}
