using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elipsi
{
    public partial class Form1 : Form
    {
        private Circle c { get; set; }
        private CircleDoc circles { get; set; }
        private float width { get; set; }
        private float height { get; set; }
        private Point center { get; set; }
        private bool isClicked { get; set; }

        public Form1()
        {
            InitializeComponent();
            isClicked = false;
            this.DoubleBuffered = true;
            circles = new CircleDoc();
        }

    

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (!isClicked)
                {
                    circles.DrawFillElipse(e.Graphics);
                }else
                {
                    c.DrawElipse(e.Graphics); 
                   // circles.DrawElipse(e.Graphics);
                }
            }catch(Exception ex)
            {

            }
        }

        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                c.Width =  e.X - center.X;
                c.Height = e.Y - center.Y;
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            c = new Circle(e.Location);
            circles.AddCircleToList(c);
            center = e.Location;
            isClicked = true;
            Invalidate();
        }

      
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
           
            Invalidate();
        }
    }
}
