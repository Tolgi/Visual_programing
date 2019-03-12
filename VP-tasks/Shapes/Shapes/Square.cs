using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square
    {
        public int X { get; set; }
        public int Y { get; set; }
        public float Width  { get; set; }
        public float Height { get; set; }
        public Color color { get; set; }

        public Square(int x, int y, float w, float h, Color c)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
            color = c;
        }

        public void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            g.FillRectangle(br, X - (Width/2), Y - (Height/2), Width, Height);

            //Pen p = new Pen(Color.Red);
            //g.DrawRectangle(p, X - (Width / 2), Y - (Height / 2), Width, Height);

            br.Dispose();
           // p.Dispose();
        }
    }
}
