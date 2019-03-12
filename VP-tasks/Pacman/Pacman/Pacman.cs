using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Pacman
    {
        public int X;
        public int Y;
        public DIRECTION direction;
        public const int Radius = 20;
        public int Brzina;
        public bool usta = false;   
        public SolidBrush br = new SolidBrush(Color.Yellow);

        public enum DIRECTION
        {
            LEFT,
            RIGHT,
            UP,
            DOWN
        }

        public Pacman()
        {
            Brzina = 20;
            X = 7;
            Y = 5;
            direction = DIRECTION.RIGHT;
        }

        public void ChangeDirection(DIRECTION d)
        {
            direction = d;
        }

        public void Move(int x, int y)
        {
            

            if (direction == DIRECTION.RIGHT)
            {
                if (X == x - 1)
                {
                    X = 0;
                }
                X++;
            }
            else if (direction == DIRECTION.LEFT)
            {
                if (X == 0)
                {
                    X = x - 1;
                }
                X--;
            }
            else if (direction == DIRECTION.DOWN)
            {
                if (Y == y - 1)
                {
                    Y = 0;

                }
                Y++;

            }
            else if (direction == DIRECTION.UP)
            {
                if (Y == 0)
                {
                    Y = y - 1;
                }
                Y--;
            }
        }

        public void Draw (Graphics g)
        {
            if (!usta)
            {
                g.FillEllipse(br, X, Y, Radius * 2, Radius * 2);
                usta = true;
             
            }else
            {
                g.FillPie(br, X, Y, Radius * 2, Radius * 2, 45, 270);
                usta = false;
            
            }
        }


    }
}
