using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class CStudent
    {
        ConnectDB con = new ConnectDB();
        public DataTable GetSubject(DataTable prof)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `student`.idstudent, `group`.idgroup, `subject`.idsubject, `subject`.name FROM `student` JOIN `group` ON `student`.group_idgroup=`group`.idgroup JOIN `subject` ON `subject`.course_idCourse=`group`.course_idCourse AND `student`.idstudent='" + prof.Rows[0]["idstudent"].ToString() + "'", con.getConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetGrade(DataTable prof, string a)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `grade` WHERE grade.student_idstudent = '"+prof.Rows[0]["idstudent"].ToString() + "' AND grade.subject_idsubject ='"+ a + "'", con.getConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
