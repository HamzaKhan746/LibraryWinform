using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    public class Detail
    {
        public int GetMember()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Select Count(m_id) from Member", con.connect());
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            return a;
        }
        public int GetBook()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Select Count(b_id) from Books", con.connect());
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            return a;
        }
        public int GetIssue()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Select Count(i_id) from issue_return where s_id ='" + 1 + "'", con.connect());
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            return a;
        }
        public int GetCategory()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Select Count(c_id) from category", con.connect());
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            return a;
        }
        public int GetReturn()
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Select Count(i_id) from issue_return where s_id ='" + 2 + "'", con.connect());
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            return a;
        }

    }
}
