using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp2
{
    class MCourse
    {
        ConnectDB con = new ConnectDB();
        public bool InserCourse(string name)
        {
            MySqlCommand com = new MySqlCommand("INSERT INTO `course` (`Name`) VALUES ('"+name+"')",con.getConnection);
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
        public bool DeleteCourse(string name)
        {
            MySqlCommand com = new MySqlCommand("DELETE FROM course WHERE name='"+name+"'", con.getConnection);
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
        public DataTable Search(string name)
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM course WHERE Name='"+name+"'", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetTable()
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM course", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
