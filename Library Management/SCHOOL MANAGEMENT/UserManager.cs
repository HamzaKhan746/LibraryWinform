using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    public class UserManager
    {
        Request obj = new Request();
        Issue_return obj1 = new Issue_return();
        public int request(string m_id, string b_id)
        {
            return obj.request(m_id, b_id);
        }

        public string getb_name(string id)
        {
         return obj1.getb_name(id);
        }
      
        public string getb_id(string name)
        {
            return obj1.getb_id(name);
        }

    }
}
