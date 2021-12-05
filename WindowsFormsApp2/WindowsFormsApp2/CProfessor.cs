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
    class CProfessor
    {
        ConnectDB con = new ConnectDB();
        public DataTable GetSubject(DataTable prof)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM subject WHERE `profesor_idprofesor`='"+prof.Rows[0]["idprofesor"].ToString()+"'",con.getConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetGroup(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `group`.`idgroup`, `group`.`name`, `subject`.`course_idCourse` FROM `group` JOIN `subject` WHERE `group`.`course_idCourse`=`subject`.`course_idCourse` AND `subject`.`idsubject`='"+id+"'", con.getConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetStudent(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `student`.`idstudent`, `student`.`name`, `student`.`surname`, `group`.`idgroup` FROM `student` JOIN `group` WHERE `student`.`group_idgroup`=`group`.`idgroup` AND `group`.`idgroup`='" + id + "'", con.getConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetGrade(string subId, string stuId)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `grade` WHERE subject_idsubject='"+subId+"' AND student_idstudent='"+stuId+"'", con.getConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool InserGrade(string grade, string type, string subject_idsubject, string student_idstudent)
        {
            MySqlCommand com = new MySqlCommand("INSERT INTO `grade`(`grade`, `type`, `subject_idsubject`, `student_idstudent`) VALUES ('"+ grade + "','"+ type + "','"+ subject_idsubject + "','"+ student_idstudent + "')", con.getConnection);
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
        public bool EditGrade(string idG, string grade, string type, string subject_idsubject, string student_idstudent)
        {
            MySqlCommand com = new MySqlCommand("UPDATE `grade` SET `grade`='"+grade+"',`type`='"+type+"',`subject_idsubject`='"+subject_idsubject+"',`student_idstudent`='"+student_idstudent+"' WHERE `idgrade`='"+idG+"'", con.getConnection);
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
    }
}
