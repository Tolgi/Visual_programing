using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallSoPodmestuvanje
{
    public class Ball
    {
        public int Radius = 30;
        public Point Center { get; set; }
        public Color color { get; set; }
        public bool isSelected { get; set; }

        public Ball(Point center, Color c)
        {
            Center = center;
            isSelected = false;
            color = c;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(color);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            if (isSelected)
            {
                Pen p = new Pen(Color.Red, 3);
                g.DrawEllipse(p, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                p.Dispose();

            }
            br.Dispose();
            

        }

        public void Move(Point center)
        {
            Center = center;
        }

        public bool isHit(Point center)
        {
            double d = Math.Sqrt(((Center.X - center.X) * (Center.X - center.X)) + ((Center.Y - center.Y) * (Center.Y - center.Y)));
            return d <= Radius;
        }
    }
}
