using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt1
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        // nastaveni velikosti oken 

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Width = 327;
            textBox1.Width = 288;
            
        }
        private void zaklaniKalkulackaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 327;
            textBox1.Width = 288;
        }

        private void vedeckaKalkulackaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 629;
            textBox1.Width = 590;

        }

        private void teplotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1026;
            textBox1.Width = 590;
        }

        private void prevodJednotekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1026;
            textBox1.Width = 590;
        }

        private void nasobeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1026;
            textBox1.Width = 590;
        }

        //zakladni kalkulacka

        private void button_Click(object sender, EventArgs e)
        {
            //podminky textove pole, cislice 0-9 + "."

            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //button Space
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button CE 
            textBox1.Text = "0";
            lblShowOp.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //button C
            textBox1.Text = "0";
            lblShowOp.Text = "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

       
       

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
     
    }
}

