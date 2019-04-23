using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasTree
{
    public partial class Form1 : Form
    {
        SolidBrush color;
        Circles[] c1 = {
                new Circles(235, 75),
                 new Circles(250, 90),
                 new Circles(265, 105)
                    };
        Circles[] c2 = {
                new Circles(265, 140),
                 new Circles(250, 155),
                 new Circles(235, 170)
                    };
        Circles[] c3 = {
                new Circles(235, 190),
                 new Circles(250, 205),
                 new Circles(265, 220)
                    };
        Graphics ga;
        int cnt = 0;



        public Form1()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
            ga = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    


    private void timer1_Tick(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                for (int i = 0; i < c1.Length; i++)
                {
                    ga.FillPath(Brushes.Yellow, c1[i].g2);
                    ga.FillPath(Brushes.Yellow, c2[i].g2);
                    ga.FillPath(Brushes.Yellow, c3[i].g2);
                }
            }
            else if (cnt == 1)
            {
                for (int i = 0; i < c1.Length; i++)
                {
                    ga.FillPath(Brushes.Blue, c1[i].g2);
                    ga.FillPath(Brushes.Blue, c2[i].g2);
                    ga.FillPath(Brushes.Blue, c3[i].g2);
                }
            }
            else if (cnt == 2)
            {
                for (int i = 0; i < c1.Length; i++)
                {
                    ga.FillPath(Brushes.Orange, c1[i].g2);
                    ga.FillPath(Brushes.Orange, c2[i].g2);
                    ga.FillPath(Brushes.Orange, c3[i].g2);
                }
            }
            cnt++;
            cnt %= 3;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
                Tree t1 = new Tree(250, 50);
                e.Graphics.FillPath(Brushes.Green, t1.g1);
                Tree t2 = new Tree(250, 100);
                e.Graphics.FillPath(Brushes.Green, t2.g1);
                Tree t3 = new Tree(250, 150);
                e.Graphics.FillPath(Brushes.Green, t3.g1);


                e.Graphics.FillRectangle(Brushes.Brown, 230, 235, 50, 40);

                color = new SolidBrush(Color.Red);

                for (int i = 0; i < c1.Length; i++)
                {
                    e.Graphics.FillPath(color, c1[i].g2);
                }
        }
    }
 }
