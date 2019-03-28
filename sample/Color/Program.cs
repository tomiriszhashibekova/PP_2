using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Color
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(new ThreadStart(color1));
            myThread.Start();
            for (int i = 1; i < 100; i++)
        {
                Console.Clear();
                
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Green");

                Thread.Sleep(100);
        }
            Thread myThread2 = new Thread(new ThreadStart(color2));
            myThread2.Start(); for (int i = 1; i < 100; i++)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("CoCo");

                Thread.Sleep(100);
            }

            Console.ReadLine();

        }
        public static void color2()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Yellow");
                Thread.Sleep(200);
            }
        }

        public static void color1()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.Clear();
                
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Red");
                Thread.Sleep(200);
            }
        }
    }
}
