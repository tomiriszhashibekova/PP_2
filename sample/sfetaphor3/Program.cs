using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sfetaphor3
{
    public class Student
    { }
        [Serializable]
    class Program
    {
        
        
            static Wall wall;
            static int cur = 0;
            static void Main(string[] args)
            {
                wall = new Wall();
                for (int x = 21; x <= 31; ++x)
            {
                
                if (x == 24 || x == 28)
                        continue;
                    for (int y = 21; y <= 23; ++y)
                    {
                        Point p = new Point(y, x);
                        wall.addPoint(p);
                    }
                }
            



            ThreadStart threadStart = new ThreadStart(move);
                Thread thread = new Thread(threadStart);
                thread.Start();
                Console.SetWindowSize(40, 40);
                while (true)
                {
                    if (cur == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (cur == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    if (cur == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                }
            List<Student> list = new List<Student>();
            FileStream fs = new FileStream("book.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(List<Student>));
            xm.Serialize(fs, list);
            fs.Close();

            FileStream fs1 = new FileStream("book.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            List<Student> list2 = (List<Student>)xm.Deserialize(fs1);
            fs1.Close();
            foreach (Student s in list2)
            {
                Console.WriteLine(s);
            }
        }
            public static void move()
            {
                while (true)
                {
                    wall.draw();
                    cur = cur + 1;
                    if (cur==0)
                    {
                        cur = 0;
                    }
                    Thread.Sleep(1000);
                if (cur == 1)
                {
                    cur = 1;
                }
                Thread.Sleep(1000);
                if (cur == 2)
                {
                    cur = 2;
                }
                Thread.Sleep(1000);
            }
            }

        }
    }
