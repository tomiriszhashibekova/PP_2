using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());//converting line written by keyboard to integer
            int[,] arr = new int[a, a]; //creating 2d array
            for (int i = 1; i <= a; i++)
            {

                for (int j = 1; j <= i ; j++)

                    Console.Write("[*]");
                Console.WriteLine();
            }
        }
    }
}
