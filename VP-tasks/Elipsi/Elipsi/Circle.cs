using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipsi
{
    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public bool isDraw { get; set; }

        public Circle(Point center)
        {
            Center = center;
            isDraw = false;

        }

        public void DrawFillElipse(Graphics g)
        {
            Brush br = new SolidBrush(Color.Red);
            g.FillEllipse(br, Center.X, Center.Y, Width, Height);
            br.Dispose();
           
        }

        public void DrawElipse(Graphics g)
        {
            Pen br = new Pen(Color.Black, 2);
            g.DrawEllipse(br, Center.X , Center.Y, Width, Height);
            br.Dispose();
        }
    }
}
