using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class ConnectDB
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=school; sslmode=none");

        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public void closeConect()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
