using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Wall : GameObject
    {
        public Wall() : base() { }
        public Wall(char sign) : base(sign)
        {
            LoadLevel(2);
        }

        public void LoadLevel(int level)
        {
            FileStream fs = new FileStream(@"C:\pp2\Week-6\snake\Levels\Level1.txt", FileMode.Open,FileAccess.Read);
            //string name = string.Format("Level/Level{0}.txt", level);
            StreamReader sr = new StreamReader(fs);
            
                int r = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    for (int c = 0; c < line.Length; ++c)
                    {
                        if (line[c] == '#')
                        {
                        body.Add(new Point(c, r));
                    }
                    }
                    r++;
                }
               
            }
        /*public bool CheckIntersection1(Point p)
        {
            bool res = false;
            for (int i = 0; i < body.Count; i++)
            {
                if (p.X == body[i].X && p.Y == body[i].Y)
                {
                    res = true;
                }
            }
            return res;
        }*/
    }
    }

