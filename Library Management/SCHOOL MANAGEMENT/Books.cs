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

namespace SCHOOL_MANAGEMENT
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABS14OI;Initial Catalog=library_management;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            BookManager b = new BookManager();
            int a_id =b.getaurthor(txtaurthor.Text);
          int c_id=  b.getcategory(txtcategory.Text);
           int p_id= b.getpublisher(txtpublisher.Text);
            int a = b.addbook(a_id,c_id,p_id,txtname.Text,int.Parse(txtprice.Text),int.Parse(txtquantity.Text));
            if (a > 0)
            {
                MessageBox.Show("BOOK REGISTER ");
            }
            dataGridView1.DataSource = b.display();
            reset();            
        }
        public void reset()
        {
            txtquantity.Text = "";
            txtcategory.Text = "";
            txtpublisher.Text = "";
            txtprice.Text = "";
            txtpublisher.Text = "";
            txtname.Text = "";
        }
       
      

        private void MARK_Load(object sender, EventArgs e)
        {
            BookManager b = new BookManager();
            get_info();
            dataGridView1.DataSource = b.display();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADD obj = new ADD();
            obj.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookManager b = new BookManager();
            int a_id = b.getaurthor(txtaurthor.Text);
            int c_id = b.getcategory(txtcategory.Text);
            int p_id = b.getpublisher(txtpublisher.Text);
            int a = b.update(d_id,txtname.Text, a_id, p_id, c_id,txtprice.Text,txtquantity.Text);
            if (a > 0)
            {
                MessageBox.Show("BOOK UPDATED ");
            }
            else
            {
                MessageBox.Show("BOOK NOT UPDATED ");
            }
            dataGridView1.DataSource = b.display();
            reset();
        }
        int d_id;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            d_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtaurthor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtpublisher.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtcategory.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtquantity.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookManager b = new BookManager();

            int a = b.delete(d_id);
            if (a > 0)
            {
                MessageBox.Show("BOOK DELETED ");
            }
            else
            {
                MessageBox.Show("BOOK NOT DELETED ");
            }
            dataGridView1.DataSource = b.display();
            reset();
        }
   

        private void txtpublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void get_info()
        {
            txtcategory.Items.Clear();
            txtaurthor.Items.Clear();
            txtpublisher.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select category From category", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtcategory.Items.Add(dr[0]).ToString();
            }
            con.Close();
            con.Open();

            SqlCommand cmd5 = new SqlCommand("Select aurthor From aurthor", con);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                txtaurthor.Items.Add(dr5[0]).ToString();
            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select publisher From publisher", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                txtpublisher.Items.Add(dr1[0]).ToString();
            }
            con.Close();
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Library_menu obj = new Library_menu();
            obj.Show();
            this.Close();   
        }
    }
    }

