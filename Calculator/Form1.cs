using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double x1;
        double x2;
        double result;
        int oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            oper = 0;
        }

        private void Set(string val)
        {  // Good
            if (textBox1.Text == "0")
            {
                textBox1.Text = val;
            }
            else
            {
                textBox1.Text = textBox1.Text + val;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Set("8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Set("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Set("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Set("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Set("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Set("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Set("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Set("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Set("0");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = 1;
            textBox2.Text = x1.ToString() + " +";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            x2 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = " ";
            switch(oper)
            {
                case 1: // addition
                    Add(x1, x2);
                    break;
                case 2: // subtraction
                    Sub(x1, x2);
                    break;
                case 3: // multiplication
                    Mul(x1, x2);
                    break;
                case 4: // division
                    Div(x1, x2);
                    break;
                case 5: // remainder
                    Rem(x1, x2);
                    break;
            }
        }

        public double Add(double x1, double x2)
        {
            result = x1 + x2;
            textBox1.Text = result.ToString();

            return result;
        }

        public double Sub(double x1, double x2)
        {
            result = x1 - x2;
            textBox1.Text = result.ToString();

            return result;
        }

        public double Mul(double x1, double x2)
        {
            result = x1 * x2;
            textBox1.Text = result.ToString();

            return result;
        }

        public double Div(double x1, double x2)
        {
            result = x1 / x2;
            textBox1.Text = result.ToString();

            return result;
        }

        public double Rem(double x1, double x2)
        {
            result = x1 % x2;
            textBox1.Text = result.ToString();

            return result;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = 2;
            textBox2.Text = x1.ToString() + " -";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = 3;
            textBox2.Text = x1.ToString() + " *";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = 4;
            textBox2.Text = x1.ToString() + " /";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oper = 5;
            textBox2.Text = x1.ToString() + " %";
        }
    }
}
