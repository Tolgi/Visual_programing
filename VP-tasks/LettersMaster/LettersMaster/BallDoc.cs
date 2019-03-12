using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersMaster
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> topcinja { get; set; }
        public int hits { get; set; }
        public int miss { get; set; }

        public BallDoc()
        {
            topcinja = new List<Ball>();
            hits = 0;
            miss = 0;
        }

        public void Draw(Graphics g)
        {
            foreach(var b in topcinja)
            {
                b.Draw(g);
            }
        }

        public void Move()
        {
            foreach(var b in topcinja)
            {
               // int dx = b.Center.X + Ball.Velocity;
                int dy = b.Center.Y + Ball.Velocity;
                Point newPoint = new Point(b.Center.X, dy);
                b.Move(newPoint);
            }
        }

        public void AddBall(Ball b)
        {
            topcinja.Add(b);
                
        }

        public void isHit(char pretisnataBukva)
        {
            foreach(var c in topcinja)
            {
                if (c.isHit(char.ToUpper(pretisnataBukva)))
                {
                    c.pogodena = true;
                    hits++;
                }
            }

        }

        public void izbrisiPogodeni(int height)
        {
            for(int i=0; i<topcinja.Count; i++)
            {
                if (topcinja[i].pogodena)
                {
                    topcinja.RemoveAt(i);
                }

                if(topcinja[i].Center.Y >= height)
                {
                    topcinja.RemoveAt(i);
                    miss++;
                }
            }
        }
    }
}
