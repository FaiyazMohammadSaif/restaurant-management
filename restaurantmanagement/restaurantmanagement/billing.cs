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
    public partial class billing : Form
    {
        SqlDataAdapter sda;

        DataTable dt;
        public billing()
        {
            InitializeComponent();
        }

        private void billing_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
            sda = new SqlDataAdapter("select CustomerNo,order1.FoodId as 'Food No',menu.FoodName as 'Food Name',menu.Price as 'Price',Date from dbo.order1,menu where order1.FoodId=menu.FoodId", con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //dataGridView1.AutoResizeColumns();
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home newform = new Home();
            this.Hide();
            newform.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(dt.Compute("SUM(Price)", "CustomerNo='" + textBox1.Text + "' "));
            textBox2.Text = sum.ToString();
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            /*dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;*/
            
        }
    }
}
