using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    public partial class Form1 : Form
    {
        int r = 10, dx = 1;
        Pen pen = new Pen(Color.Black);
        List<Point> men1 = new List<Point>();
        List<Point> men2 = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            men1.Add(new Point(20, 20));
            men1.Add(new Point(20, 30));
            men1.Add(new Point(10, 40));
            men1.Add(new Point(30, 40));
            men1.Add(new Point(20, 60));
            men1.Add(new Point(10, 80));
            men1.Add(new Point(30, 80));
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, new Rectangle(men1[0].X - r, men1[0].Y - r, 2 * r, 2 * r));
            e.Graphics.DrawLine(pen, men1[1], men1[2]);
            e.Graphics.DrawLine(pen, men1[1], men1[3]);
            e.Graphics.DrawLine(pen, men1[1], men1[4]);
            e.Graphics.DrawLine(pen, men1[4], men1[5]);
            e.Graphics.DrawLine(pen, men1[4], men1[6]);
            for (int i = 0; i < 7; ++i)
                men1[i] = new Point(men1[i].X + dx, men1[i].Y);
        }
    }
}
