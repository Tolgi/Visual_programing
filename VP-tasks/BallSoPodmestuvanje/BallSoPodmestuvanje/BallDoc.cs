using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallSoPodmestuvanje
{
    public class BallDoc
    {
        List<Ball> topcinja;

        public BallDoc()
        {
            topcinja = new List<Ball>();
        }

        public void Draw(Graphics g)
        {
            foreach(var b in topcinja)
            {
                b.Draw(g);
            }
        }

        public void Move(Point center)
        {
            foreach(var b in topcinja)
            {
                if (b.isSelected)
                {
                    b.Move(center);
                }
            }
        }

        public void isHit(Point center)
        {
            for(int i=topcinja.Count-1; i>=0; i--)
            {
                if (topcinja[i].isHit(center))
                {
                    topcinja[i].isSelected = true;
                   
                    return;
                }
            }
            
        }

        public void addBall(Ball b)
        {
            topcinja.Add(b);
        }

        public void ClearSelected()
        {
            foreach(var b in topcinja)
            {
                b.isSelected = false;
            }
        }
    }
}
