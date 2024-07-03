using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    public class BookManager
    {
        readonly Connection con = new Connection();
        readonly Book obj = new Book();
        public int addbook(int a_id, int c_id, int p_id, string name, int price, int quantity)
        {
            return obj.addbook(a_id, c_id, p_id, name, price, quantity);
          
        }
        public int getpublisher(string publisher)
        {
            return obj.getpublisher(publisher);
        }
        public int getcategory(string category)
        {
            return obj.getcategory(category);
        }
        public int getaurthor(string aurthor)
        {
            return obj.getaurthor(aurthor);

        }
        public DataTable display()
        {
            return obj.display();
        }
        public int update(int b_id, string n, int a, int p, int c, string pr, string q)
        {
            return update(b_id, n, a, p, c, pr,q);
        }
        public int delete(int b_id)
        {
            return obj.delete(b_id);

        }
        public string setcategory(string c)
        {
          return obj.setcategory(c);
        }
        public string setaurthor(string c)
        {
           return obj.setaurthor(c);
        }
        public string setpublisher(string c)
        {
           return obj.setpublisher(c);
        }
    }
}
