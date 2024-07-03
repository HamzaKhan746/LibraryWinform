using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SCHOOL_MANAGEMENT
{
    public partial class viewdetail : Form
    {
        public viewdetail()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void viewdetail_Load(object sender, EventArgs e)
        {
            DetailManager details = new DetailManager();
            txtissue.Text = Convert.ToString(details.GetIssue());
            txtreturn.Text = Convert.ToString(details.GetReturn());
            txtmem.Text = Convert.ToString(details.GetMember());
            txtbook.Text = Convert.ToString(details.GetBook());
            txtcategory.Text = Convert.ToString(details.GetCategory());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Library_menu obj = new Library_menu();
            obj.Show();
            this.Close();
        }
    }
}
