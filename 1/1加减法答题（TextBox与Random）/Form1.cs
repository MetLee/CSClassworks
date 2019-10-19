using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private int a, b;

        public Form1()
        {
            InitializeComponent();
            var rd = new Random();
            a = rd.Next(1,100);
            b = rd.Next(1,100);
            label1.Text = Convert.ToString(a);
            label3.Text = Convert.ToString(b);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = Convert.ToInt32(textBox1.Text);
            if (input == a + b)
            {
                MessageBox.Show("对");
            }
            else
            {
                MessageBox.Show("错");
            }
        }
    }
}
