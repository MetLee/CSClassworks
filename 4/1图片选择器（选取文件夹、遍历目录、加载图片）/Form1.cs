using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            var ret = folder.ShowDialog();
            if (ret == DialogResult.Cancel)
                return;
            else
            {
                string dir = folder.SelectedPath;
                label1.Text = dir;

                SearchOption so = checkBox1.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                var files = Directory.GetFiles(dir, "*.jpg", so);
                foreach (var file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem.ToString();
            pictureBox1.Image = Image.FromFile(name);
            FileInfo fi = new FileInfo(name);
        }
    }
}
