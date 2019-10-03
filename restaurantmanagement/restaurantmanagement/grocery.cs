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
    public partial class grocery : Form
    {
        SqlDataAdapter sda;

        DataTable dt;
        public grocery()
        {
            InitializeComponent();
        }

        private void grocery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet18.grocery' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'restaurantdbDataSet17.grocery' table. You can move, or remove it, as needed.
            SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
            sda = new SqlDataAdapter("select GroceryId as 'Grocery Id',ItemName as 'Item Name',ItemPrice as 'ItemPrice',Date from dbo.grocery ", con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            choice  newform = new choice();
            this.Hide();
            newform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(dt.Compute("Sum(ItemPrice)", "Date='" + textBox4.Text + "' "));
            textBox5.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand("insert into dbo.grocery values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + this.dateTimePicker1.Text + "')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Done!!");

                    SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                    sda = new SqlDataAdapter("select GroceryId as 'Grocery Id',ItemName as 'Item Name',ItemPrice as 'ItemPrice',Date from dbo.grocery ", con);
                    dt = new DataTable();

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox4.Text = ("");
            textBox5.Text = ("");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand("truncate table dbo.grocery", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Done!!");
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
