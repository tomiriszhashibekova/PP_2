using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1
{
    public class Student
    {

        public int A { get; set; }
        public int B { get; set; }
        //public int I { get; } // = -1;
        //public int X  { get; set; }
       

        public Student ()
        {
        }
        
        public void PrintInfo()
        {
            
            if (B > 0)
            {
                Console.WriteLine(A+"+" + B+"i");
            }
            else
            {
                Console.WriteLine(A+""+B+"i");
            }
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F1();
            F2();
        }
        private static void F1()
        {
            Student s = new Student();
            s.A = int.Parse(Console.ReadLine()); 
            s.B = int.Parse(Console.ReadLine());
         



            FileStream fs = new FileStream("student.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Student));

            xs.Serialize(fs, s);

            fs.Close();

        }
        private static void F2()
        {
            FileStream fs = new FileStream("student.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student s = xs.Deserialize(fs) as Student;
            s.PrintInfo();
            fs.Close();
        }
    }
}
