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
    public partial class Form3 : Form
    {
        public static string text1 = ""; 

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename= C:\Users\ARJUN A G\Documents\Visual Studio 2012\Projects\Blood_bank\Blood_bank\Database1.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            con.Open();

            //SqlCommand cmd = new SqlCommand("select name,place,bloodgroup,phone_number from [Table] where bloodgroup='" + comboBox2.Text + "'", con);



            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (textBox3.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cmd.CommandText = "DELETE FROM [table]  WHERE phone_number = '" + textBox3.Text + "'";

                    cmd.ExecuteNonQuery();

                    SqlDataReader dr = cmd.ExecuteReader();


                    MessageBox.Show("Data Deleted successfully");

                }

                else
                {

                    MessageBox.Show(" Deletion Cancelled ");

                   // dataGridView1.Rows.Clear();
                    dataGridView1.DataSource = null;
                }

             /*  this.Hide();

                var form4 = new Form4();
                form4.Closed += (s, args) => this.Close();

                form4.Show();*/

            }
            else
            {
                MessageBox.Show("Enter the Phone number");

            }


            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;

          textBox3.Clear();

            con.Close();
      
        
       }

        private void button1_Click(object sender, EventArgs e)
        {

           con.Open();

            SqlDataAdapter cmd = new SqlDataAdapter("select name,place,bloodgroup,phone_number from [Table] where phone_number='" + textBox3.Text + "'", con);

          
            if (textBox3.Text != "")
            {

                //      SqlDataReader dr = cmd.ExecuteReader();

                DataTable dtbl = new DataTable();

                cmd.Fill(dtbl);

                dataGridView1.DataSource = dtbl;


            }


            else
            {

                MessageBox.Show("Enter the phone number");

                      }

            con.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

          /*  if (con.State == ConnectionState.Closed) 
           
                con.Open(); 

            SqlDataAdapter cmd = new SqlDataAdapter("select name,place,bloodgroup,phone_number from [Table] where phone_number='" + textBox3.Text + "'", con);

            
            DataTable dtbl = new DataTable();

            cmd.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            
        
            //con.Close();*/
        
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
