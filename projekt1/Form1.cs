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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Width = 327;
            textBox1.Width = 288;
            
        }

        private void zakladniKalkulackaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 327;
            textBox1.Width = 288;
        }

        private void pozadiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vedeckaKalkulackaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 629;
            textBox1.Width = 590;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button_Click(object sender, EventArgs e)
        {
            //podminky textove pole, cislice 0-9 + "."

            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == "") 
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else textBox1.Text = textBox1.Text + num.Text;
        }
    }
}
