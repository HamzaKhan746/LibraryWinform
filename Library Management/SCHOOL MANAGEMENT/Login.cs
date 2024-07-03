using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    public class Login
    {
        Connection con = new Connection();
        public int verify(string n, string pass)
        {
            SqlCommand cmd = new SqlCommand("Select name from member where name ='" + n + "' and password = '"+pass+"'", con.connect());
            string name = Convert.ToString(cmd.ExecuteScalar());
            SqlCommand cmd1 = new SqlCommand("Select password from member where name ='" + n + "' and password = '" + pass + "'", con.connect());
            string password = Convert.ToString(cmd1.ExecuteScalar());
            if (name == n && password == pass)
            {
                return 1;
            }
            else
            {
                return -1;
            }
           
        }
        
    }
}
