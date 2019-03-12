using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingObjects
{
    public class Square : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Square(float x, float y, Color c, float w, float h) : base(x, y, c)
        {
            Width = w;
            Height = h;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            g.FillRectangle(br, X - (Width / 2), Y - (Height / 2), Width, Height);
            br.Dispose();
        }

        public override bool isHit(float x, float y)
        {
            return Math.Abs(X - x) <= Width / 2 && Math.Abs(Y - y) <= Height / 2;
        }

        public override bool isCircle()
        {
            return false;
        }

        public override bool isSquare()
        {
            return true;
        }
   
    }
}
