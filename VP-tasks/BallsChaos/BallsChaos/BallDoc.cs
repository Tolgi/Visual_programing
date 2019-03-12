using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsChaos
{
    public class BallDoc
    {
        public List<Ball> topcinja;
        public Random r;

        public BallDoc()
        {
            topcinja = new List<Ball>();
            r = new Random();
        }

        public void Draw(Graphics g)
        {
            foreach(var b in topcinja)
            {
                b.Draw(g);
            }
        }

        public void AddBall(Ball ball)
        {
            topcinja.Add(ball);
        }

        public void Move(int width, int height)
        {
           foreach(Ball b in topcinja)
            {
               
                b.Move(b.Center, width, height);
            }
        }

        public void isColiding()
        {
            if (topcinja.Count > 1)
            {
                for (int i = 0; i < topcinja.Count; i++)
                {
                    for (int j = i+1; j < topcinja.Count; j++)
                    {
                        if (topcinja[i].isColiding(topcinja[j].Center))
                        {
                            topcinja[i].isColided = true;
                            topcinja[j].isColided = true;
                        }
                    }
                }
            }


            for(int i=topcinja.Count-1; i>=0; i--)
            {
                if (topcinja[i].isColided)
                {
                    topcinja.RemoveAt(i);
                }
            }
        }
    }
}
