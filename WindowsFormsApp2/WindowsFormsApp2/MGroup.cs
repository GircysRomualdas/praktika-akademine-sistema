using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class MGroup
    {
        ConnectDB con = new ConnectDB();
        public DataTable LoadCourse()
        {
            MCourse cour = new MCourse();
            return cour.GetTable();
        }
        public bool InserGroup(string name, object course)
        {
            MySqlCommand com = new MySqlCommand("INSERT INTO `group` (`name`, `course_idCourse`) VALUES ('"+name+"', '"+course+"')", con.getConnection);
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
            MySqlCommand com = new MySqlCommand("DELETE FROM `group` WHERE name='"+name+"'", con.getConnection);
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
            MySqlCommand com = new MySqlCommand("SELECT `group`.`idgroup`, `group`.`name`, `course`.`Name` FROM `group` JOIN `course` WHERE `group`.`course_idCourse`=`course`.`idCourse` AND `group`.`name`='"+name+"'", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetCourseTable()
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `course`", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetTable()
        {
            MySqlCommand com = new MySqlCommand("SELECT `group`.`idgroup`, `group`.`name`, `course`.`Name` FROM `group` JOIN `course` WHERE `group`.`course_idCourse`=`course`.`idCourse`", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
