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
    public partial class Menuadmin : Form
    {
        SqlDataAdapter sda;
        
        DataTable dt;
        
        public Menuadmin()
        {
            InitializeComponent();
            comboBox1.Items.Add("Appetizer");
            comboBox1.Items.Add("Main");
            comboBox1.Items.Add("Drinks");
            comboBox1.Items.Add("Dessert");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            options newform = new options();
            this.Hide();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand("insert into dbo.menu values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Done!!");


                    SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                    sda = new SqlDataAdapter("select * from dbo.menu", con);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand("Update dbo.menu SET FoodId='" + textBox1.Text + "',FoodName='" + textBox2.Text + "',Price='" + textBox3.Text + "',Catagory='" + comboBox1.Text + "' WHERE (FoodId='" + textBox1.Text + "')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Done!!");

                    SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                    sda = new SqlDataAdapter("select * from dbo.menu", con);
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand("Delete from dbo.menu WHERE (FoodId='" + textBox1.Text + "')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Done!!");

                    SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                    sda = new SqlDataAdapter("select * from dbo.menu", con);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Menuadmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantdbDataSet13.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter2.Fill(this.restaurantdbDataSet13.menu);
           SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
            sda = new SqlDataAdapter("select * from dbo.menu", con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*Menuadmin newform = new Menuadmin();
            this.Hide();
            newform.Show();*/
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            comboBox1.Text = ("");
            
            
             
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            

        }
    }
}
