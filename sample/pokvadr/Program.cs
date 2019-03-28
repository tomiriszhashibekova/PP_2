using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pokvadr
{
    class Program
    {
        public static Object obj = new Object();
        static void Main(string[] args)
        {
            Thread[] th = new Thread[4];
            for (int i = 0; i < 4; i++)
            {
                Console.CursorVisible = false;
                th[0] = new Thread(Line1);
                th[0].Start();
                th[1] = new Thread(Line2);
                th[1].Start();
                th[2] = new Thread(Line3);
                th[2].Start();
                th[3] = new Thread(Line4);
                th[3].Start();
            }
        }
        public static void Line1()
        {
            lock (obj)
            {
                for (int i = 1; i < 71; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(i, 1);
                    Console.WriteLine("X");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
        }
        public static void Line2()
        {
            lock (obj)
            {
                for (int i = 1; i < 41; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(70, i);
                    Console.WriteLine("X");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
        }
        public static void Line3()
        {
            lock (obj)
            {
                for (int i = 70; i >= 0; i--)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(i, 40);
                    Console.WriteLine("X");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
        }
        public static void Line4()
        {
            lock (obj)
            {
                for (int i = 40; i >= 0; i--)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(1, i);
                    Console.WriteLine("X");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
        }
    }
}

        
