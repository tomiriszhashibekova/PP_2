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
            for (int i = 1; i < 1000; i++)
        {
                
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Cyan");

                Thread.Sleep(1000);
        }
            Thread myThread2 = new Thread(new ThreadStart(color2));
            myThread2.Start(); for (int i = 1; i < 100; i++)
            {
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("Magenta");

                Thread.Sleep(1000);
            }

            Console.ReadLine();

        }
        public static void color2()
        {
            for (int i = 1; i < 100; i++)
            {
               
                Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.Clear();
                Console.WriteLine("Yellow");
                Thread.Sleep(1000);
            }
        }

        public static void color1()
        {
            for (int i = 1; i < 100; i++)
            {

                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Green");
                Thread.Sleep(1000);
            }
        }
    }
}
