using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT
{
    public class Issue_return
    {
        string cmdtext;
        public string getb_name(string id)
        {
            Connection con = new Connection();
            cmdtext = "Select name From books where b_id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(cmdtext, con.connect());
            id = Convert.ToString(cmd.ExecuteScalar());
            return id;
        }
        public string getm_name(string id)
        {
            Connection con = new Connection();
            cmdtext = "Select name From member where m_id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(cmdtext, con.connect());
            id = Convert.ToString(cmd.ExecuteScalar());
            return id;
        }

        public string getb_id(string name)
        {
            Connection con = new Connection();
            cmdtext = "Select b_id From books where name = '" + name + "'";
            SqlCommand cmd = new SqlCommand(cmdtext, con.connect());
            name = Convert.ToString(cmd.ExecuteScalar());
            return name;
        }
        public string getm_id(string name)
        {
            Connection con = new Connection();
            cmdtext = "Select m_id From member where name = '" + name + "'";
            SqlCommand cmd = new SqlCommand(cmdtext, con.connect());
            name = Convert.ToString(cmd.ExecuteScalar());
            return name;
        }
      
        public int issue(string m_id, string b_id, string m_name, string b_name)
        {
            Connection con = new Connection();
            cmdtext = "Insert into issue_return (m_id,b_id,issuedate,s_id)values('" + m_id + "','" + b_id + "','" + DateTime.Now + "','" + 1 + "')";
            SqlCommand cmd = new SqlCommand(cmdtext, con.connect());
            int a1 = cmd.ExecuteNonQuery();
            return a1;
        }
        public int getinc(string b_id)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Select quantity From books where b_id = '" + b_id + "'", con.connect());
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            a += 1;
            SqlCommand cmd1 = new SqlCommand("Update books set quantity ='" + a + "' where b_id = '" + b_id + "'", con.connect());
            a = Convert.ToInt32(cmd1.ExecuteScalar());
            return a;
        }
        public int getdec(string b_id)
        {
            Connection con = new Connection();
            SqlCommand cmd = new SqlCommand("Select quantity From books where b_id = '" + b_id + "'", con.connect());
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            a -= 1;
            SqlCommand cmd1 = new SqlCommand("Update books set quantity ='" + a + "' where b_id = '" + b_id + "'", con.connect());
            a = Convert.ToInt32(cmd1.ExecuteScalar());
            return a;
        }
        public int returno(string m_id, string b_id)
        {
            Connection con = new Connection();
            cmdtext = "update issue_return set returndate = '" + DateTime.Now + "',s_id = '" + 2 + "' where b_id = '" + b_id + "'and m_id = '" + m_id + "'";
            SqlCommand com = new SqlCommand(cmdtext, con.connect());
            return com.ExecuteNonQuery();
        }
        public DataTable displayissue()
        {
            Connection con = new Connection();
            DataTable dt = new DataTable();
            cmdtext = "SELECT i_id,member.m_id,member.name,books.b_id,books.name,issuedate,status.status FROM issue_return INNER JOIN member ON member.m_id = issue_return.m_id INNER JOIN books ON books.b_id = issue_return.b_id INNER JOIN status on status.s_id=issue_return.s_id where issue_return.s_id = '" + 1 + "'";
            SqlDataAdapter sda = new SqlDataAdapter(cmdtext, con.connect());
            sda.Fill(dt);
            con.close();
            return dt;
        }
        public DataTable displayreturn()
        {
            Connection con = new Connection();
            DataTable dt = new DataTable();
            cmdtext = "SELECT i_id,member.m_id,member.name,books.b_id,books.name,issuedate,returndate,status.status FROM issue_return INNER JOIN member ON member.m_id = issue_return.m_id INNER JOIN books ON books.b_id = issue_return.b_id INNER JOIN status on status.s_id=issue_return.s_id where issue_return.s_id = '" + 2 + "'";
            SqlDataAdapter sda = new SqlDataAdapter(cmdtext, con.connect());
            sda.Fill(dt);
            con.close();
            return dt;
        }
    }
}
