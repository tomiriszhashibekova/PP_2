using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        int x;
        int y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = Filter2(value);
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = Filter(value);
            }
        }

        int Filter(int v)
        {
            if (v > 23)
            {
                v = 1;
            }
            else if (v < 1)
            {
                v = 23;
            }
            return v;
        }
        int Filter2(int v)
        {
            if (v > 37)
            {
                v = 1;
            }
            else if (v <=1)
            {
                v = 37;
            }
            return v;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
