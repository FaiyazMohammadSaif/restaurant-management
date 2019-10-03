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
    public partial class Employeelogin : Form
    {
        public Employeelogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login newform = new Login();
            this.Hide();
            newform.Show();
        }

        

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Username !");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Password !");
            }
            else
            {
                if (textBox1.Text == "faiyaz")
                {
                    if (textBox2.Text == "pass")
                    {
                        MessageBox.Show("Login Successful !");
                        choice newform = new choice();
                        this.Hide();
                        newform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid  Password!!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid  Username!!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login newform = new Login();
            this.Hide();
            newform.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
