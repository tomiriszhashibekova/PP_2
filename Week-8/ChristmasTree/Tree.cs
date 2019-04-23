using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Tree
    {
        public GraphicsPath g1;
        int x;
        int y;
        public Tree(int x, int y)
        {
            this.x = x;
            this.y = y;
            g1 = new GraphicsPath();
            Point[] first =
           { new Point(x,y),
            new Point(x+20,y+20),
            new Point(x+40,y+40),
            new Point(x+100,y+80),
            new Point(x-100,y+80),
            new Point(x-40,y+40),
            new Point(x-20,y+20)
            };
            g1.AddCurve(first);
        }

    }
}

