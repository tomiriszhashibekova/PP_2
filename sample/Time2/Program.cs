using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Timers.Timer timer = new System.Timers.Timer(100);
            timer.Elapsed += Elapse;

            timer.Enabled = true;
            Thread.CurrentThread.Join();
        }

        private static void Elapse(object sender, ElapsedEventArgs e)
        {
            string s = Console.ReadLine();
            DateTime time = DateTime.Now;
            Console.WriteLine(s[0] + " " + s[1] + " " + s[2] + " " + s[3] + " " + s[4] + " " + s[5]);

            Console.WriteLine(time.DayOfWeek + ": " + time.Hour + ":" + time.Minute + ":" + time.Second + ":" + time.Millisecond);
        }
    }
}