using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface if1
    {
        void Say2();
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        public void SayHello()
        {
            Console.Write("Hello");

        }

        public virtual void Say1()
        {
            return;
        }
    }

    class Chinese: Person, if1
    {
        public void SayLove()
        {
            Console.Write("Love");
        }

        public void Say1()
        {
            Console.Write('1');
        }

        public void Say2()
        {
            Console.Write('2');
        }
    }
}
