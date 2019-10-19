using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(class1.print1);
            t1.IsBackground = true;
            t1.Start();
            var t2 = new Thread(class1.print2);
            t2.IsBackground = true;
            t2.Start();
            Thread.Sleep(3000);
            t1.Abort();
            t2.Abort();
        }
    }

    class class1
    {
        static public void print1()
        {
            Random random = new Random();
            while(true)
            {
                Thread.Sleep(random.Next(200));
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write('*');
            }
        }

        static public void print2()
        {
            Random random = new Random();
            while (true)
            {
                Thread.Sleep(random.Next(200));
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write('#');
            }
        }
    }

}
