using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    public class RequestManager
    {
        Request obj = new Request();
        public int accept(string i_id)
        {
            return obj.accept(i_id);
            
        }
        public int reject(string i_id)
        {
            return obj.reject(i_id);
        }
        public int request(string m_id, string b_id)
        {
            return obj.request(m_id, b_id);
        }
        public DataTable display()
        {
            return obj.display();
        }
    }
}
