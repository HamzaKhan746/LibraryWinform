using SCHOOL_MANAGEMENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Management
{
    public class Member
    {
        Connection con = new Connection();
        private string m_id;
      
            public int addmember(string name, string fname, string email, string cnic, double contact, string address, string gender,string password)
        {
            SqlCommand com = new SqlCommand("Insert into member(name,fname,email,cnic,contact,address,gender,password) values ('" + name + "','" + fname + "' ,'" + email + "','" + cnic + "','" + contact + "','" + address + "','" + gender + "','" + password + "')", con.connect());
            return com.ExecuteNonQuery();

        }
        public int updatemember(int m_id,string name,string fname, string email,string cnic,double contact, string address)
        { 
            SqlCommand com = new SqlCommand("update member set name = '" + name + "'  , fname = '" + fname + "', email = '" + email + "', cnic = '" + cnic + "',contact = '" + contact + "'  , address = '" + address + "' where m_id = '" + m_id + "'", con.connect());
            return com.ExecuteNonQuery();

        }
        public int deletemember(int d_id)
        {
            SqlCommand com1 = new SqlCommand("delete issue_return where m_id = '" + d_id + "'", con.connect());
            com1.ExecuteNonQuery();
            SqlCommand com = new SqlCommand("delete member where m_id = '" + d_id + "'", con.connect());  
            return com.ExecuteNonQuery();

        }
        public DataTable display()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select m_id,name,fname,email,cnic,contact,address from member", con.connect());
            sda.Fill(dt);
            con.close();
            return dt;
        }

    }
}















