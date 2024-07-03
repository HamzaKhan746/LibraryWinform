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
    public partial class Library_menu : Form
    {
        public Library_menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Member1 obj = new Member1();
            obj.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Issue_return_Form obj = new Issue_return_Form();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewdetail obj = new viewdetail();
            obj.Show();
            this.Close();
        }

        private void Uni_Menu_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibRequest obj = new LibRequest();
            obj.Show();
            this.Close();   
        }
    }
}
