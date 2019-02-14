using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student // create class
    {
        public string name; // create string 
        public string id;   // create string 
        public int year = 0;  //create integer
        public Student(string n, string g) // making metod 
        {
            id = g;
            name = n;

        }
        public void Tapog()// making metod .sdsd
        {
            Console.WriteLine(name + " " + id + " ");
        }
        public void Sapog() //making metod, which increment year
        {
            year++;
            Console.WriteLine(year);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ermekov", "3.5"); // use metod
            s.Tapog(); // using Tapog

            s.Sapog(); // using Sapog
            Console.ReadKey();
        }
    }
}
