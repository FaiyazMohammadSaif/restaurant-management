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

namespace restaurantmanagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu newform = new menu();
            this.Hide();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login newform = new Login();
            this.Hide();
            newform.Show();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            employee newform = new employee();
            this.Hide();
            newform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            service newform = new service();
            this.Hide();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            billing newform = new billing();
            this.Hide();
            newform.Show();
        }
    }
}
