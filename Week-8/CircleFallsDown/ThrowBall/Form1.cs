using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThrowBall
{
    public partial class Form1 : Form
    {
        struct figure
        {
            int x0, y0;
            double angle;
            int x, y;
        }
        int r = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
