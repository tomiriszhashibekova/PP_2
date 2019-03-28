using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace sfetaphot2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(func);

            myThread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Potok 1 vivodit " + i);
                Thread.Sleep(0);
            }

            Console.Read();
        }

         static void func()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Potok 2 vivodit " + i.ToString());
                Thread.Sleep(0);
            }
        }
    }
}
