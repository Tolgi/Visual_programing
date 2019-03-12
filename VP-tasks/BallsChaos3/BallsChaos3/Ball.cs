using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsChaos3
{
    public class Ball
    {
        public Point Center { get; set; }
        public int Radius = 20;
        public bool isColided { get; set; }
        public double velocityX { get; set; }
        public double velocityY { get; set; }

        public int dirX { get; set; }
        public int dirY { get; set; }

        private double Velocity { get; set; }
        private double Angle { get; set; }

        public Ball (Point center)
        {
            Center = center;
            isColided = false;
            Velocity = 10;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            velocityX = (Math.Cos(Angle) * Velocity);
            velocityY = (Math.Sin(Angle) * Velocity);
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.MediumPurple);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            br.Dispose();
        }

        public bool isHit(Point otherCenter)
        {
            double d = Math.Sqrt(((Center.X - otherCenter.X) * (Center.X - otherCenter.X)) + ((Center.Y - otherCenter.Y) * (Center.Y - otherCenter.Y)));
            return d <= Radius + Radius;
        }

        public void Move(int w, int h)
        {
           double newX = this.Center.X + velocityX ;
           double newY = this.Center.Y + velocityY ;

            Point newCenter = new Point((int)newX, (int)newY);
            Center = newCenter;

            if(Center.X + 15+Radius >= w)
            {
                velocityX = -velocityX;
            }

            if(Center.Y + 2*Radius >= h)
            {
                velocityY = -velocityY;
            }

            if(Center.X <= Radius)
            {
                velocityX = -velocityX;
            }

            if(Center.Y <= Radius)
            {
                velocityY = -velocityY;
            }
        }
    }
}
