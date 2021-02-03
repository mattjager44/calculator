using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalcApp : Form
    {
        string input = string.Empty;
        string symbol1 = string.Empty;
        string symbol2 = string.Empty;
        char c;
        double Answer = 0;
        double num1, num2;

        public CalcApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;       
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
            this.input = string.Empty;
            this.symbol1 = string.Empty;
            this.symbol2 = string.Empty;
           
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
            this.input = string.Empty;
            this.symbol1 = string.Empty;
            this.symbol2 = string.Empty;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = 'S';
            input = string.Empty;
        }

        private void btnToPwr_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = '^';
            input = string.Empty;
        }

        private void btnPwrTo_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = 'P';
            input = string.Empty;
        }

        private void btnOneOver_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = 'R';
            input = string.Empty;
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = '/';
            input = string.Empty;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = 'X';
            input = string.Empty;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = '-';
            input = string.Empty;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = '+';
            input = string.Empty;
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            symbol2 = input;
            double.TryParse(symbol1, out num1);
            double.TryParse(symbol2, out num2);

            if (c == '+')
            {
                Answer = num1 + num2;
                textBox1.Text = Answer.ToString();
            }
            else if (c == '-')
            {
                Answer = num1 - num2;
                textBox1.Text = Answer.ToString();
            }

            else if (c == 'X')
            {
                Answer = num1 * num2;
                textBox1.Text = Answer.ToString();

            }

            else if (c == '/')
            {
                if (num2 != 0 )
                {
                    Answer = num1 / num2;
                    textBox1.Text = Answer.ToString();
                }
                else
                {
                    textBox1.Text = "!Error!";
                }
            }

            else if (c == '^')
            {
                Answer = num1 * num1;
                textBox1.Text = Answer.ToString();
            }

            else if (c == 'P')
            {
                Answer = Math.Pow(num1,num2);
                textBox1.Text = Answer.ToString();
            }

            else if (c == 'S')
            {
                Answer = Math.Sqrt(num1);
                textBox1.Text = Answer.ToString();
            }

            else if (c == 'R')
            {
                Answer = 1 / num1;
                textBox1.Text = Answer.ToString();
            }

            else if (c == 'x')
            {
                Answer = num1 * -1;
                textBox1.Text = Answer.ToString();
            }
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;

        }

        private void signFlip_Click(object sender, EventArgs e)
        {
            symbol1 = input;
            c = 'x';
            input = string.Empty;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
        }
       
    }
}
