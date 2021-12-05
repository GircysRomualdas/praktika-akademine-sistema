using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class LLogIn
    {
        ConnectDB con = new ConnectDB();
        public bool FindStudent(string username, string password)
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `student` WHERE username='"+username+"' AND password='"+password+"'", con.getConnection);
            con.openConnect();
            try
            {
                com.ExecuteNonQuery();
                con.closeConect();
                return true;
            }
            catch
            {
                con.closeConect();
                return false;
            }
        }
        public bool FindProfessor(string username, string password)
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `profesor` WHERE username='" + username + "' AND password='" + password + "'", con.getConnection);
            con.openConnect();
            try
            {
                com.ExecuteNonQuery();
                con.closeConect();
                return true;
            }
            catch
            {
                con.closeConect();
                return false;
            }
        }
        public DataTable StudTable(string username, string password, bool pas)
        {
            string tab;
            if (pas)
                tab = "student";
            else
                tab = "profesor";
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `"+tab+ "` WHERE username='" + username + "' AND password='" + password + "'", con.getConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
