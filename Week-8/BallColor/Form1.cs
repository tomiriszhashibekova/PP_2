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

namespace BallColor
{
    public partial class Form1 : Form
    {
        bool Der = false;
        int a = 100;
        int b = 100;
        int r = 30;
        int a1 = 200;
        int b1 = 200;
        bool isVisible = false;
        SolidBrush brush = new SolidBrush(Color.Red);
        SolidBrush brush1 = new SolidBrush(Color.Red);

        GraphicsPath gp = new GraphicsPath();
        GraphicsPath gp1 = new GraphicsPath();
        public Form1()
        {
            InitializeComponent();
            gp.AddEllipse(new Rectangle(a - r, b - r, 2 * r, 2 * r));
            gp1.AddEllipse(new Rectangle(a1 - r, b1 - r, 2 * r, 2 * r));

        }
        bool Again = false;
        bool Qwert = false;
        int cnt = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPath(brush, gp);
            e.Graphics.FillPath(brush1, gp1);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isVisible = false;
            Der = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isVisible)
            {
                a = e.Location.X - r;
                b = e.Location.Y - r;
                gp.Reset();
                brush.Color = Color.Green;
                gp.AddEllipse(new Rectangle(a, b, 2 * r, 2 * r));
                Refresh();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gp.IsVisible(e.Location) && Again == false)
            {
                isVisible = true;
                Again = true;
                brush.Color = Color.DarkRed;
                Refresh();
                cnt++;
            }
            else if (gp.IsVisible(e.Location) && Again == true)
            {
                isVisible = true;
                brush.Color = Color.Red;
                Again = false;
                Refresh();
            }
            if (gp1.IsVisible(e.Location) && Qwert == false)
            {
                Der = true;
                Qwert = true;
                brush1.Color = Color.DarkRed;
                Refresh();
                cnt++;
            }
            else if (gp1.IsVisible(e.Location) && Qwert == true)
            {
                Der = true;

                brush1.Color = Color.Red;
                Qwert = false;
                Refresh();
            }
            if (cnt == 2)
            {
                Refresh();
                brush.Color = Color.White;
                brush1.Color = Color.White;

            }

        }
    }
}
