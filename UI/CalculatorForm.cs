using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.BL;
namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void addValueToText(string value)
        {
            textBox1.Text = textBox1.Text + value;

        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "0";
            CalculatorClass.Op = ' ';
            CalculatorClass.Oprand1 = "";
            CalculatorClass.Oprand2 = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                string oprand = textBox1.Text;
                textBox1.Text = "";
                for (int i = 0; i < oprand.Length - 1; i++)
                {
                    textBox1.Text += oprand[i];
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addValueToText("0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addValueToText("1");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addValueToText("2");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addValueToText("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addValueToText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addValueToText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addValueToText("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addValueToText("7");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addValueToText("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addValueToText("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.')
                {
                    check = true;
                }
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (!check)
            {
                addValueToText(".");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN" || textBox1.Text == "∞")
            {
                textBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {
                textBox1.Text = "-";
            }
            else
            if (CalculatorClass.Op == ' ')
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Op = '/';
                    CalculatorClass.Oprand1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;
                }
            }
            else
            {
                if (textBox1.Text != "")
                {

                    CalculatorClass.Oprand2 = textBox1.Text;
                    CalculatorClass.Oprand1 = CalculatorClass.CalculateAnswer().ToString();
                    CalculatorClass.Op = '/';
                    textBox1.Text = "";
                }
                else
                {
                    CalculatorClass.Op = '/';
                }
                label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;
            }
        }


        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {
                textBox1.Text = "-";
            }
            else
            if (CalculatorClass.Op == ' ')
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Op = '*';
                    CalculatorClass.Oprand1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;
                }
            }
            else
            {
                if (textBox1.Text != "")
                {

                    CalculatorClass.Oprand2 = textBox1.Text;
                    CalculatorClass.Oprand1 = CalculatorClass.CalculateAnswer().ToString();
                    CalculatorClass.Op = '*';
                    textBox1.Text = "";
                }
                else
                {
                    CalculatorClass.Op = '*';
                }
                label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else if (CalculatorClass.Op == ' ')
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Op = '+';
                    CalculatorClass.Oprand1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;
                }
            }
            else
            {
                if (textBox1.Text != "")
                {

                    CalculatorClass.Oprand2 = textBox1.Text;
                    CalculatorClass.Oprand1 = CalculatorClass.CalculateAnswer().ToString();
                    CalculatorClass.Op = '+';
                    textBox1.Text = "";
                }
                else
                {
                    CalculatorClass.Op = '+';

                }
                label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;

            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (CalculatorClass.Op == ' ')
            {
                if (textBox1.Text == "-")
                {
                    textBox1.Text = "";
                }
                else if (textBox1.Text != "")
                {
                    CalculatorClass.Op = '-';
                    CalculatorClass.Oprand1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;
                }

                else
                {
                    textBox1.Text = "-";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {

                    CalculatorClass.Oprand2 = textBox1.Text;
                    CalculatorClass.Oprand1 = CalculatorClass.CalculateAnswer().ToString();
                    CalculatorClass.Op = '-';
                    label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;
                    textBox1.Text = "";
                }
                else
                {
                    CalculatorClass.Op = '-';
                }
                label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;

            }
        }


        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (CalculatorClass.Op == ' ')
                {
                    CalculatorClass.Op = ' ';
                    CalculatorClass.Oprand1 = textBox1.Text;
                    textBox1.Text = "";
                    label1.Text = CalculatorClass.Oprand1 + CalculatorClass.Op;
                }
                else
                {

                    CalculatorClass.Oprand2 = textBox1.Text;
                    CalculatorClass.Oprand1 = CalculatorClass.CalculateAnswer().ToString();
                    label1.Text = CalculatorClass.Oprand1;
                    CalculatorClass.Op = ' ';
                    textBox1.Text = CalculatorClass.Oprand1;

                }
            }
        }


    }
}