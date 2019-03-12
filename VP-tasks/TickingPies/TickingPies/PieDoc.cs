using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
   public class PieDoc
    {
        public List<Pie> pies;

        public PieDoc()
        {
            pies = new List<Pie>();
        }

        public void Draw(Graphics g)
        {
            foreach(var p in pies)
            {
                if (p.stepen > 0)
                {
                    p.Draw(g);
                }
            }
        }

        public void AddPie(Pie pie)
        {
            pies.Add(pie);
        }

        public void EatPie()
        {
           for(int i=0; i<pies.Count; i++) { 
                if (pies[i].stepen > 0)
                {
                    pies[i].EatPie();
                }
            }
        }
    }
}
