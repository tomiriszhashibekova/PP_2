using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Food : GameObject
    {
       
        public Food(char sign) : base(sign)
        {
            
        }
        
        public void Generate(List<Point> wormBody, List<Point> wallBody)
        {
            body.Clear();
            Random random = new Random(DateTime.Now.Second);

            Point p = new Point(random.Next(0, 37), random.Next(1, 23));

            while (!IsGoodPoint(p, wormBody) || !IsGoodPoint(p, wallBody))
            {
                p = new Point(random.Next(0, 37), random.Next(1, 23));
            }
            body.Add(p);
        }
        bool IsGoodPoint(Point p,List<Point> points)
        {bool res = true;
            foreach (Point t in points)
            {
                

                if (p.X == t.X && p.Y == t.Y)
                {
                    res = false;
                    break;
                }
             }
            return res;

        }
    }
}
