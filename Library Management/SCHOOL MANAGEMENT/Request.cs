using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    public class Request
    {
        string cmdtext;
        public int accept(string i_id)
        {
            Connection con = new Connection();
            cmdtext = "update issue_return set issuedate = '" + DateTime.Now + "',s_id = '" + 1 + "' where i_id = '" + i_id + "'";
            SqlCommand com = new SqlCommand(cmdtext, con.connect());
            return com.ExecuteNonQuery();
        }
        public int reject(string i_id)
        {
            Connection con = new Connection();
            cmdtext = "delete from issue_return where i_id = '" + i_id + "'";
            SqlCommand com = new SqlCommand(cmdtext,con.connect());
            return com.ExecuteNonQuery();
        }
        public int request(string m_id, string b_id)
        {
            Connection con = new Connection();
            cmdtext = "Insert into issue_return (m_id,b_id,s_id)values('" + m_id + "','" + b_id + "','" + 3 + "')";
            SqlCommand cmd = new SqlCommand(cmdtext, con.connect());
            int a1 = cmd.ExecuteNonQuery();
            return a1;
        }
        public DataTable display()
        {
            Connection con = new Connection();
            DataTable dt = new DataTable();
            cmdtext = "SELECT i_id,member.m_id,member.name,books.b_id,books.name,status.status FROM issue_return INNER JOIN member ON member.m_id = issue_return.m_id INNER JOIN books ON books.b_id = issue_return.b_id INNER JOIN status on status.s_id=issue_return.s_id where issue_return.s_id = '" + 3 + "'";
            SqlDataAdapter sda = new SqlDataAdapter(cmdtext, con.connect());
            sda.Fill(dt);
            con.close();
            return dt;
        }

    }
}
