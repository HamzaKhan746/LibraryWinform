using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    public class LoginManager
    {
        Login ob = new Login();
        public int verify(string n, string pass)
        {
           return ob.verify(n, pass);
        }
    }
}
