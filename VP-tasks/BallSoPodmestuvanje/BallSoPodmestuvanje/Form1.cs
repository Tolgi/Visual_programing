using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallSoPodmestuvanje
{
    public partial class Form1 : Form
    {
        private BallDoc topcinja;
        private bool isMouseDown;
        private Ball topce;
    

        public Form1()
        {
            InitializeComponent();
            topcinja = new BallDoc();
            this.DoubleBuffered = true;
            isMouseDown = false;
        }

       

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            topcinja.ClearSelected();
            Invalidate();
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            topcinja.isHit(e.Location);
            isMouseDown = true;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                topcinja.Move(e.Location);
                Invalidate();
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            topcinja.Draw(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Color color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            topce = new Ball(e.Location, color);
            topcinja.addBall(topce);
            Invalidate();
        }
    }
}
