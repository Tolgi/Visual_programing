using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsChaos
{
   public class Ball
    {
        public static int Radius = 20;
        public Point Center { get; set; }
        public bool isColided { get; set; }
        public Random r;
        public int velocityX { get; set; }
        public int velocityY { get; set; }
        public int dX { get; set; }
        public int dY { get; set; }


        public Ball(Point center, int x, int y)
        {
            Center = center;
            r = new Random();
            velocityX = 10;
            velocityY = 10;
            dX = x;
            dY = y;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Purple);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            br.Dispose();

        }

        public bool isColiding(Point center)
        {
            double rastojanie = Math.Sqrt(((Center.X - center.X) * (Center.X - center.X)) + ((Center.Y - center.Y) * (Center.Y - center.Y)));
            return rastojanie <=  10+Radius;
        }

        public void Move(Point center, int width, int height)
        {
            Point p = new Point();
            p.X = center.X + velocityX * dX;
            p.Y = center.Y + velocityY * dY;

            if(p.X + 2*Radius >= width)
            {
                velocityX = -velocityX;
            }
            if(p.Y + 3*Radius >= height)
            {
                velocityY = -velocityY;
            }

            if(p.Y - Radius <= 0)
            {
                velocityY = -velocityY;
            }

            if (p.X - Radius <= 0)
            {
                velocityX = -velocityX;
            }


            Center = p;

        }


    }
}
