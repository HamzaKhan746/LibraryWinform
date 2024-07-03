using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management;

namespace SCHOOL_MANAGEMENT
{
    public class MemberManager
    {

       readonly Member obj = new Member();
        
        public int addmember(string name, string fname, string email, string cnic, double contact, string address, string gender, string password)
        {
            return obj.addmember(name,fname,email,cnic,contact,address,gender,password);
        }
        public int updatemember(int m_id, string name, string fname, string email, string cnic, double contact, string address)
        {
            return obj.updatemember(m_id,name, fname, email, cnic, contact, address);

        }
        public int deletemember(int d_id)
        {
           return obj.deletemember(d_id);

        }
    
        public DataTable display()
        {
            return obj.display();
        }

    }
}
