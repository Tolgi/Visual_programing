using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
   public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public bool tekovnaLinija { get; set; }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }


        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 3);
            g.DrawLine(p, Start, End);
            p.Dispose();
        }

        public bool theSamePoint(Point point)
        {
            if(Start.X == point.X && Start.Y == point.Y)
            {
                return true;
            }
            else
            {
                return false;

            }
                
        }

        public void Move(int dx, int dy)
        {
            Start = new Point(dx, dy);
            
        }
    }
}
