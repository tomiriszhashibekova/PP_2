using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winter2
{
    public partial class Form1 : Form
    {
        int[] stX = new int[50];
        Random random = new Random();
        int[] stY = new int[50];
        int n = 0, period = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 1; i < n; i++)
            {
                Pen pen = new Pen(Color.Black);
                pen.Width = 4;
                e.Graphics.DrawPolygon(pen,
                    new Point[] 
                    {
                    new Point(stX[i],stY[i]),
                    new Point(stX[i]+50,stY[i]+100),
                    new Point(stX[i]-60,stY[i]+40),
                    new Point(stX[i]+60,stY[i]+40),
                    new Point(stX[i]-50,stY[i]+100)
                     });
                     
                SolidBrush brush = new SolidBrush(Color.Blue);

               /* e.Graphics.FillPolygon(brush,
                    new Point[]
                    {
                    new Point(stX[i],stY[i]),
                    new Point(stX[i]+50,stY[i]+100),
                    new Point(stX[i]-60,stY[i]+40),
                    new Point(stX[i]+60,stY[i]+40),
                    new Point(stX[i]-50,stY[i]+100)
                     });*/

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            period++;
            if (period == 60)
            {
                n++;
                for (int i = 1; i <= n; i++)
                {
                    stX[n] = random.Next(0, 100);
                    stY[n] = random.Next(50);
                }

                period = 0;

            }
            for (int i = 1; i <= n; i++)
            {
                stX[i]++;
                stY[i]++;
            }
            Refresh();
        }
    }
}
