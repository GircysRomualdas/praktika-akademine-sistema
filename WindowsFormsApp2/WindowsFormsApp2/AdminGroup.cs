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
    public partial class AdminGroup : Form
    {
        public AdminGroup()
        {
            InitializeComponent();
        }
        MGroup grou = new MGroup();
        private void AdminGroup_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = grou.LoadCourse();
            comboBoxCourse.DisplayMember = "Name";
            comboBoxCourse.ValueMember = "idCourse";
            comboBoxCourse.DataSource = dt;
            UpdateTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (grou.InserGroup(textBoxName.Text.Trim(), comboBoxCourse.SelectedValue))
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
            if (grou.DeleteCourse(textBoxName.Text.Trim()))
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
            dataGridViewGroup.DataSource = grou.Search(textBoxName.Text.Trim());
        }

        private void buttonAllGroup_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        public void UpdateTable()
        {
            dataGridViewGroup.DataSource = grou.GetTable();
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
