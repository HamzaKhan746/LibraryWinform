using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_MANAGEMENT
{
    public class DetailManager
    {
        readonly Detail obj = new Detail();
        public int GetMember()
        {
           return obj.GetMember();
        }
        public int GetBook()
        {
            return obj.GetBook();
           
        }
        public int GetIssue()
        {
            return obj.GetIssue();
        }
        public int GetCategory()
        {
            return obj.GetCategory();
        }
        public int GetReturn()
        {
            return obj.GetReturn();
        }
    }
}
