using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            var s = string.Format("X:{0}, Y:{1}", e.X, e.Y);
            toolStripStatusLabel1.Text = s;
        }
    }
}
