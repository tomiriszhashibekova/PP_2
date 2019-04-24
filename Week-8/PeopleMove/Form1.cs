using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleMove
{
    public partial class Form1 : Form
    {
        GraphicsPath gp = new GraphicsPath();
        GraphicsPath gp1 = new GraphicsPath();

        Pen pen3 = new Pen(Color.Gray);

        int x = 250;
        int y = 200;
        int r = 20;
        int x1 = 150;
        int y1 = 220;
        int r1 = 15;
        Graphics g;
        bool mouseClicked = false;
        bool again = false;
        public Form1()
        {
            InitializeComponent();
            x = x + 15;
            gp.AddEllipse(new Rectangle(x, y, r, r));
            Point p1 = new Point(x + r / 2, y + r);
            Point p2 = new Point(x + r / 2, y + 2 * r);
            Point p3 = new Point(x + r / 2 + 10, y + r + 5);
            Point p4 = new Point(x + r / 2 - 10, y + r + 5);
            Point p5 = new Point(x + r / 2 + 10, y + 3 * r + 10);
            Point p6 = new Point(x + r / 2 - 10, y + 3 * r + 10);


            gp.AddLine(p1, p2);
            gp.AddLine(p1, p3);
            gp.AddLine(p1, p4);
            gp.AddLine(p2, p5);
            gp.AddLine(p2, p6);
            gp1.AddEllipse(new Rectangle(x1, y1, r1, r1));
            Point p11 = new Point(x1 + r1 / 2, y1 + r1);
            Point p22 = new Point(x1 + r1 / 2, y1 + 2 * r1);
            Point p33 = new Point(x1 + r1 / 2 + 10, y1 + r1 + 5);
            Point p44 = new Point(x1 + r1 / 2 - 10, y1 + r1 + 5);
            Point p55 = new Point(x1 + r1 / 2 + 10, y1 + 3 * r1 + 10);
            Point p66 = new Point(x1 + r1 / 2 - 10, y1 + 3 * r1 + 10);


            gp1.AddLine(p11, p22);
            gp1.AddLine(p11, p33);
            gp1.AddLine(p11, p44);
            gp1.AddLine(p22, p55);
            gp1.AddLine(p22, p66);
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            Refresh();
        }
        bool a = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            again = true;
            Refresh();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (again == true)
            {
                x = x + 15;
                gp.Reset();
                gp.AddEllipse(new Rectangle(x, y, r, r));
                Point p1 = new Point(x + r / 2, y + r);
                Point p2 = new Point(x + r / 2, y + 2 * r);
                Point p3 = new Point(x + r / 2 + 20, y + r + 5);
                Point p4 = new Point(x + r / 2 - 20, y + r + 5);
                Point p5 = new Point(x + r / 2 + 20, y + 3 * r + 10);
                Point p6 = new Point(x + r / 2 - 20, y + 3 * r + 10);


                gp.AddLine(p1, p2);
                gp.AddLine(p1, p3);
                gp.AddLine(p1, p4);
                gp.AddLine(p2, p5);
                gp.AddLine(p2, p6);

                Refresh();
                x1 = x1 - 15;
                gp1.Reset();
                gp1.AddEllipse(new Rectangle(x1, y1, r1, r1));
                Point p11 = new Point(x1 + r1 / 2, y1 + r1);
                Point p22 = new Point(x1 + r1 / 2, y1 + 2 * r1);
                Point p33 = new Point(x1 + r1 / 2 + 10, y1 + r1 + 5);
                Point p44 = new Point(x1 + r1 / 2 - 10, y1 + r1 + 5);
                Point p55 = new Point(x1 + r1 / 2 + 10, y1 + 3 * r1 + 10);
                Point p66 = new Point(x1 + r1 / 2 - 10, y1 + 3 * r1 + 10);


                gp1.AddLine(p11, p22);
                gp1.AddLine(p11, p33);
                gp1.AddLine(p11, p44);
                gp1.AddLine(p22, p55);
                gp1.AddLine(p22, p66);
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue);
            Pen pen1 = new Pen(Color.Green);
            Pen pen2 = new Pen(Color.Yellow);

            Graphics graphics = e.Graphics;
            graphics.FillRectangle(pen.Brush, 0, 0, this.Width, this.Height / 2);
            graphics.FillRectangle(pen1.Brush, 0, this.Height / 2, this.Width, this.Height / 2);
            graphics.FillEllipse(pen2.Brush, 80, 50, 100, 100);
            graphics.FillEllipse(pen.Brush, 110, 50, 80, 80);


            Bullet(550, 100, e);
            Bullet(350, 40, e);
            Bullet(420, 80, e);
            Bullet(600, 120, e);

            e.Graphics.FillPath(pen4.Brush, gp);
            e.Graphics.FillPath(pen4.Brush, gp1);
            LittlePerson(400, 300, 50, e);

        }

        private void Bullet(int x, int y, PaintEventArgs e)
        {
            int y1 = y + 5;
            int y2 = y - 5;
            int x1 = x + 5;
            int x2 = x - 5;

            Point point1 = new Point(x, y1 + 10);
            Point point2 = new Point(x + 5, y1);
            Point point3 = new Point(x - 5, y1);
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints);
            e.Graphics.FillRectangle(pen3.Brush, x - 5, y2, 10, 10);
            Point point4 = new Point(x, y2 - 10);
            Point point5 = new Point(x + 5, y2);
            Point point6 = new Point(x - 5, y2);
            Point[] curvePoints1 =
             {
                 point4,
                 point5,
                 point6,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints1);

            Point point7 = new Point(x1 + 10, y);
            Point point8 = new Point(x1, y + 5);
            Point point9 = new Point(x1, y - 5);
            Point[] curvePoints2 =
             {
                 point7,
                 point8,
                 point9,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints2);
            Point point10 = new Point(x2 - 10, y);
            Point point11 = new Point(x2, y + 5);
            Point point12 = new Point(x2, y - 5);
            Point[] curvePoints3 =
             {
                 point10,
                 point11,
                 point12,
             };
            e.Graphics.FillPolygon(pen3.Brush, curvePoints3);
        }
        Pen pen4 = new Pen(Color.Red, 6);
        Pen pen5 = new Pen(Color.Black, 5);

        private void LittlePerson(int x, int y, int r, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(pen4.Brush, x, y, r, r);
            Point p1 = new Point(x + r / 2, y + r);
            Point p2 = new Point(x + r / 2, y + 2 * r);
            Point p3 = new Point(x + r / 2 + 10, y + r + 5);
            Point p4 = new Point(x + r / 2 - 10, y + r + 5);
            Point p5 = new Point(x + r / 2 + 10, y + 3 * r + 10);
            Point p6 = new Point(x + r / 2 - 10, y + 3 * r + 10);


            e.Graphics.DrawLine(pen5, p1, p2);
            e.Graphics.DrawLine(pen5, p1, p3);
            e.Graphics.DrawLine(pen5, p1, p4);
            e.Graphics.DrawLine(pen5, p2, p5);
            e.Graphics.DrawLine(pen5, p2, p6);

            //   timer1.Start();



        }





    }
}