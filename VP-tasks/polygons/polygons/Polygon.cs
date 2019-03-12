using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygons
{
    public class Polygon
    {
        public List<Point> points { get; set; }

        public Polygon()
        {
            points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            points.Add(point);
        }

        public void Draw(Graphics g)
        {
            if (points.Count > 1)
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawLines(p, points.ToArray());
                p.Dispose();
            }
        }
    }
}
