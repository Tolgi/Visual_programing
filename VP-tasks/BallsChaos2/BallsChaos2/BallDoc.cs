using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsChaos2
{
    public class BallDoc
    {
        public List<Ball> topcinja;

        public BallDoc()
        {
            topcinja = new List<Ball>();

        }

        public void Draw(Graphics g)
        {
            foreach (var b in topcinja)
            {
                b.Draw(g);
            }
        }


        public void Move(int width, int height)
        {
            foreach (var b in topcinja)
            {
                b.Move(width, height );
            }
        }

        public void AddToBalls(Ball ball)
        {
            topcinja.Add(ball);
        }

        public void isColiding()
        {
            if (topcinja.Count > 1)
            {
                for (int i = 0; i < topcinja.Count; i++)
                {
                    for (int j = i+1; j < topcinja.Count; j++)
                    {
                        if (topcinja[i].IsHit(topcinja[j].Center))
                        {
                            topcinja[i].isColided = true;
                            topcinja[j].isColided = true;
                        }
                    }
                }
            }

            for(int i=0; i<topcinja.Count; i++)
            {
                if (topcinja[i].isColided)
                {
                    topcinja.RemoveAt(i);
                }
            }
        }

    }
}

