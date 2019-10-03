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
    public partial class service : Form
    {
        
        
        SqlDataAdapter sda;
        DataTable dt;
        public service()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void service_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
            sda = new SqlDataAdapter("Select TableNo as 'Table No', service.Id ,registration.Name as 'Employee Name' ,Date from service,registration where registration.Id=service.Id", con);
            dt = new DataTable();

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
           
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home newform = new Home();
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
                    SqlCommand comm = new SqlCommand("insert into dbo.service values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.dateTimePicker1.Text + "')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Saved");

                    SqlConnection con = new SqlConnection("Data Source=Rashna;Initial Catalog=restaurantdb;Integrated Security=True;Pooling=False");
                    sda = new SqlDataAdapter("Select TableNo as 'Table No', service.Id ,registration.Name as 'Employee Name' ,Date from service,registration where registration.Id=service.Id", con);
                    dt = new DataTable();

                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text=("");
            textBox2.Text = ("");
            
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
       
    }
}
    
        
    

