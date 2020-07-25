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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename= C:\Users\ARJUN A G\Documents\Visual Studio 2012\Projects\Blood_bank\Blood_bank\Database1.mdf;Integrated Security=True");
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
           
            //SqlCommand cmd = new SqlCommand("select name,place,bloodgroup,phone_number from [Table] where bloodgroup='" + comboBox2.Text + "'", con);

                        
          
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                cmd.CommandText = "UPDATE [table] SET name ='" + textBox2.Text + "',place ='" + textBox4.Text + "',bloodgroup ='" + comboBox1.Text + "' WHERE phone_number = '" + textBox1.Text + "'";

                cmd.ExecuteNonQuery();

                  SqlDataReader dr = cmd.ExecuteReader();
              

                MessageBox.Show("Data updated successfully");

                this.Hide();

                var form1 = new Form1();
                form1.Closed += (s, args) => this.Close();

                form1.Show();

               /*Form2 f2 = new Form2();

                   f2.Close();
                Form1 f1 = new Form1();

                f1.Show();*/


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



               //  SqlDataReader dr = cmd.ExecuteReader();
                 //if (dr.Read())
                 //{

                //     Int32[] phno = (Int32[])dr[3];

                    /* MessageBox.Show("Data updated successfully");

                     Form2 f2 = new Form2();

                     f2.Close();

                     Form1 f1 = new Form1();

                     f1.Show();*/
               //  }
                // else {
                    // MessageBox.Show("Enter the correct phone number");
                 //}

            //}

           // label1.Text = "Data saved successfully...!!!";                

          
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();

            form4.Show();
        }
    }
}
