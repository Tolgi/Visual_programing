using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsChaos2
{
    public partial class Form1 : Form
    {
        private BallDoc balls;


        public Form1()
        {
            InitializeComponent();
            balls = new BallDoc();
            timer1.Start();
            this.DoubleBuffered = true;
           

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int dirx = r.Next(2);
            int diry = r.Next(2);
            if(dirx == 1)
            {
                dirx = 1;
            }else
            {
                dirx = -1;
            }

            if (diry == 1)
            {
                diry = 1;
            }
            else
            {
                diry = -1;
            }

            Ball ball = new Ball(e.Location, dirx, diry);
            balls.AddToBalls(ball);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 3);
           // e.Graphics.DrawRectangle(p, 20, 20, this.Width - 65, this.Height-80);
           // p.Dispose();
            balls.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            balls.Move(this.Width, this.Height);
            balls.isColiding();
            Invalidate();
        }
    }
}
