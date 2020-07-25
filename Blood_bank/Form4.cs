using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_bank
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           // button1.Text = "ADD YOUR BLOOD GROUP";
            toolTip1.SetToolTip(button1, "ADD YOUR BLOOD GROUP");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "UPDATE YOUR DETAILS");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "SEARCH BLOOD GROUP");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "DELETE DETAILS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();

            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();

            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();

            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();

            form3.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();

            form5.Show();
        }
    }
}
