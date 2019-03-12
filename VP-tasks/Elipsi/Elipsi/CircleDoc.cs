using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipsi
{
   public class CircleDoc
    {
        public List<Circle> circles;
        

        public CircleDoc()
        {
            circles = new List<Circle>();
            
        }

        public void AddCircleToList(Circle c)
        {
            circles.Add(c);
        }

        public void DrawFillElipse(Graphics g)
        {
           foreach(var c in circles)
            {
                c.DrawFillElipse(g);
            }

        }

      /*   public void DrawElipse(Graphics g)
         {
              for(int i=circles.Count; i>=0; i--)
             {
                 if (i == circles.Count)
                 {
                     circles[i].DrawElipse(g);
                 }else
                 {
                     circles[i].DrawFillElipse(g);
                 }

             }


         }*/
    }
}
