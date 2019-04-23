using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls
{
    public partial class Form1 : Form
    {
        List<Point> balls = new List<Point>();
        List<SolidBrush> colors = new List<SolidBrush>();
        List<Pen> board = new List<Pen>();
        int last = -1;
        int r = 20;

        SolidBrush yellow = new SolidBrush(Color.Yellow);
        SolidBrush blue = new SolidBrush(Color.Blue);
        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush pink = new SolidBrush(Color.Pink);
        SolidBrush orange = new SolidBrush(Color.Orange);
        Pen black = new Pen(Color.Black);
        Pen white = new Pen(Color.White);

        public Form1()
        {
            InitializeComponent();
            balls.Add(new Point(20, 20));
            balls.Add(new Point(50, 50));
            balls.Add(new Point(80, 80));
            balls.Add(new Point(120, 120));
            balls.Add(new Point(80, 20));
            balls.Add(new Point(20, 80));
            balls.Add(new Point(200, 20));
            balls.Add(new Point(20, 200));
            balls.Add(new Point(150, 20));
            balls.Add(new Point(20, 150));
            colors.Add(yellow);
            colors.Add(yellow);
            colors.Add(blue);
            colors.Add(blue);
            colors.Add(pink);
            colors.Add(pink);
            colors.Add(red);
            colors.Add(red);
            colors.Add(orange);
            colors.Add(orange);
            for (int i = 0; i < 10; ++i)
                board.Add(white);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < balls.Count(); i++)
            {
                e.Graphics.FillEllipse(colors[i], new Rectangle(balls[i].X - r, balls[i].Y - r, 2 * r, 2 * r));
            }
            for (int i = 0; i < balls.Count(); i++)
            {
                e.Graphics.DrawEllipse(board[i], new Rectangle(balls[i].X - r, balls[i].Y - r, 2 * r, 2 * r));
            }
            Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < balls.Count(); ++i)
            {
                int len = (e.X - balls[i].X) * (e.X - balls[i].X) + (e.Y - balls[i].Y) * (e.Y - balls[i].Y);
                if (len <= r * r)
                {
                    if (board[i] == black)
                        board[i] = white;
                    else
                        board[i] = black;
                    if (last == -1)
                        last = i;
                    else
                    {
                        if (last != i && colors[last] == colors[i])
                        {
                            balls.RemoveAt(Math.Min(last, i));
                            balls.RemoveAt(Math.Min(last, i));
                            board.RemoveAt(Math.Min(last, i));
                            board.RemoveAt(Math.Min(last, i));
                            colors.RemoveAt(Math.Min(last, i));
                            colors.RemoveAt(Math.Min(last, i));
                            last = -1;
                        }
                        else
                            last = i;
                    }
                }

            }


        }
    }
}
