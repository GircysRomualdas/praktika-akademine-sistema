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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        MCourse cou = new MCourse();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (cou.InserCourse(textBoxName.Text.Trim()))
            {
                MessageBox.Show("Succsessfully inserted");
            }
            else
            {
                MessageBox.Show("Error accured inserting course");
            }
            UpdateTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (cou.DeleteCourse(textBoxName.Text.Trim()))
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
            dataGridViewCourse.DataSource = cou.Search(textBoxName.Text.Trim());
        }

        private void buttonAllCorse_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewCourse.DataSource = cou.GetTable();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
