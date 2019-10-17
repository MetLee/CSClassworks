using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string num1 { get; set; }
        private string op { get; set; }
        private bool isFirstDigit = true;

        private void AppendDigit(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.Text == ".")
            {
                if (label1.Text.Contains("."))
                    return;
                else if (isFirstDigit)
                    isFirstDigit = false;
                label1.Text += button.Text;
            }
            else
            {
                if (isFirstDigit)
                {
                    label1.Text = button.Text;
                    isFirstDigit = false;
                }
                else
                    label1.Text += button.Text;

            }
         
        }

        private void AppendOperation(object sender, EventArgs e)
        {
            var button = sender as Button;
            num1 = label1.Text;
            op = button.Text;
            label1.Text = "0";
            isFirstDigit = true;
        }

        private void Calc(object sender, EventArgs e)
        {
            var button = sender as Button;
            var a = double.Parse(num1);
            var b = double.Parse(label1.Text);
            double ret = 0;

            switch (op)
            {
                case "+":
                    ret = a + b;
                    break;
                case "-":
                    ret = a - b;
                    break;
                case "*":
                    ret = a * b;
                    break;
                case "/":
                    ret = a / b;
                    break;
            }

            label1.Text = ret.ToString();
            isFirstDigit = true;
        }
    }
}
