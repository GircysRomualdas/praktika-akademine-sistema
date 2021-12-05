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
    public partial class AdminSubject : Form
    {
        public AdminSubject()
        {
            InitializeComponent();
        }
        MSubject sub = new MSubject();
        private void AdminSubject_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sub.LoadCourse();
            comboBoxCourse.DisplayMember = "Name";
            comboBoxCourse.ValueMember = "idCourse";
            comboBoxCourse.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2 = sub.LoadProfessor();
            comboBoxProfessor.ValueMember = "idprofesor";
            dt2.Columns.Add("main", typeof(string), "name+' '+surname+' ID'+idprofesor");
            comboBoxProfessor.DisplayMember = "main";
            comboBoxProfessor.DataSource = dt2;
            UpdateTable();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (sub.InserSubject(textBoxName.Text.Trim(), comboBoxCourse.SelectedValue, comboBoxProfessor.SelectedValue))
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
            if (sub.DeleteSubject(textBoxName.Text.Trim()))
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
            dataGridViewSubject.DataSource = sub.Search(textBoxName.Text.Trim());
        }

        private void buttonAllSubject_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        public void UpdateTable()
        {
            dataGridViewSubject.DataSource = sub.GetTable();
        }
    }
}
