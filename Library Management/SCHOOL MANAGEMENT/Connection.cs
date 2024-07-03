
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    class Connection
    {
        string connectiongstring = string.Empty;
        SqlConnection con;

        public Connection()
        {
            connectiongstring = @"Data Source=DESKTOP-ABS14OI;Initial Catalog=library_management;Integrated Security=True";
        }
        public SqlConnection connect()
        {
            con = new SqlConnection(connectiongstring);
            con.Open();
            return con;
        }
        public void close()
        {
            con.Close();
        }
    }
}