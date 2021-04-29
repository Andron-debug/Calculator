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
            textBox1.Text = num_str;
        }

        string num_str = "0";
        private void num_click(object sender, EventArgs e)
        {
            Button key = (Button)sender;
            //if (num_str == "0") num_str = "";
            switch (key.Text)
            {
                case "0":
                    if (num_str != "0") num_str += "0";
                        break;
                case ",":
                    if (!(num_str.Contains(','))) num_str += ",";
                    break;
                default:
                    if (num_str == "0") num_str = "";
                    num_str += key.Text;
                    break;
            }
            textBox1.Text = num_str;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num_str = "0";
            textBox1.Text = num_str;
        }
    }
}
