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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        LLogIn llop = new LLogIn();
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (textBoxUserName.Text == "admin" && textBoxPassword.Text == "admin")
            {
                Admin f = new Admin();
                f.ShowDialog();
                f = null;
            }
            else
            {
                if(checkBoxStudent.Checked == true)
                {
                    if(llop.FindStudent(textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim()))
                    {
                        DataTable dt = new DataTable();
                        dt = llop.StudTable(textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim(), true);
                        if(dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Succsessfully LogIn");
                            Student f = new Student(dt);
                            f.ShowDialog();
                            f = null;
                        }
                        else
                            MessageBox.Show("Error Bed Username or Password");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else if (checkBoxProfesor.Checked == true)
                {
                    if(llop.FindProfessor(textBoxUserName.Text, textBoxPassword.Text))
                    {
                        DataTable dt = new DataTable();
                        dt = llop.StudTable(textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim(), false);
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Succsessfully LogIn");
                            Professor f = new Professor(dt);
                            f.ShowDialog();
                            f = null;
                        }
                        else
                            MessageBox.Show("Error Bed Username or Password");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            this.Show(); // close
        }

        private void checkBoxStudent_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxProfesor.Checked = false;
        }

        private void checkBoxProfesor_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxStudent.Checked = false;
        }
    }
}
