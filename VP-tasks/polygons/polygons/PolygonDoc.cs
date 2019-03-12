using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygons
{
    public class PolygonDoc
    {
        public List<Polygon> polygons { get; set; }

        public PolygonDoc()
        {
            polygons = new List<Polygon>();
        }

        public void AddPolygon(Polygon polygon)
        {
            polygons.Add(polygon);
        }

        public void Draw(Graphics g)
        {
            foreach(var p in polygons)
            {
                p.Draw(g);
            }
        }
    }
}
