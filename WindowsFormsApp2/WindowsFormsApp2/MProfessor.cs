using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class MProfessor
    {
        ConnectDB con = new ConnectDB();
        public bool InserProfessorp(string name, string surname, string username, string password)
        {
            MySqlCommand com = new MySqlCommand("INSERT INTO `profesor`(`name`, `surname`, `username`, `password`) VALUES ('"+name+"','"+surname+"','"+username+"','"+password+"')", con.getConnection);
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
        public bool DeleteProfessorp(string name, string surname, string username, string password)
        {
            MySqlCommand com = new MySqlCommand("DELETE FROM `profesor` WHERE name='"+name+"' AND surname='"+surname+"' AND username='"+username+"' AND password='"+password+"'", con.getConnection);
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
        public DataTable Search(string name, string surname, string username, string password)
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `profesor` WHERE name='" + name + "' AND surname='" + surname + "' AND username='" + username + "' AND password='" + password + "'", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetTable()
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `profesor`", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
