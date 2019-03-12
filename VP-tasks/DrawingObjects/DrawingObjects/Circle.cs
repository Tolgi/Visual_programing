using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingObjects
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(float x, float y, Color c, int radius) : base (x, y, c)
        {
            Radius = radius;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            g.FillEllipse(br, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            br.Dispose();
        }

        public override bool isHit(float x, float y)
        {
            double d = Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
            return d <= Radius;
        }

        public override bool isCircle()
        {
            return true;
        }

        public override bool isSquare()
        {
            return false;
         }

        

        }


    }

