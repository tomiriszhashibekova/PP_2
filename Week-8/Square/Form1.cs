using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics gBitmap;
        bool mouseClicked;

        enum Tool
        {
            Pen,
            Rectangle,
            Ellipse,
            Triangle
        }
        Point prevPoint, curPoint;
        Tool tool;
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawRectangle(e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            prevPoint = e.Location;
        }
        Pen pen = new Pen(Color.Black, 1);
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            if (tool == Tool.Rectangle)
            {
                DrawRectangle(gBitmap);
            }
            else if (tool == Tool.Triangle)
            {
                DrawTriangle(gBitmap);
            }
        }

        private void DrawTriangle(Graphics g)
        {
            Point p1 = new Point(prevPoint.X, prevPoint.Y);
            Point p2 = new Point(curPoint.X, prevPoint.Y);
            Point p3 = new Point(prevPoint.X, curPoint.Y);
            Point[] curvePoints =
             {
                 p1,
                 p2,
                 p3,
             };
            g.DrawPolygon(pen, curvePoints);

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                if (tool == Tool.Pen)
                {
                    curPoint = e.Location;
                    gBitmap.DrawLine(pen, prevPoint, curPoint);
                    prevPoint = curPoint;
                }
                else if (tool == Tool.Rectangle)
                {
                    curPoint = e.Location;
                    //gBitmap.DrawRectangle(pen, prevPoint.X, prevPoint.Y, curPoint.X - prevPoint.X, curPoint.Y - prevPoint.Y);
                }
                else if (tool == Tool.Triangle)
                {
                    curPoint = e.Location;
                }
                pictureBox1.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gBitmap = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            mouseClicked = false;
            tool = Tool.Pen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tool.Pen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.Rectangle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tool = Tool.Triangle;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gBitmap = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            mouseClicked = false;
            tool = Tool.Pen;
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gBitmap = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            mouseClicked = false;
            tool = Tool.Pen;
        }

        public void DrawRectangle(Graphics g)
        {
            int minX = Math.Min(prevPoint.X, curPoint.X);
            int maxX = Math.Max(prevPoint.X, curPoint.X);
            int minY = Math.Min(prevPoint.Y, curPoint.Y);
            int maxY = Math.Max(prevPoint.Y, curPoint.Y);
            g.DrawRectangle(pen, minX, minY, maxX - minX, maxY - minY);
        }
    }
}