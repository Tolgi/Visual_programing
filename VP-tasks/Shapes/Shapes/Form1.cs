using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        Circle circle;
        Square square;
        ShapeType shape;
        Color currentColor;
        List<Circle> circles;
        List<Square> squares;
        public bool mouseDown;
        public int prevX;
        public int prevY;

        private enum ShapeType
        {
            Circle,
            Square
        }

        public Form1()
        {
            InitializeComponent();
            currentColor = Color.Blue;
            this.DoubleBuffered = true;
            circles = new List<Circle>();
            squares = new List<Square>();
        }


        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (shape == ShapeType.Circle)
            {
                circle = new Circle(e.X, e.Y, 25, currentColor);
                circles.Add(circle);
                Graphics g = this.CreateGraphics();
                circle.Draw(g);
            }
            else if (shape == ShapeType.Square)
            {
                square = new Square(e.X, e.Y, 58, 26, currentColor);
                squares.Add(square);
                Graphics g = this.CreateGraphics();
                square.Draw(g);

            }

            //Invalidate();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;
            shape = ShapeType.Circle;

        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squareToolStripMenuItem.Checked = true;
            circleToolStripMenuItem.Checked = false;
            shape = ShapeType.Square;

        }

        private void colorPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }

     /*   private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach(Circle c in circles)
            {
                if (c.isHit(e.X, e.Y))
                {
                     Pen P = new Pen(Color.Red, 2);
                     Graphics g = this.CreateGraphics();
                     g.DrawEllipse(P, c.X - c.radius, c.Y - c.radius, 2 * c.radius, 2 * c.radius);

                    P.Dispose();
                }
            }
        }*/

         

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            foreach (Circle c in circles)
            {
                if (c.isHit(e.X, e.Y))
                {
                    Pen P = new Pen(Color.Red, 2);
                    Graphics g = this.CreateGraphics();
                    g.DrawEllipse(P, c.X - c.radius, c.Y - c.radius, 2 * c.radius, 2 * c.radius);

                    P.Dispose();
                }
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                foreach (Circle c in circles)
                {
                    if (c.isHit(e.X, e.Y))
                    {
                        float dx = e.X - c.X;
                        float dy = e.Y - c.Y;

                        c.X += dx;
                        c.Y += dy;
                        Invalidate();
                    }
                }


            }

        }
    }
}
