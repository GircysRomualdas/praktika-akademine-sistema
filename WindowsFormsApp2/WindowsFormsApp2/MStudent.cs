using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class MStudent
    {
        ConnectDB con = new ConnectDB();
        public DataTable LoadGroup()
        {
            MGroup grou = new MGroup();
            return grou.GetTable();
        }
        public bool InserStudent(string name, string surname, string username, string password, object group)
        {
            MySqlCommand com = new MySqlCommand("INSERT INTO `student`(`name`, `surname`, `username`, `password`, `group_idgroup`) VALUES ('" + name + "','" + surname + "','" + username + "','" + password + "','" + group + "')", con.getConnection);
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
        public bool DeleteStudent(string name, string surname, string username, string password)
        {
            MySqlCommand com = new MySqlCommand("DELETE FROM `student` WHERE name='" + name + "' AND surname='" + surname + "' AND username='" + username + "' AND password='" + password + "'", con.getConnection);
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
            MySqlCommand com = new MySqlCommand("SELECT * FROM `student` WHERE name='" + name + "' OR surname='" + surname + "' OR username='" + username + "' OR password='" + password + "'", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetTable()
        {
            MySqlCommand com = new MySqlCommand("SELECT student.idstudent, student.name, student.surname, student.username, student.password, `group`.name FROM student JOIN `group` ON student.group_idgroup = `group`.`idgroup`", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
