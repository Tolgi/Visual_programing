using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class Form1 : Form
    {
        private LineDoc lines { get; set; }
        private Point prva { get; set; }
        private Point vtora { get; set; }
        private Line line { get; set; }
        private KordinatenSistem ks { get; set; }

        private bool kliknanaPrva { get; set; }
        public Form1()
        {
            InitializeComponent();
            lines = new LineDoc();
           // prva = new Point();
            //vtora = new Point();
            kliknanaPrva = false;
            this.DoubleBuffered = true;
            ks = new KordinatenSistem(this.Width, this.Height);
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        { 
            if(prva.IsEmpty)
            {
                prva = new Point(e.X, e.Y);

            }
            else
            {
                if (vtora.IsEmpty)
                {
                    vtora = new Point(e.X, e.Y);

                }else
                {
                    prva = vtora;
                    vtora = new Point(e.X, e.Y);
                }
                line = new Line(prva, vtora);
                line.tekovnaLinija = true;
                lines.AddLine(line);
                Invalidate(true);
            }

            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lines.Draw(e.Graphics);
            ks.Draw(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ks.Center = e.Location;
            ks.width = this.Width;
            ks.height = this.Height;
            Invalidate(true);
        }

     

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Lines: {0}", lines.lines.Count);
        }
    }
}
