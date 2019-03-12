using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
   public class Pie
    {
        public Point Center { get; set; }
        public static int Radius = 30;
        public int stepen { get; set; }

        public Pie(Point center)
        {
            Center = center;
            stepen = 360;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.MediumSeaGreen);
            g.FillPie(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 0, stepen);
            br.Dispose();
        }

       public void EatPie()
        {
            stepen = stepen - 90;

        }
    }
}
