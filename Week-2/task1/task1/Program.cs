using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\\pp1\Новая папка\test.txt", FileMode.Open, FileAccess.Read); // open file in shown path
            StreamReader sr = new StreamReader(fs); // read
            string str = sr.ReadLine(); // move file to line 
            sr.Close(); 
            fs.Close();
            char[] str2 = str.ToCharArray(); //create array of char ; convert string to char
            Array.Reverse(str2); // reverse it 
            string str3 = new string(str2); // compare two strings
            if (str == str3) 
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
            Console.ReadKey();
        }
    }
}
