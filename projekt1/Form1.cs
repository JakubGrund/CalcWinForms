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

        /* VELIKOSTI OKEN REZIMU*/

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Width = 495;
            textBox1.Width = 456;

        }
        private void zaklaniKalkulackaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 326;
            textBox1.Width = 288;
        }

        private void vedeckaKalkulackaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 495;
            textBox1.Width = 456;

        }

       /*ZAKLADNI KALKULACKA*/

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

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            // button space vrati o jednu hodnotu zpet

            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void AritmeticOperator(object sender, EventArgs e)
        {
            // aritmeticke operatory +,-,/,*

            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + "" + operation;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // button vyhodnoceni pomoci switche 

            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        /*VEDECKA KALKULACKA*/


        private void ButtonPi_Click(object sender, EventArgs e)
        {
            // button Pi hodnota

            textBox1.Text = "3.14159265358997632";
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            // button Log 

            double ilog = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);

        }

        private void ButtonSin_Click(object sender, EventArgs e)
        {
            // button Sin 

            double qSin = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text) + ")");
            qSin = Math.Sin(qSin);
            textBox1.Text = System.Convert.ToString(qSin);

        }

        private void button30_Click(object sender, EventArgs e)
        {
            // button Cos 

            double qCos = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + (textBox1.Text) + ")");
            qCos = Math.Cos(qCos);
            textBox1.Text = System.Convert.ToString(qCos);

        }

        private void ButtonTan_Click(object sender, EventArgs e)
        {
            // button Tan

            double qtan = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + (textBox1.Text) + ")");
            qtan = Math.Tan(qtan);
            textBox1.Text = System.Convert.ToString(qtan);
        }

        private void ButtonDouble2_Click(object sender, EventArgs e)
        {
            // button x2

            Double a;

            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            // button x3

            Double a;

            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);

        }

        private void Button1x_Click(object sender, EventArgs e)
        {
            // button 1/x

            Double a;

            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void ButtonLnx_Click(object sender, EventArgs e)
        {
            // button ln x

            double ilog = Double.Parse(textBox1.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void ButtonPercentage_Click(object sender, EventArgs e)
        {
            // button procenta %

            Double a;

            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
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

