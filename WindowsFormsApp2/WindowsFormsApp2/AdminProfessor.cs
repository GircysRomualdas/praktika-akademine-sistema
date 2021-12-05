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
    public partial class AdminProfessor : Form
    {
        public AdminProfessor()
        {
            InitializeComponent();
        }
        MProfessor pro = new MProfessor();
        private void AdminProfessor_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim() == "")
                textBoxUserName.Text = textBoxName.Text.Trim();
            if (textBoxPassword.Text.Trim() == "")
                textBoxPassword.Text = textBoxSurname.Text.Trim();

            if (pro.InserProfessorp(textBoxName.Text.Trim(),textBoxSurname.Text.Trim(),textBoxUserName.Text.Trim(),textBoxPassword.Text.Trim()))
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
            if (pro.DeleteProfessorp(textBoxName.Text.Trim(), textBoxSurname.Text.Trim(), textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim()))
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
            dataGridViewSubject.DataSource = pro.Search(textBoxName.Text.Trim(), textBoxSurname.Text.Trim(), textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim());
        }

        private void buttonAllSubject_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        public void UpdateTable()
        {
            dataGridViewSubject.DataSource = pro.GetTable();
        }
    }
}
