using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    public class LineDoc
    {
        public List<Line> lines;
        //public bool tekovnaTocka { get; set; }

        public LineDoc()
        {
            lines = new List<Line>();
           }

        public void Draw(Graphics g)
        {
            foreach(var l in lines)
            {
                l.Draw(g);
            }
        }

        public void AddLine(Line line)
        {
            lines.Add(line);
        }

        /*public void theSamePoint()
        {
            for(int i=0; i<lines.Count; i++)
            {
                for(int j=i+1; j<lines.Count; j++)
                {
                    if (lines[i].theSamePoint(lines[j].End))
                    {
                        Region r = new Region( , ,)
                    }
                }
            }
        }*/

        public void Move(int dx, int dy)
        {
            foreach(var l in lines)
            {
                if (l.tekovnaLinija)
                {
                    l.Move(dx, dy);
                }
            }
        }

        public void ClearTekovna()
        {
            foreach(var l in lines)
            {
                l.tekovnaLinija = false;
            }
        }
            
    }
}
