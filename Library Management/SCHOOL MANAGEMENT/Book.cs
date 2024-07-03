using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Security.Policy;

namespace SCHOOL_MANAGEMENT
{
    public class Book
    {
        readonly Connection con = new Connection();
     
        public int addbook(int a_id, int c_id, int p_id, string name, int price, int quantity)
        {
            SqlCommand com = new SqlCommand("Insert into books(name,a_id,p_id,c_id,price,quantity) values ('" + name + "','" + a_id + "','" + p_id + "','" + c_id + "' ,'" + price + "','" + quantity + "')", con.connect());
           return com.ExecuteNonQuery();
        }
        public int getpublisher(string publisher)
        {
            SqlCommand com = new SqlCommand("Select p_id from publisher where publisher  = '" + publisher+"'", con.connect());
            return Convert.ToInt32(com.ExecuteScalar());
        }
        public int getcategory(string category)
        {
            SqlCommand com = new SqlCommand("Select c_id from category where category = '" + category + "'", con.connect());
            return Convert.ToInt32(com.ExecuteScalar());
        }
        public int getaurthor(string aurthor)
        {
            SqlCommand com = new SqlCommand("Select a_id from aurthor where aurthor = '" + aurthor + "'", con.connect());
            return Convert.ToInt32(com.ExecuteScalar());
        }
        public DataTable display()
        {
            DataTable dt = new DataTable();
            string query = "Select b_id,name,aurthor.aurthor,publisher.publisher,category.category,price,quantity from books inner Join publisher On publisher.p_id=Books.p_id inner join category on category.c_id = books.c_id inner join aurthor on aurthor.a_id = books.p_id";
            SqlDataAdapter sda = new SqlDataAdapter(query,con.connect());
            sda.Fill(dt);
            return dt;
        }
        public int update(int b_id,string n, int a, int p, int c, string pr, string q)
        {
            SqlCommand com = new SqlCommand("update books set name = '" + n + "'  , a_id = '" + a + "', p_id = '" + p + "', c_id = '" + c + "',price = '" + pr + "'  , quantity = '" + q + "' where b_id = '" + b_id + "'", con.connect());
            return com.ExecuteNonQuery();

        }
        public int delete(int b_id)
        {
            SqlCommand com = new SqlCommand("delete from books where b_id = '" + b_id + "'", con.connect());
            return com.ExecuteNonQuery();

        }
        public string setcategory(string c)
        {
            SqlCommand com = new SqlCommand("insert into category(category)values('"+c+"')", con.connect());
            return Convert.ToString(com.ExecuteScalar());
        }
        public string setaurthor(string c)
        {
            SqlCommand com = new SqlCommand("insert into aurthor(aurthor)values('" + c + "')", con.connect());
            return Convert.ToString(com.ExecuteScalar());
        }
        public string setpublisher(string c)
        {
            SqlCommand com = new SqlCommand("insert into publisher(publisher)values('" + c + "')", con.connect());
            return Convert.ToString(com.ExecuteScalar());
        }
    }
}
