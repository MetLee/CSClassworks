using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    interface IUDP
    {
        void Send(string str);
        void ReceiveListening();
    }

    public delegate void ReceiveCompleteHandle(object sender, string msg);

    

    public partial class Form1 : Form
    {
        private Chat chat = new Chat("10.74.67.255");
        public Form1()
        {
            InitializeComponent();
        }

        internal Chat Chat { get => chat; set => chat = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = label1.Text + ':' + textBox1.Text;
            chat.Send(msg);
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBox2.Text = "准备";
            chat.recCompleted += Chat_recCompleted;
            Task task = new Task(chat.ReceiveListening);
            task.Start();
     
        }

        private void Chat_recCompleted(object sender, string msg)
        {
            textBox2.AppendText(msg+'\n');
        }
    }

    class Chat : IUDP
    {
        public string NetAdress { get; set; }
        public event ReceiveCompleteHandle recCompleted;
        public Chat(string adress)
        {
            NetAdress = adress;
        }
        public void Send(string msg)
        {
            UdpClient udpClient = new UdpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(NetAdress), 9001);
            byte[] buffer = Encoding.Default.GetBytes(msg);
            udpClient.Send(buffer, buffer.Length, iPEndPoint);
        }
        public void ReceiveListening()
        {
            UdpClient udpClient = new UdpClient(9001);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while(true)
            {
                byte[] buffer = udpClient.Receive(ref iPEndPoint);
                string msg = Encoding.Default.GetString(buffer);
                recCompleted(this, msg);
            }
        }

    }
}
