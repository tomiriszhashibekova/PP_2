using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asem1
{
    public partial class Form1 : Form
    {
        bool clicked = false;
        Bitmap bitmap;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        public int x, y, r = 0;
        Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Gold, Color.Gray };
        Random random = new Random();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!clicked)
            {
                x = e.Location.X;
                y = e.Location.Y;
                r = 1;                                                                                                      
                timer1.Start();
                clicked = true;
            }
            else
            {
                clicked = false;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r += 10;
            int index = random.Next(0, colors.Length - 1);
            Pen pen = new Pen(colors[index], 3);
            g.FillEllipse(pen.Brush, x - r, y - r, 2 * r, 2 * r);
            Refresh();
        }
    }
}
