using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleFallsDown
{
    public partial class Form1 : Form
    {
        Random rn = new Random();
        
        List<Point> cPoint = new List<Point>();
        List<SolidBrush> brush = new List<SolidBrush>();
      //  SolidBrush brush = new SolidBrush(Color.Blue);
        int dy = 1;
        int r = 10;
       

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < cPoint.Count(); i++)
            {
               cPoint[i] = new Point(cPoint[i].X, cPoint[i].Y + dy);

                e.Graphics.FillEllipse(brush[i], new Rectangle(cPoint[i].X - r, cPoint[i].Y - r, 5 * r, 5 * r));
                

            }   

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            cPoint.Add(e.Location);
            brush.Add(new SolidBrush(Color.FromArgb(255, rn.Next(0, 225), rn.Next(0, 255), rn.Next(0, 255))));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
