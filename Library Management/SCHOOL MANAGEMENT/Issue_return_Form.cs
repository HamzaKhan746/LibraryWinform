using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace SCHOOL_MANAGEMENT
{
    public partial class Issue_return_Form : Form
    {
        public Issue_return_Form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABS14OI;Initial Catalog=library_management;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Issue_return_Manager obj = new Issue_return_Manager();
            if (comboBox1.Text == "ISSUE")
            {
                int a = obj.issue(txtmemid.Text, txtbookid.Text, txtmemname.Text, txtbookname.Text);
                if (a > 0)
                {
                    obj.getdec(txtbookid.Text);
                    MessageBox.Show("DATA REGISTER .....");
                }
                else
                {
                    MessageBox.Show("ERROR , DATA NOT REGISTER .....");
                }
            }
            else if (comboBox1.Text == "RETURN")
            {
                int a = obj.returno(txtmemid.Text, txtbookid.Text);
                if (a > 0)
                {
                    obj.getinc(txtbookid.Text);
                    MessageBox.Show("DATA UPDATED .....");
                }
                else
                {
                    MessageBox.Show("ERROR , DATA NOT UPDATED .....");
                }
            }
          dataGridView1.DataSource= obj.displayissue();

        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {     
        }

        private void LIBRARY_Load(object sender, EventArgs e)
        {
            getinfo();
            con.Open(); 
        }
      
       

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com1 = new SqlCommand("update issue_return set returndate = '" + DateTime.Now + "' , where m_id = '" + txtmemid.Text + "' and where b_id = '"+txtbookid.Text+"'", con);
            com1.ExecuteNonQuery();
            MessageBox.Show("BOOK RETURN");
            con.Close();
            Issue_return_Manager obj = new Issue_return_Manager();
            dataGridView1.DataSource = obj.displayreturn();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            Issue_return_Manager ob = new Issue_return_Manager();
            txtbookname.Text = ob.getb_name(txtbookid.Text);
        }

        private void txtid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Issue_return_Manager ob = new Issue_return_Manager();
            txtmemname.Text = ob.getm_name(txtmemid.Text);
    
        }

        private void txtmemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Issue_return_Manager ob = new Issue_return_Manager();
            txtmemid.Text = ob.getm_id(txtmemname.Text);
        }

        private void txtbookname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Issue_return_Manager ob = new Issue_return_Manager();
            txtbookid.Text = ob.getb_id(txtbookname.Text);

        }

        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (txtcategory.Text == "ANY")
            {
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
                SqlCommand cmd6= new SqlCommand("Select name From books", con);
                SqlDataReader dr6 = cmd6.ExecuteReader();
                while (dr6.Read())
                {
                    txtbookname.Items.Add(dr6[0]).ToString();
                }
                con.Close();
            }
            else
            {
                txtbookid.Items.Clear();
                txtbookname.Items.Clear();
                SqlCommand cmd2 = new SqlCommand("Select b_id From books inner join category on category.c_id =books.c_id  where category = '"+txtcategory.Text+"'", con);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Issue_return_Manager obj = new Issue_return_Manager();
            if (comboBox1.Text == "ISSUE")
            {
                obj.displayissue();
            }
            else if(comboBox1.Text =="RETURN")
            {
                obj.displayreturn();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Issue_return_Manager obj = new Issue_return_Manager();
            dataGridView1.DataSource = obj.displayissue();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Issue_return_Manager obj = new Issue_return_Manager();
            dataGridView1.DataSource = obj.displayreturn();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Library_menu ob = new Library_menu();
            ob.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void getinfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select m_id From member", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtmemid.Items.Add(dr[0]).ToString();
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
            SqlCommand cmd1 = new SqlCommand("Select name From member", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                txtmemname.Items.Add(dr1[0]).ToString();
            }
            con.Close();
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
        }
    }
}
