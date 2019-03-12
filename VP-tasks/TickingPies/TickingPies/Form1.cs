using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickingPies
{
    public partial class Form1 : Form
    {
        private PieDoc piti;
        private Pie pie;
        private bool isRuning;

        public Form1()
        {
            InitializeComponent();
            piti = new PieDoc();
            isRuning = false;
            this.DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pie = new Pie(e.Location);
            piti.AddPie(pie);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            piti.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            piti.EatPie();
            Invalidate(true);
        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isRuning)
            {
                timer1.Start();
                sTARTToolStripMenuItem.Text = "STOP";
                isRuning = true;
            }else
            {
                timer1.Stop();
                sTARTToolStripMenuItem.Text = "START";
                isRuning = false;
            }
            
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Pies: {0}", piti.pies.Count);
        }
    }
}
