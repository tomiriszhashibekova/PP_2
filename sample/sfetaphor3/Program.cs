using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sfetaphor3
{
    class Program
    {
        
        
            static Wall wall;
            static int cur = 0;
            static void Main(string[] args)
            {
                wall = new Wall();
                for (int x = 21; x <= 24; ++x)
                {
                    if (x == 24 || x == 28)
                        continue;
                    for (int y = 21; y <= 23; ++y)
                    {
                        Point p = new Point(y, x);
                        wall.addPoint(p);
                    }
                }
            for (int x = 25; x <= 28; ++x)
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
                    Thread.Sleep(3000);
                if (cur == 1)
                {
                    cur = 1;
                }
                Thread.Sleep(1000);
                if (cur == 2)
                {
                    cur = 2;
                }
                Thread.Sleep(2000);
            }
            }

        }
    }
