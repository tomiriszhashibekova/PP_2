using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace task2
{
    class Program
    {
        public static bool Prime(int num)
        {
            bool Isprime = true;
            if (num == 1)
            {
                Isprime = false;
            }
            if (num == 2)
            {
                Isprime = true; 
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Isprime = false;
                        break;
                    }
                }
            }
            return Isprime;
        }
        static bool Prime(string s)
        {
            return Prime(int.Parse(s));
        }

        static void Main(string[] args)
        {

            List<string> ans = new List<string>();
            FileStream fs = new FileStream(@"C:\\pp1\Новая папка\task2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            string[] str2 = str.Split();

            foreach (var f in str2)
            {
                if (Prime(f))
                {
                    ans.Add(f);
                }
            }
            sr.Close();
            fs.Close();


            FileStream neww = new FileStream(@"C:\\pp1\Новая папка\task2_ans.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fsl = new StreamWriter(neww);

            foreach (var t in ans)
            {
                fsl.Write(t + " ");
                Console.Write(t + " ");
            }
            fsl.Close();
            neww.Close();

        }
    }
}