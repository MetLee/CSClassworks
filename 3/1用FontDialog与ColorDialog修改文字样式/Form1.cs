﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.sText = label1.Text;
            var ret = f.ShowDialog();
            if (ret == DialogResult.OK)
            {
                label1.Text = f.sText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new FontDialog();
            f.Font = label1.Font;
            var ret = f.ShowDialog();
            if (ret == DialogResult.OK)
            {
                label1.Font = f.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new ColorDialog();
            f.Color = label1.ForeColor;
            var ret = f.ShowDialog();
            if (ret == DialogResult.OK)
            {
                label1.ForeColor = f.Color;
            }
        }
    }
}
