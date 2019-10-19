using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(DrawGraph.Draw);
            DrawParas drawParas = new DrawParas();

            drawParas.graphics = panel1.CreateGraphics();
            drawParas.count = 200;
            drawParas.maxH = panel1.Height;
            drawParas.maxW = panel1.Width;


            t1.IsBackground = true;
            t1.Start(drawParas);
        }
    }


    public class DrawGraph
    {
        public static void Draw(object o)
        {
            DrawParas drawParas = o as DrawParas;
            if (drawParas == null)
            {
                Exception e = new Exception();
                throw e;
            }

            Random random = new Random();
            for (int i = 0; i <= drawParas.count; i++)
            {
                var color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                SolidBrush solidBrush = new SolidBrush(color);
                var x = random.Next(drawParas.maxW);
                var y = random.Next(drawParas.maxH);
                var rect = new Rectangle(x, y, 50, 80);
                drawParas.graphics.FillEllipse(solidBrush, rect);
                Thread.Sleep(30);
            }
        }
    }

    public class DrawParas
    {
        public Graphics graphics;
        public int count;
        public int maxH;
        public int maxW;
    }
}
