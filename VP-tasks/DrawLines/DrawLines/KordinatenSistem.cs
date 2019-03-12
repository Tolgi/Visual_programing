using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    public class KordinatenSistem
    {
        public Point Center { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public KordinatenSistem(int w, int h)
        {
            width = w;
            height = h;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Red, 2);
            g.DrawLine(p, Center.X, 0, Center.X, height);
            g.DrawLine(p, 0, Center.Y, width, Center.Y);

            p.Dispose();
        }
    }
}
