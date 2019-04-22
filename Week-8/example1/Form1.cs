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

namespace example1
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Green);
        SolidBrush solidBrush = new SolidBrush(Color.Red);
        HatchBrush hBrush = new HatchBrush(HatchStyle.ZigZag, Color.Black, Color.FromArgb(255, 255, 255, 255));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();

            Brush red = new SolidBrush(Color.Red);
            Pen pen = new Pen(red, 4);
              e.Graphics.DrawArc(pen, 50, 50, 50, 50, 180, 90);
              e.Graphics.DrawLine(pen, 40, 50, 300, 300);
              e.Graphics.DrawEllipse(pen, 0, 0, 200, 200);
            e.Graphics.FillEllipse(pen.Brush, 140, 150, 200, 200);


              e.Graphics.FillEllipse(solidBrush, 240, 100, 200, 200);

            e.Graphics.FillEllipse(hBrush, 340, 50, 200, 200);

              GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding);
             graphicsPath.AddRectangle(new Rectangle(30, 30, 100, 100));
              graphicsPath.AddEllipse(new Rectangle(130, 30, 100, 100));
              graphicsPath.AddLine(30, 30, 100, 100);

              e.Graphics.FillPath(pen.Brush, graphicsPath);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Point[] points = new Point[5];
            points[0] = new Point(250, 75);
            points[1] = new Point(150, 75);
            points[2] = new Point(250, 75);
            points[3] = new Point(50, 75);

            points[4]= new Point(150, 75);
            
  

            graphics.DrawPolygon(pen, points);

        }

        private void Form1_Load(object sender, EventArgs e)
        {   

        }
    }
}
