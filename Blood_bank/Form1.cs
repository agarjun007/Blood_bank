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
using System.IO;

namespace Blood_bank
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename= C:\Users\ARJUN A G\Documents\Visual Studio 2012\Projects\Blood_bank\Blood_bank\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                cmd.CommandText = "INSERT INTO [table] VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "')";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data saved successfully");
            }

           // label1.Text = "Data saved successfully...!!!";                

            else
            {
                MessageBox.Show("Enter the Details");
            }

            textBox1.Clear();
            textBox2.Clear(); 
            textBox4.Clear();
           
            comboBox1.Text = string.Empty;
           

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            con.Open();

           SqlDataAdapter cmd = new SqlDataAdapter("select name,place,bloodgroup,phone_number from [Table] where bloodgroup='" + comboBox2.Text + "'", con);
        
        //    SqlCommand cmd = new SqlCommand("select name,place,bloodgroup,phone_number from [Table] where bloodgroup='" + comboBox2.Text + "'", con);
         
           // SqlDataReader dr = cmd.ExecuteReader();

                if(comboBox2.Text != "")
            
                {

          //      SqlDataReader dr = cmd.ExecuteReader();

                DataTable dtbl = new DataTable();

               cmd.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

                
            }
           

     else{

         MessageBox.Show("Enter a blood group"); 
    
    
               // MessageBox.Show("Data not inserted in the database"); 
               // MessageBox.Show(ex.Message);

                
            }
                              
               con.Close();
           
                  


        }

        private void button3_Click(object sender, EventArgs e)
        {

           /* this.Hide();

            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();

            form2.Show();
            
            
            /*Form1 f1 = new Form1();
            f1.Close();
            Form2 f2 = new Form2();
            f2.Show();*/
                 
          
           

        }

        private void button4_Click(object sender, EventArgs e)
        {

        /*    this.Hide();

            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();

            form3.Show();*/

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();

            form4.Show();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
