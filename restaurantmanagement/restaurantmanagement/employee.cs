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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration newform = new Registration();
            this.Hide();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home newform = new Home();
            this.Hide();
            newform.Show();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet.registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.restaurantdbDataSet.registration);

        }
    }
}
