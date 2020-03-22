using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_stiintific
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text += "1";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text += "5";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text += "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";
        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0.";
            else
                textBox1.Text += ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else if (textBox1.Text[textBox1.Text.Length - 1] == '+' ||
                textBox1.Text[textBox1.Text.Length - 1] == '-' ||
                textBox1.Text[textBox1.Text.Length - 1] == '*' ||
                textBox1.Text[textBox1.Text.Length - 1] == '/')
            {
                var temp = textBox1.Text;
                textBox1.Text = temp.Remove(textBox1.Text.Length - 1, 1) + "+";
            }
            else
                textBox1.Text += "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else if (textBox1.Text[textBox1.Text.Length - 1] == '+' ||
                textBox1.Text[textBox1.Text.Length - 1] == '-' ||
                textBox1.Text[textBox1.Text.Length - 1] == '*' ||
                textBox1.Text[textBox1.Text.Length - 1] == '/')
            {
                var temp = textBox1.Text;
                textBox1.Text = temp.Remove(textBox1.Text.Length - 1, 1) + "-";
            }
            else
                textBox1.Text += "-";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else if (textBox1.Text[textBox1.Text.Length - 1] == '+' ||
                textBox1.Text[textBox1.Text.Length - 1] == '-' ||
                textBox1.Text[textBox1.Text.Length - 1] == '*' ||
                textBox1.Text[textBox1.Text.Length - 1] == '/')
            {
                var temp = textBox1.Text;
                textBox1.Text = temp.Remove(textBox1.Text.Length - 1, 1) + "*";
            }
            else
                textBox1.Text += "*";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else if (textBox1.Text[textBox1.Text.Length - 1] == '+' ||
                textBox1.Text[textBox1.Text.Length - 1] == '-' ||
                textBox1.Text[textBox1.Text.Length - 1] == '*' ||
                textBox1.Text[textBox1.Text.Length - 1] == '/')
            {
                var temp = textBox1.Text;
                textBox1.Text = temp.Remove(textBox1.Text.Length - 1, 1) + "/";
            }
            else
                textBox1.Text += "/";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '+' ||
                textBox1.Text[textBox1.Text.Length - 1] == '-' ||
                textBox1.Text[textBox1.Text.Length - 1] == '*' ||
                textBox1.Text[textBox1.Text.Length - 1] == '/')
            {
                var temp = textBox1.Text;
                textBox1.Text = temp.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
            {
                double result = 0.0;
                char[] ops = { '+', '-', '*', '/' };
                List<char> operators = new List<char>();
                foreach (var i in textBox1.Text.ToString())
                    if (i == '+' || i == '/' || i == '*' || i == '-')
                        operators.Add(i);
                string[] numbers = textBox1.Text.Split(ops);
                result += Convert.ToDouble(numbers[0]);
                if (numbers.Length > 1)
                    for (var i = 1; i < numbers.Length; i++)
                        if (operators[i - 1] == '+')
                            result = result + Convert.ToDouble(numbers[i]);
                        else if (operators[i - 1] == '-')
                            result = result - Convert.ToDouble(numbers[i]);
                        else if (operators[i - 1] == '*')
                            result = result * Convert.ToDouble(numbers[i]);
                        else if (operators[i - 1] == '/')
                            result = result / Convert.ToDouble(numbers[i]);
                textBox1.Text += "=";
                textBox1.Text += result.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Count() - 1, 1);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
