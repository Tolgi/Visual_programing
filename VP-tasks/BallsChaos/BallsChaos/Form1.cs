using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsChaos
{
    public partial class Form1 : Form
    {
        private BallDoc ballDoc { get; set; }
        private int x { get; set; }
        private int y { get; set; }

        public Form1()
        {
            InitializeComponent();
            ballDoc = new BallDoc();
            timer1 = new Timer();
            timer1.Start();
            x = 20;
            y = 40;
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballDoc.Move(this.Width, this.Height);
            ballDoc.isColiding();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int dirX = r.Next(2);
            int dirY = r.Next(2);

            if (dirX == 0)
                dirX = -1;
            else
                dirX = 1;

            if (dirY == 0)
                dirY = -1;
            else
                dirY = 1;

            Ball b = new Ball(e.Location, dirX, dirY);
            ballDoc.AddBall(b);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Pen p = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(p, x, y, this.Width - 3*x, this.Height - 3*y);
            p.Dispose();
            ballDoc.Draw(e.Graphics);
           // ballDoc.Move();
        }
    }
}
