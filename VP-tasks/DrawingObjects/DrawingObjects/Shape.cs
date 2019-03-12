using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingObjects
{
   public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Color color { get; set; }
        

        public Shape(float x, float y, Color c)
        {
            X = x;
            Y = y;
            color = c;
        }

        public abstract void Draw(Graphics g);
        public abstract bool isHit(float x, float y);
        public abstract bool isCircle();
        public abstract bool isSquare();
      
        public void Move(float dx, float dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
