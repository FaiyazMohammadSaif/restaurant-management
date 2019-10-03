using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantmanagement
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "rashna")
            {
                if(txtpassword.Text == "password")
                {
                    MessageBox.Show("Login Successful !");
                    options newform = new options();
                    this.Hide();
                    newform.Show();
                }
                else
                {
                    MessageBox.Show("Error ! Invalid username or password !");
                }
            }
            else
            {
                MessageBox.Show("Error ! Invalid username or password !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login newform = new Login();
            this.Hide();
            newform.Show();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
    }
}
