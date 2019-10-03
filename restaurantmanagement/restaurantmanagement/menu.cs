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
     
    public partial class menu : Form
    {
        SqlDataAdapter sda;

        DataTable dt;
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home newform = new Home();
            this.Hide();
            newform.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet16.menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter4.Fill(this.restaurantdbDataSet16.menu);
            // TODO: This line of code loads data into the 'restaurantdbDataSet10.menu' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'restaurantdbDataSet9.menu' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'restaurantdbDataSet8.menu' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'restaurantdbDataSet1.menu' table. You can move, or remove it, as needed.
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
