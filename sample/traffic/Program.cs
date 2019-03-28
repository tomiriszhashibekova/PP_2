using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace traffic
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Thread th1 = new Thread(Red);
                th1.Start();
                Thread.Sleep(400);
                Thread th2 = new Thread(Yellow);
                th2.Start();
                Thread.Sleep(400);
                Thread th3 = new Thread(Green);
                th3.Start();
                Thread.Sleep(400);
            }
            public static void Red()
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            public static void Yellow()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            public static void Green()
            {
                Console.ForegroundColor = ConsoleColor.Green; ;
            }
        }
    }

