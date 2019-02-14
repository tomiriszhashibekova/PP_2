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
        public int year = 1;  //create integer
        public Student(string n, string g) 
        {
            id = g;
            name = n;

        }
        public void Tapog()// making constructor
        {
            Console.WriteLine(name + " " + id + " ");
        }
        public void Sapog() //making constructor, which increment year
        {
            year++;
            Console.WriteLine(year);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ermekov", "18BD875640"); // use class for show two values together  
            s.Tapog(); // using Tapog

            s.Sapog(); // using Sapog
            Console.ReadKey();
        }
    }
}
