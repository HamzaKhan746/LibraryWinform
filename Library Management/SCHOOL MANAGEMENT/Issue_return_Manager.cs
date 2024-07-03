using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    internal class Issue_return_Manager
    {
        Issue_return obj = new Issue_return();
        public string getb_name(string id)
        {
            return obj.getb_name(id);
      
        }
        public string getm_name(string id)
        {
           return obj.getm_name(id);
        }

        public string getb_id(string name)
        {
          return obj.getb_id(name);
        }
        public string getm_id(string name)
        {
           return obj.getm_id(name);
        }

        public int issue(string m_id, string b_id, string m_name, string b_name)
        {
            return obj.issue(m_id, b_id, m_name, b_name);
        }
        public int getinc(string b_id)
        {
           return obj.getinc(b_id);
        }
        public int getdec(string b_id)
        {
           return obj.getdec(b_id);
        }
        public int returno(string m_id, string b_id)
        {
          return obj.returno(m_id, b_id);
        }
        public DataTable displayissue()
        {
           return obj.displayissue();
        }
        public DataTable displayreturn()
        {
            return obj.displayreturn();
        }
    }
}
