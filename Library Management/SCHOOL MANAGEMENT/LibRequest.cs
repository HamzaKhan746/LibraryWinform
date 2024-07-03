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

namespace SCHOOL_MANAGEMENT
{
    public partial class LibRequest : Form
    {
        public LibRequest()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABS14OI;Initial Catalog=library_management;Integrated Security=True");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RequestManager ob = new RequestManager();
            int a =ob.accept(comboBox1.Text);
            if(a > 0)
            {
                MessageBox.Show("REQUEST ACCEPT");
            }
            else
            {
                MessageBox.Show("SOMETHING WENT WRONG ......");

            }
            dataGridView1.DataSource = ob.display();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RequestManager ob = new RequestManager();
            int a = ob.reject(comboBox1.Text);
            if (a > 0)
            {
                MessageBox.Show("REQUEST REJECTED");
            }
            else
            {
                MessageBox.Show("SOMETHING WENT WRONG ......");
            }
            dataGridView1.DataSource = ob.display();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Library_menu ob = new Library_menu();
            ob.Show();
           this.Close();
        }
       
        private void LibRequest_Load(object sender, EventArgs e)
        {
            RequestManager ob = new RequestManager();
            getinfo();
            dataGridView1.DataSource = ob.display();
        }
        public void getinfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select i_id From issue_return where s_id = '" + 3 + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]).ToString();
            }
            con.Close();
        }
    }
}
