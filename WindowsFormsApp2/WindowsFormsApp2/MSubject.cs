using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MSubject
    {
        ConnectDB con = new ConnectDB();
        public DataTable LoadCourse()
        {
            MCourse cour = new MCourse();
            return cour.GetTable();
        }
        public DataTable LoadProfessor()    // reikes prijungti kai sudar. Prof.
        {
            MProfessor pro = new MProfessor();
            return pro.GetTable();
        }
        public DataTable GetTable()
        {
            MySqlCommand com = new MySqlCommand("SELECT `subject`.`idsubject`, `subject`.`name`, `course`.`Name`, `profesor`.`name`, `profesor`.`surname`, `profesor`.`idprofesor` FROM `subject` JOIN `course` ON `subject`.`course_idCourse`=`course`.`idCourse` JOIN `profesor` ON `subject`.`profesor_idprofesor`=`profesor`.`idprofesor` ", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool InserSubject(string name, object course, object professor)
        {
            MySqlCommand com = new MySqlCommand("INSERT INTO `subject`(`name`, `course_idCourse`, `profesor_idprofesor`) VALUES ('" + name + "','" + course + "','" + professor + "')", con.getConnection);
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
        public bool DeleteSubject(string name)
        {
            MySqlCommand com = new MySqlCommand("DELETE FROM `subject` WHERE name='" + name + "'", con.getConnection);
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
            MySqlCommand com = new MySqlCommand("SELECT * FROM `subject` WHERE name='" + name + "'", con.getConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
