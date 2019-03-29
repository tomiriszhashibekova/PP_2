using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ИДЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread date = new Thread(Time);
            Thread substr = new Thread(String);
            date.Start();
            Thread.Sleep(100);
            substr.Start();
        }
        public static void Time()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("End.");
        }
        public static void String()
        {
            string s = "University";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s.Substring(i));
            }
            Console.WriteLine("End.");
        }


    }
}
