using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polygons
{
    public partial class Form1 : Form
    {
        private PolygonDoc polygons;
        private Polygon polygon;
        public Form1()
        {
            InitializeComponent();
            polygons = new PolygonDoc();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            polygon = new Polygon();
            polygon.AddPoint(point);
            polygons.AddPolygon(polygon);
            Invalidate();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            polygons.Draw(e.Graphics);
        }
    }
}
