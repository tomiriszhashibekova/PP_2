using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Circles
    {
        public GraphicsPath g2;
        int x;
        int y;
        public Circles(int x, int y)
        {
            this.x = x;
            this.y = y;
            g2 = new GraphicsPath();
            g2.AddEllipse(x, y, 10, 10);
        }
        public void Draw()
        {
            g2.AddEllipse(x, y, 10, 10);
        }
    }
}
