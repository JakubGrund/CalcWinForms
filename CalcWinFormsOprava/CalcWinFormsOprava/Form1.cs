using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinFormsOprava
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
            this.Width = 326;
            textBox1.Width = 288;
        }

        private void zakladniKalkulackaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 326;
            textBox1.Width = 288;
        }

        private void vedeckaKalkulackaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 509;
            textBox1.Width = 467;
        }

        /*ZAKLADNI KALKULACKA*/

        private void ButtonValue(object sender, EventArgs e)
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

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            //button CE 
            textBox1.Text = "0";
            lblShowOp.Text = "";
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            //button C
            textBox1.Text = "0";
            lblShowOp.Text = "";
        }

        private void ButtonSpaceBack_Click_1(object sender, EventArgs e)
        {
            // button space vrati o jednu hodnotu zpet

            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            // aritmeticke operatory +,-,/,*

            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + "" + operation;
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            // button +-

            results = double.Parse(textBox1.Text);
            results = results * -1;
            textBox1.Text = results.ToString();
        }


        private void ButtonRovnase_Click(object sender, EventArgs e)
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

        private void ButtonCos_Click(object sender, EventArgs e)
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

        private void ButtonPi_Click(object sender, EventArgs e)
        {
            // button Pi hodnota

            textBox1.Text = "3.14159265358997632";
        }

        private void ButtonX2_Click(object sender, EventArgs e)
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

        private void Button1X_Click(object sender, EventArgs e)
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

       
    }


}


