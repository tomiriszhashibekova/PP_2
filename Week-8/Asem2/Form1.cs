using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asem2
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = 25, y = 15, x1 = 65, y1 = 15;
        int widthofr = 95, heightofr = 45, x2 = 10, y2 = 75, x3 = 65, y3 = 75;
        Pen pen = new Pen(Color.Blue);
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
           
            g.DrawRectangle(pen, x - 30, y + 15, widthofr, heightofr);
            
            x2 += 6;
            y2 += 6;
            x3 += 6;
            y3 += 6;
            x += 6;
            y += 6;
            x1 += 6;
            y1 += 6;
        }
    }
}