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

        private void Parse_It_Click(object sender, EventArgs e)
        {
            double d;
            if(Double.TryParse(textBox1.Text, out d))
            {
                MessageBox.Show(d.ToString());
            }
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text[0] != '0') && (textBox1.Text[0] != '-')) textBox1.Text = "-" + textBox1.Text;
            else if (textBox1.Text[0] == '-') textBox1.Text = textBox1.Text.Substring(1);    
        }
    }
}
