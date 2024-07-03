using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookManager ob = new BookManager();
            if (txtopt.Text == "AURTHOR")
            {
                ob.setaurthor(txtname.Text);
                MessageBox.Show("AURTHOR ADDED");
            }
            else if (txtopt.Text == "PUBLISHER")
            {
                ob.setpublisher(txtname.Text);
                MessageBox.Show("PUBLISHER ADDED");

            }
            else if(txtopt.Text == "CATEGORY")
            {
                ob.setcategory(txtname.Text);
                MessageBox.Show("CATEGORY ADDED");


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books ob = new Books();
            ob.Show();
            this.Close();
        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
