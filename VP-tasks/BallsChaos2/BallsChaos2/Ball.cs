using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsChaos2
{
   public class Ball
    {
        public Point Center { get; set; }
        public static int Radius = 30;
        public int velocityX = 5;
        public int velocityY = 5;
        public bool isColided { get; set; }

        public int dirX { get; set; }
        public int dirY { get; set; }

        public Ball(Point center, int DirX, int DirY)
        {
            Center = center;
            dirX = DirX;
            dirY = DirY;
            isColided = false;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.DeepPink);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            br.Dispose();
        }

        public bool IsHit(Point otherCenter)
        {
            double d = Math.Sqrt(((Center.X - otherCenter.X) * (Center.X - otherCenter.X)) + ((Center.Y - otherCenter.Y) * (Center.Y - otherCenter.Y)));
            return d <= 2 * Radius;
        }

        public void Move(int width, int height)
        {
            int newX = Center.X + velocityX * this.dirX;
            int newY = Center.Y + velocityY * this.dirY;
            Point newCenter = new Point(newX, newY);
            Center = newCenter;

            if (Center.X+10+Radius >= width)
            {
                this.velocityX = velocityX * (-1);
                
            }

            if (Center.Y + 5+2*Radius >= height)
            {
                this.velocityY = velocityY * (-1);
            }

            if(Center.X + Radius <= 2*Radius)
            {
                this.velocityX = velocityX * (-1);
            }

            if (Center.Y + Radius <= 2*Radius)
            {
                this.velocityY = velocityY * (-1);
            }

        }
    }
}
