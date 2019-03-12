using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flying_Balls___kolkviumska
{
    [Serializable]
   public class Ball
    {
        public Point Center { get; set;}
        public int State { get; set; }
        public Random r;
        // state: 0-zeleno,  1-plavo,   2-crveno,    -1 - nadvor od ekran
        public static int Radius = 30; 

        public Ball(Point center)
        {
            Center = center;
            r = new Random();
            State = r.Next(3);
           
        }

        public void Draw(Graphics g)
        {
            if(State == 0)
            {
                Brush br = new SolidBrush(Color.Green);
                g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }

            if (State == 1)
            {
                Brush br = new SolidBrush(Color.Blue);
                g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }

            if (State == 2)
            {
                Brush br = new SolidBrush(Color.Red);
                g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
            
        }


        public bool isHit(int x, int y)
        {
            var rastojanie = ((Center.X - x) * (Center.X - x)) + ((Center.Y - y) * (Center.Y - y));
            return rastojanie <= Radius * Radius;
        }

        public void Move(Point newCenter)
        {
            Center = newCenter;

        }


    }
}
