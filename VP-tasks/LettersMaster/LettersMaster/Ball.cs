using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersMaster
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public static int Radius = 30;
        public static int Velocity = 10;
        public char Bukva { get; set; }
        public bool pogodena { get; set; }

        public Ball(Point center, char bukva)
        {
            Center = center;
            Bukva = bukva;
            pogodena = false;
        }

        public void Draw (Graphics g)
        {

            if (pogodena)
            {
                Brush b = new SolidBrush(Color.MediumVioletRed);
                g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                b.Dispose();
            }else
            {
                Brush br = new SolidBrush(Color.MediumSpringGreen);
                g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                br.Dispose();
            }
           
            Font f = new Font("Arial", 24);
            g.DrawString(string.Format("{0}", Bukva), f, Brushes.Black, Center.X - Radius / 2, Center.Y - Radius / 2);
         
        }

        public void Move(Point newCenter)
        {
            Center = newCenter;
        }

        public bool isHit(char pretisnataBukva)
        {
            if(Bukva == char.ToUpper(pretisnataBukva))
            {
                return true;
            }else
            {
               return false;
            }
        }

        

    }
}
