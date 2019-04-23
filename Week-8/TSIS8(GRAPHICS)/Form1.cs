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

namespace TSIS8_GRAPHICS_
{
    public partial class Form1 : Form
    {
        SolidBrush mySolidBrushG = new SolidBrush(Color.Green);
        Pen penW = new Pen(Color.White);
        Pen penY = new Pen(Color.Yellow);
        Pen penG = new Pen(Color.Green);
        Pen penR = new Pen(Color.Red);
        //Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        { 
            //strelka
            Pen pen = new Pen(Color.Green,8);
            pen.StartCap = LineCap.ArrowAnchor;
            //pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, 275, 130, 275, 180);


             // ellipce 8
             Graphics graphics = CreateGraphics();
             Brush white = new SolidBrush(Color.Red);
             e.Graphics.FillEllipse(penW.Brush, 45, 55, 20, 20);
             e.Graphics.FillEllipse(penW.Brush, 50, 252, 20, 20);
             e.Graphics.FillEllipse(penW.Brush, 215, 40, 20, 20);
             e.Graphics.FillEllipse(penW.Brush, 350, 80, 20, 20);
             e.Graphics.FillEllipse(penW.Brush,520,140,20,20);
             e.Graphics.FillEllipse(penW.Brush,430,185, 20, 20);
             e.Graphics.FillEllipse(penW.Brush,500,280, 20, 20);
             e.Graphics.FillEllipse(penW.Brush, 200,220, 20, 20);

             //6-iyqolnik
             e.Graphics.FillRectangle(penY.Brush, 250, 130, 85, 50);
             Point[] myPointArray ={ new Point(250, 130), new Point(335, 130), new Point(292, 105) };
             e.Graphics.FillPolygon(penY.Brush, myPointArray);
             Point[] myPointArray1 = { new Point(250, 180), new Point(335, 180), new Point(292, 205) };
             e.Graphics.FillPolygon(penY.Brush, myPointArray1);

             //tip zvezda
             e.Graphics.FillRectangle(penG.Brush, 360, 150, 10, 10);
             Point[] myPointArray2 = { new Point(360, 150), new Point(370, 150), new Point(365, 130) };
             e.Graphics.FillPolygon(penG.Brush, myPointArray2);
             Point[] myPointArray3 = { new Point(360, 150), new Point(360, 160), new Point(340, 155) };
             e.Graphics.FillPolygon(penG.Brush, myPointArray3);
             Point[] myPointArray4 = { new Point(360, 160), new Point(370, 160), new Point(365, 180) };
             e.Graphics.FillPolygon(penG.Brush, myPointArray4);
            Point[] myPointArray5 = { new Point(370, 160), new Point(370, 150), new Point(390, 155) };
            e.Graphics.FillPolygon(penG.Brush, myPointArray5);
            //asteroids
            Point[] myPointArray6 = { new Point(90, 140), new Point(130, 140), new Point(110, 100) };
            e.Graphics.FillPolygon(penR.Brush, myPointArray6);
            Point[] myPointArray7 = { new Point(90, 110), new Point(130, 110), new Point(110, 150) };
            e.Graphics.FillPolygon(penR.Brush, myPointArray7);

            Point[] myPointArray8 = { new Point(460, 120), new Point(500, 120), new Point(480, 80) };
            e.Graphics.FillPolygon(penR.Brush, myPointArray8);
            Point[] myPointArray9 = { new Point(460, 90), new Point(500, 90), new Point(480, 130) };
            e.Graphics.FillPolygon(penR.Brush, myPointArray9);

            Point[] myPointArray10 = { new Point(140, 210), new Point(180, 210), new Point(160, 170) };
            e.Graphics.FillPolygon(penR.Brush, myPointArray10);
            Point[] myPointArray11 = { new Point(140, 180), new Point(180, 180), new Point(160, 220) };
            e.Graphics.FillPolygon(penR.Brush, myPointArray11);

            Point[] myPointArray12 = { new Point(360, 270), new Point(400, 270), new Point(380, 230) };
            e.Graphics.FillPolygon(penR.Brush, myPointArray12);
            Point[] myPointArray13 = { new Point(360, 240), new Point(400, 240), new Point(380, 280) };
            e.Graphics.FillPolygon(penR.Brush, myPointArray13);
            //strelka
            
            pen.StartCap = LineCap.ArrowAnchor;
            
            e.Graphics.DrawLine(pen, 292, 130, 292, 180);
            //Pen penn = new Pen(Color.Green, 8);
            //pen.EndCap = LineCap.RoundAnchor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
