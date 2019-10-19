using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_student();
            f.ShowDialog();
        }
    }
}
