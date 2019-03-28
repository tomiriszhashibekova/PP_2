using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(func);
            Thread th2 = new Thread(punc);
            th.Start();
            th2.Start();
        }

        private static void func()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(4);
            }
        }

        private static void punc()
        {
            for (int i = 6; i <= 10; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(3);
            }

        }
    }
}
