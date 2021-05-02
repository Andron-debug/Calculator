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
        char action;
        double num;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void num_click(object sender, EventArgs e)
        {
            Button key = (Button)sender;
            switch (key.Text)
            {
                case "0":
                    if (textBox1.Text != "0") textBox1.Text += "0";
                        break;
                case ",":
                    if (!(textBox1.Text.Contains(','))) textBox1.Text += ",";
                    break;
                default:
                    if (textBox1.Text == "0") textBox1.Text = "";
                    textBox1.Text += key.Text;
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void plus_minus_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text[0] != '0') && (textBox1.Text[0] != '-')) textBox1.Text = "-" + textBox1.Text;
            else if (textBox1.Text[0] == '-') textBox1.Text = textBox1.Text.Substring(1);    
        }

        private void selecting_an_action(object sender, EventArgs e)
        {
            Button key = (Button)sender;
            action = key.Text[0];
            num = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            double num2 = Double.Parse(textBox1.Text);
            switch (action)
            {
                case '+': 
                    textBox1.Text = (Convert.ToString(num + num2));
                    break;
                case '-':
                    textBox1.Text = (Convert.ToString(num - num2));
                    break;
                case '*':
                    textBox1.Text = (Convert.ToString(num * num2));
                    break;
                case '/':
                    textBox1.Text = (Convert.ToString(num/num2));
                    break;
                case '^':
                    textBox1.Text = (Convert.ToString(Math.Pow(num, num2)));
                    break;
                case '√':
                    textBox1.Text = (Convert.ToString(Math.Pow(num, 1/num2)));
                    break;
                default:
                    MessageBox.Show("Действие не выбрано");
                    break;
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "") textBox1.Text = "0";
        }
    }
}
