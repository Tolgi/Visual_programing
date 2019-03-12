using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsChaos3
{
    public partial class Form1 : Form
    {
        private BallDoc topcinja;
        private Ball topce;
        private Random r;
        

        public Form1()
        {
            InitializeComponent();
            topcinja = new BallDoc();
            timer1.Start();
            this.DoubleBuffered = true;
            r = new Random();
            for (int i=0; i<4; i++)
            {

                int x = r.Next(2*BlackBall.Radius, this.Width - 2*BlackBall.Radius);
                int y = r.Next(2*BlackBall.Radius, this.Height - 2*BlackBall.Radius);
                Point center = new Point(x, y);
                BlackBall blackBall = new BlackBall(center);
                topcinja.AddBlackBall(blackBall);
             
            }

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          /*  r = new Random();
            int dirx = r.Next(2);
            int diry = r.Next(2);
            if(dirx == 0)
            {
                dirx = -1;
            }else
            {
                dirx = 1;
            }

            if(diry == 0)
            {
                diry = -1;
            }else
            {
                dirx = 1;
            }*/
            topce = new Ball(e.Location);
            topcinja.AddBall(topce);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            topcinja.Draw(e.Graphics);
            topcinja.DrawBlackBalls(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            topcinja.Move(this.Width, this.Height);
            topcinja.isHit();
            Invalidate();
        }
    }
}
