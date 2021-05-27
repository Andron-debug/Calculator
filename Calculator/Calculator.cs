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
        double m = 0;//память
        double rez = 0;
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
            textBox2.Text = "";
            action = ' ';
            rez = 0;
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
            rez = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox1.Text);
            switch (action)
            {
                case '+':
                    rez = rez + num2;
                    break;
                case '-':
                    rez = rez - num2;
                    break;
                case '*':
                    rez = rez * num2;
                    break;
                case '/':
                    if (num2 == 0) MessageBox.Show("Деленние на ноль");
                    else rez = rez / num2;
                    break;
                case '^':
                    rez = Math.Pow(rez, num2);
                    break;
                case '√':
                    if ((rez < 0) && (num2 % 2 == 0)) MessageBox.Show("Мнимое число");
                    else rez = Math.Pow(rez, 1 / num2);
                    break;
               
            }
            textBox1.Text = "0";
            textBox2.Text = key.Text;
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            double num2 = Double.Parse(textBox1.Text);
            switch (action)
            {
                case '+':
                    textBox1.Text = (Convert.ToString(rez + num2));
                    break;
                case '-':
                    textBox1.Text = (Convert.ToString(rez - num2));
                    break;
                case '*':
                    textBox1.Text = (Convert.ToString(rez * num2));
                    break;
                case '/':
                    if (num2 == 0) MessageBox.Show("Деленние на ноль");
                    else textBox1.Text = (Convert.ToString(rez / num2));
                    break;
                case '^':
                    textBox1.Text = (Convert.ToString(Math.Pow(rez, num2)));
                    break;
                case '√':
                    if ((rez < 0) && (num2 % 2 == 0)) MessageBox.Show("Мнимое число");
                    else textBox1.Text = (Convert.ToString(Math.Pow(rez, 1 / num2)));
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

        private void MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(m);
        }

        private void MC_Click(object sender, EventArgs e)
        {
            m = 0;
        }

        private void M_pluse_Click(object sender, EventArgs e)
        {
            m += Double.Parse(textBox1.Text);
        }

        private void M_minuse_Click(object sender, EventArgs e)
        {
            m -= Double.Parse(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_1x_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) != 0) textBox1.Text = Convert.ToString(1/double.Parse(textBox1.Text));
            else MessageBox.Show("Деленние на ноль");
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sin(double.Parse(textBox1.Text)));
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Cos(double.Parse(textBox1.Text)));
        }
    }
}
