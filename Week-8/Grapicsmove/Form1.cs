﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grapicsmove
{
    public partial class Form1 : Form
    {
        int x1, x2, y2 = 0;

        bool mouseClicked = false;
        Bitmap bitmap;
        Graphics g;

        public int x, y, r = 0;
        Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Gold, Color.Gray };
        Random random = new Random();

        int y1 = 0;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r = 50;

            y1 = y1 - 15;
            int index1 = random.Next(0, colors.Length - 1);
            Pen pen1 = new Pen(colors[index1], 3);
            g.FillEllipse(pen1.Brush, x1, y1, r, r);
            pictureBox1.Refresh();
            g.Clear(Color.White);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!mouseClicked)
            {
                x = e.Location.X;
                y = e.Location.Y;
                x1 = e.Location.X;
                y1 = e.Location.Y;
                x2 = e.Location.X;
                y2 = e.Location.Y;
                timer1.Start();
                mouseClicked = true;
            }
            else
            {
                mouseClicked = false;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            r = 50;
            x2 = x2 - 15;
            int index2 = random.Next(0, colors.Length - 1);
            Pen pen2 = new Pen(colors[index2], 3);
            g.FillEllipse(pen2.Brush, x2, y2, r, r);
            pictureBox1.Refresh();
            g.Clear(Color.White);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            r = 50;
            x = x + 15;
            int index = random.Next(0, colors.Length - 1);
            Pen pen = new Pen(colors[index], 3);
            g.FillEllipse(pen.Brush, x, y, r, r);
            pictureBox1.Refresh();
            g.Clear(Color.White);
        }
    }
}
