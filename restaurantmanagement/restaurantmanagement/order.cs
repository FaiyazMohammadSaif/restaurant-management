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
    public partial class order : Form
    {
        SqlDataAdapter sda;

        DataTable dt;
        public order()
        {
            InitializeComponent();
            
        }

        private void order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet15.order1' table. You can move, or remove it, as needed.
            this.order1TableAdapter.Fill(this.restaurantdbDataSet15.order1);
            SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
            sda = new SqlDataAdapter("select CustomerNo,order1.FoodId as 'Food No',menu.FoodName as 'Food Name',menu.Price as 'Price',Date from dbo.order1,menu where order1.FoodId=menu.FoodId", con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 90;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            choice newform = new choice();
            this.Hide();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand("insert into dbo.order1 values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.dateTimePicker1.Text + "')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Saved");

                    
                    sda = new SqlDataAdapter("select CustomerNo,order1.FoodId as 'Food No',menu.FoodName as 'Food Name',menu.Price as 'Price',Date from dbo.order1,menu where order1.FoodId=menu.FoodId", conn);
                    dt = new DataTable();

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
                    
                }
                else
                {
                    MessageBox.Show(" Error!!Try Again!");
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
            textBox6.Text = ("");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand("Delete from dbo.order1 WHERE (CustomerNo='" + textBox1.Text + "' and FoodId='" + textBox2.Text + "')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Done!!");
                    
                    SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                    sda = new SqlDataAdapter("select CustomerNo,order1.FoodId as 'Food No',menu.FoodName as 'Food Name',menu.Price as 'Price',Date from dbo.order1,menu where order1.FoodId=menu.FoodId", con);
                    dt = new DataTable();

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt ;
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            
            //dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(dt.Compute("SUM(Price)", "Date='" + textBox5.Text + "' "));
            textBox6.Text = sum.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(dt.Compute("SUM(Price)", "CustomerNo='" + textBox3.Text + "' "));
            textBox4.Text = sum.ToString();
            /*try
            {
                SqlConnection conn = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(" Select sum(Price) as Today from menu inner join  order1 on order1.FoodId=menu.FoodId where (CustomerNo='" + textBox3.Text + "')", conn);
                    int sumo=comm.ExecuteNonQuery();
                    conn.Close();
                    textBox4.Text = sumo.ToString();
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }*/
        }
    }
}
