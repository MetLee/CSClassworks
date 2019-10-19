using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        Guess guess = new Guess();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guess.TimesChanged += Guess_TimesChanged;
            guess.GameOK += Guess_GameOK;
            新建ToolStripMenuItem.PerformClick();
        }

        private void Guess_GameOK(object sender, EventArgs e)
        {
            MessageBox.Show("成功");
            button1.Enabled = false;
        }

        private void Guess_TimesChanged(object sender, EventArgs e)
        {
            label2.Text = guess.Times.ToString();
            if (bs != null)
                bs.ResetBindings(true);
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guess.New();
            label1.Text = guess.Answer;
            bs.DataSource = guess.logs;
            listBox1.DataSource = bs;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guess.Try(textBox1.Text);
        }
    }

    public class Guess
    {
        public string Answer { set; get; }
        public List<string> logs { set; get; }
        public int _times;
        public int Times
        {
            get { return _times; }
            set
            {
                _times = value;
                if (TimesChanged != null)
                {
                    TimesChanged(this, null);
                }
            }
        }

        public void New()
        {
            Times = 0;
            logs = new List<string>();
            Answer = CreateAnswer();
        }

        private string CreateAnswer()
        {
            string Answer = "";
            Random random = new Random();
            while (Answer.Length < 4)
            {
                string d = random.Next(10).ToString();
                if (Answer.IndexOf(d) < 0)
                    Answer += d;
            }
            return Answer;
        }
        public void Try(string userAns)
        {
            int allCorrect = 0;
            int numberCorrect = 0;
            if (userAns.Length != 4)
            {
                logs.Add("4位");
            }
            else
            {
                for (int i = 0;i < 4; i++)
                {
                    int pos = Answer.IndexOf(userAns[i]);
                    if (pos == 1)
                        allCorrect++;
                    else if (pos >= 0)
                        numberCorrect++;
                }
                string msg = string.Format("{0}A{1}B", allCorrect, numberCorrect);
                logs.Add((Times+1) + ":" + userAns + "," + msg);
                if (allCorrect == 4)
                    GameOK(this, null);
            }
            Times++;
        }
        public event EventHandler TimesChanged;
        public event EventHandler GameOK;
    }
}
