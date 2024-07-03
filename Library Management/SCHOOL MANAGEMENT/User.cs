using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SCHOOL_MANAGEMENT
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABS14OI;Initial Catalog=library_management;Integrated Security=True");

        private void txtbookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserManager ob = new UserManager();
            txtbookname.Text = ob.getb_name(txtbookid.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            UserManager obj = new UserManager();
            int a = obj.request(m_id, txtbookid.Text);
            if (a > 0)
            {
                MessageBox.Show("DATA REGISTER .....");
            }
            else
            {
                MessageBox.Show("ERROR , DATA NOT REGISTER .....");
            }

        }
        private void txtbookname_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserManager ob = new UserManager();
            txtbookid.Text = ob.getb_id(txtbookname.Text);
        }

        private void Viewbook_Load(object sender, EventArgs e)
        {
            name = LOGINFORM.username;
            password = LOGINFORM.password; 
            getinfo();
            con.Close();
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            LOGINFORM ob = new LOGINFORM();
            ob.Show();
            this.Close();
        }

        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            if (txtcategory.Text == "ANY")
            {
                con.Open();
                txtbookid.Items.Clear();
                txtbookname.Items.Clear();
                SqlCommand cmd5 = new SqlCommand("Select b_id From books", con);
                SqlDataReader dr5 = cmd5.ExecuteReader();
                while (dr5.Read())
                {
                    txtbookid.Items.Add(dr5[0]).ToString();
                }
                con.Close();
                con.Open();
                SqlCommand cmd6 = new SqlCommand("Select name From books", con);
                SqlDataReader dr6 = cmd6.ExecuteReader();
                while (dr6.Read())
                {
                    txtbookname.Items.Add(dr6[0]).ToString();
                }
                con.Close();
            }
            else
            {
                con.Open();
                txtbookid.Items.Clear();
                txtbookname.Items.Clear();
                SqlCommand cmd2 = new SqlCommand("Select b_id From books inner join category on category.c_id =books.c_id  where category = '" + txtcategory.Text + "'", con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    txtbookid.Items.Add(dr2[0]).ToString();
                }
                con.Close();
                con.Open();
                SqlCommand cmd3 = new SqlCommand("Select name From books inner join category on category.c_id =books.c_id  where category = '" + txtcategory.Text + "'", con);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    txtbookname.Items.Add(dr3[0]).ToString();
                }
                con.Close();

            }
            con.Open();
        }
        string name;
        string password;
        string m_id;
      
        public void getinfo()
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select b_id From books", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                txtbookid.Items.Add(dr2[0]).ToString();
            }
            con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select name From books", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                txtbookname.Items.Add(dr3[0]).ToString();
            }
            con.Close();
            con.Open();
            txtcategory.Items.Add("ANY");
            SqlCommand cmd5 = new SqlCommand("Select category From category", con);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                txtcategory.Items.Add(dr5[0]).ToString();
            }
            con.Close();
            con.Open();
            SqlCommand cmd6 = new SqlCommand("Select m_id From member", con);
            m_id = Convert.ToString(cmd6.ExecuteScalar());
            con.Close();

        }

    }
}

