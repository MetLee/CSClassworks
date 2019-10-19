using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("苹果");
            list.Add("水果");
            list.Add("南瓜");
            list.Add("西瓜");

            for (int i = 0;i < list.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new Point(20, 30 + i * 40);
                checkBox.Text = list[i];
                this.Controls.Add(checkBox);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> favArr = new List<string>();
            foreach (var obj in this.Controls)
            {
                if (obj is CheckBox)
                {
                    CheckBox checkBox = obj as CheckBox;
                    if (checkBox.Checked)
                    {
                        favArr.Add(checkBox.Text);
                    }
                }
            }
            string msg = string.Join("、",favArr.ToArray());
            MessageBox.Show("喜欢" + msg);
        }
    }
}
