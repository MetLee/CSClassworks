using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{

   

    public partial class Form2 : Form
    {

        public string para = "==";

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string p)
        {
            InitializeComponent();
            para = p;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = para;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
