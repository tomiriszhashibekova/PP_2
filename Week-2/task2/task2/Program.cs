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
        public static bool Prime(int num) //craeting the method which check the prime number  
        {
            bool Isprime = true; // /making the parameter which is true  at the beginning
            if (num == 1) //checking one of the case
            {
                Isprime = false;
            }
            if (num == 2)
            {
                Isprime = true; 
            }
            else
            {
                for (int i = 2; i < num; i++)  //consider the divisors of the number
                {
                    if (num % i == 0)
                    {
                        Isprime = false;  // the number has dividers, then it's false; but we need the numbers without dividers, so we break the program
                        break;
                    }
                }
            }
            return Isprime;
        }
        static bool Prime(string s)
        {
            return Prime(int.Parse(s)); //convert string to integer
        }

        static void Main(string[] args)
        {

            List<string> ans = new List<string>();//create the list 
            FileStream fs = new FileStream(@"C:\\pp1\Новая папка\task2.txt", FileMode.Open, FileAccess.Read); //open file and read
            StreamReader sr = new StreamReader(fs); //read file"fs" with SR
            string str = sr.ReadLine(); // read string str
            string[] str2 = str.Split(); //creating an array with elements of the string type and separating them through spaces

            foreach (var f in str2) 
            {
                if (Prime(f)) // use the method
                {
                    ans.Add(f); // answer write in "F"
                }
            }
            sr.Close();
            fs.Close();


            FileStream neww = new FileStream(@"C:\\pp1\Новая папка\task2_ans.txt", FileMode.Create, FileAccess.Write); // create new file in given path
            StreamWriter fsl = new StreamWriter(neww); //// Access to write 

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