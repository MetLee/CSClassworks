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

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt|配置|*.ini";
            var ret = ofd.ShowDialog();
            if (ret != DialogResult.OK)
                return;

            string fname = ofd.FileName;

            FileStream fs = new FileStream(fname, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);

            textBox1.Clear();
            
            while (sr.EndOfStream)
            {
                textBox1.AppendText(sr.ReadLine() + Environment.NewLine);

            }
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt|配置|*.ini";
            var ret = ofd.ShowDialog();
            if (ret != DialogResult.OK)
                return;

            string fname = ofd.FileName;

            
            StreamReader sr = new StreamReader(fname, Encoding.Default);

            textBox1.Clear();
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".txt";
            var ret = sfd.ShowDialog();
            if (ret != DialogResult.OK)
                return;
            string fname = sfd.FileName;

            StreamWriter sw = new StreamWriter(fname, false, Encoding.Default);
            sw.Write(textBox1.Text);
        }
    }
}
