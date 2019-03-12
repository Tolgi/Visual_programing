using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float radius { get; set; }
        public Color color { get; set; }

        public Circle(float x, float y, float r, Color c)
        {
            X = x;
            Y = y;
            radius = r;
            color = c;
        }

        public void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            g.FillEllipse(br, X - radius, Y - radius, 2 * radius, 2 * radius);
          //  Pen P = new Pen(Color.Black);
            //g.DrawEllipse(P, X - radius, Y - radius, 2 * radius, 2 * radius);

            br.Dispose();
           // P.Dispose();

        }

        public bool isHit(float x, float y)
        {
            double d = Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
            return d <= radius;
        }
    }
}
