using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sfetaphor
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (int i = 10000; i >0; i -= 1000)
            {
           ;


                i -= 100;
                int num = 0;
                TimerCallback tm1 = new TimerCallback(colord1);
                TimerCallback tm2 = new TimerCallback(colord2);
                TimerCallback tm3 = new TimerCallback(colord3);
                Timer timer1 = new Timer(tm1, num, 0, i);
                i -= 250;
                Timer timer2 = new Timer(tm2, num, 0, i);
                i -= 500;
                Timer timer3 = new Timer(tm3, num, 0, i);
                Console.ReadLine();
            }
        }

        private static void colord1(object obj)
        {               
         
            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("{0}", "Go");
        }
        private static void colord2(object obj)
        {
          Console.BackgroundColor = ConsoleColor.Yellow; Console.WriteLine("{0}", "A little bit");
        }
        
        private static void colord3(object obj)
        {

            Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("{0}", "Wait");
        }

    }
}
