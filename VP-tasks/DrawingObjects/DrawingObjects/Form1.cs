using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingObjects
{
    public partial class Form1 : Form
    {
        Shape shape;
        List<Shape> shapes;
        public Color currColor;
        public shapeType currShape;
        public bool mouseDown;

       public enum shapeType{
            Circle,
            Square
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            shapes = new List<Shape>();
            currColor = Color.Red;
            currShape = shapeType.Circle;
            this.DoubleBuffered = true;

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(currShape == shapeType.Circle)
            {
                Circle circle = new Circle(e.X, e.Y, currColor, 15);
                shapes.Add(circle);
                Graphics g = this.CreateGraphics();
                circle.Draw(g);
            }
            else if(currShape == shapeType.Square)
            {
                Square square = new Square(e.X, e.Y, currColor, 60, 50);
                shapes.Add(square);
                Graphics g = this.CreateGraphics();
                square.Draw(g);
            }

            Invalidate();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currShape = shapeType.Circle;
            circleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;

        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currShape = shapeType.Square;
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
        }

        private void pickColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                currColor = colorDialog.Color;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            shape = null;
            foreach (Shape s in shapes)
            {
                if(s.isHit(e.X, e.Y)){
                    if (s.isCircle())
                    {
                        Circle c = (Circle)s;
                        Pen p = new Pen(Color.Yellow, 6);
                        Graphics g = this.CreateGraphics();
                        g.DrawEllipse(p, c.X - c.Radius, c.Y-c.Radius, c.Radius * 2, c.Radius * 2);
                        p.Dispose();
                    }
                    
                    else if (s.isSquare())
                    {
                        Square sq = (Square) s;
                        Pen p = new Pen(Color.Yellow, 3);
                        Graphics g = this.CreateGraphics();
                        g.DrawRectangle(p, sq.X - (sq.Width / 2), sq.Y-(sq.Height/2), sq.Width, sq.Height);
                        p.Dispose();

                    }

                    shape = s;
                }
            }

            
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
             DrawAll(shapes, e.Graphics);
        }

        public void DrawAll(List<Shape> shapes, Graphics g)
        {
            foreach(Shape s in shapes)
            {
                s.Draw(g);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if(shape != null)
                {
                    float dx = e.X - shape.X;
                    float dy = e.Y - shape.Y;
                    shape.Move(dx, dy);
                   // Invalidate();
                }
            }
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
        }


            
            }
        }
    

