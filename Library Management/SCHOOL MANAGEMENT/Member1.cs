

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
using Library_Management;
using System.Net.Mail;

namespace SCHOOL_MANAGEMENT
{
    public partial class Member1 : Form
    {
        public Member1()
        {
            InitializeComponent();
        }
        
        int d_id;
        string id;
        MemberManager memb = new MemberManager();
        Connection con = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            MemberManager mem = new MemberManager();
            Random rd = new Random();
            int rand_num = rd.Next(1000, 2000);
            string email = txtemail.Text;
            mem.addmember(txtname.Text, txtfname.Text, txtemail.Text, txtcnic.Text, Convert.ToDouble(txtcontact.Text), txtaddress.Text, txtgender.Text,Convert.ToString(rand_num));
            email_send(rand_num, email);
            dataGridView1.DataSource = mem.display();
            reset();
        }

        public void email_send(int pass, string em)
        {
            try
            {
                string to = em;
                MailMessage mm = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                mm.From = new MailAddress("oopproject99@gmail.com");
                mm.To.Add(to);
                mm.Subject = "Your Password for Login As Student ";
                mm.Body = "Password : " + pass.ToString();
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("oopproject99@gmail.com", "uswavhimgoxztldl");
                smtp.EnableSsl = true;
                smtp.Send(mm);
                MessageBox.Show("Id and Password send to given Email\nFor Student Login");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registratin_Load(object sender, EventArgs e)
        {
            MemberManager mem = new MemberManager();
            dataGridView1.DataSource = mem.display();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            int check = memb.updatemember(d_id,txtname.Text,txtfname.Text,txtemail.Text,txtcnic.Text,Convert.ToDouble(txtcontact.Text),txtaddress.Text);
            if(check > 0)
            {
                MessageBox.Show("RECORD UPDATED ");
            }
            else
            {
                MessageBox.Show("RECORD REGISTER ");
            }
            dataGridView1.DataSource = memb.display();
            reset();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            d_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtcnic.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtcontact.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        public void reset()
        {
            txtaddress.Text = "";
            txtcnic.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtfname.Text = "";
            txtgender.Text = "";
            txtname.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = memb.deletemember(d_id);
            if (a > 0)
            {
                MessageBox.Show("Data Deleted .......");
            }
            else
            {
                MessageBox.Show("Data Deleted UnSuccessfull .....");

            }
            dataGridView1.DataSource = memb.display();
            reset();
        }

        private void labeluniversity_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Library_menu obj = new Library_menu();
            obj.Show();
            this.Close();
        }
    }
}