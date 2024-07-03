using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT
{
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
            InitializeComponent();
        }
        public static string username;
        public static string password;
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LoginManager ob = new LoginManager();

            if(comboBox1.Text == "LIBRARIAN" && txtusername.Text == "admin" && txtpassword.Text == "123")
            {
                Library_menu obj = new Library_menu();
                obj.Show();
            }
            else if (comboBox1.Text == "MEMBER")
            {
                int a = ob.verify(txtusername.Text, txtpassword.Text);
                if (a > 0)
                {
                    username = txtusername.Text;
                    password = txtpassword.Text;
                    User obj = new User();
                    obj.Show();
                }
            }
            else
            {
                MessageBox.Show("SOMETHING WENT WRONG");
            }
            
          
         

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
