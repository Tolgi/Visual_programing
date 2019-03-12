using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsChaos3
{
   public class BlackBall
    {
        public static int Radius = 35;
        public Point Center { get; set; }

        public BlackBall(Point center)
        {
            Center = center;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Black);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            br.Dispose();
        }



    }
}
