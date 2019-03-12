using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsChaos3
{
   public class BallDoc
    {
        List<Ball> topcinja;
        List<BlackBall> blackBalls;

        public BallDoc()
        {
            topcinja = new List<Ball>();
            blackBalls = new List<BlackBall>();
        }

        public void Draw(Graphics g)
        {
            foreach(var b in topcinja)
            {
                b.Draw(g);
            }
        }


        //public void isHit() { 
        //   for(int i=0; i<topcinja.Count; i++)
        //    {
        //        for(int j=i+1; j<topcinja.Count; j++)
        //        {
        //            if (topcinja[i].isHit(topcinja[j].Center))
        //            {
        //                topcinja[i].isColided = true;
        //                topcinja[j].isColided = true;
        //            }
        //        }
        //    }

        //    for(int i=0; i<topcinja.Count; i++)
        //    {
        //        if (topcinja[i].isColided)
        //        {
        //            topcinja.RemoveAt(i);
        //        }
        //    }
        //}

        public void isHit()
        {
            for (int i = 0; i < topcinja.Count; i++)
            {
                for (int j = 0; j < blackBalls.Count; j++)
                {
                    if (topcinja[i].isHit(blackBalls[j].Center))
                    {
                        topcinja[i].isColided = true;
                        //topcinja[j].isColided = true;
                    }
                }
            }

            for (int i = 0; i < topcinja.Count; i++)
            {
                if (topcinja[i].isColided)
                {
                    topcinja.RemoveAt(i);
                }
            }
        }

        public void Move(int w, int y)
        {
            foreach(var b in topcinja)
            {
                b.Move(w, y);
            }
        }

        public void AddBall(Ball b)
        {
            topcinja.Add(b);
        }

        public void AddBlackBall(BlackBall b)
        {
            blackBalls.Add(b);
        }

        public void DrawBlackBalls(Graphics g)
        {
            foreach(var b in blackBalls)
            {
                b.Draw(g);
            }
        }
    }
}
