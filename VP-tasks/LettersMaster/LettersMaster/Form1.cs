using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettersMaster
{
    public partial class Form1 : Form
    {
        private BallDoc topcinja;
        private Random r;
        private int brojac;
        private char bukva;
        private string FileName;
        

        public Form1()
        {
            InitializeComponent();
            topcinja = new BallDoc();
            timer1.Start();
            this.DoubleBuffered = true;
            r = new Random();
            brojac = 0;
            FileName = null;
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (brojac % 10 == 0)
            {
                int x = r.Next(2 * Ball.Radius, this.Width - 2 * Ball.Radius);
                bukva = (char)((int)'A' + r.Next(26));
                Ball b = new Ball(new Point(x, -2 * Ball.Radius), bukva);
                topcinja.AddBall(b);
            }

            topcinja.Draw(e.Graphics);
            topcinja.izbrisiPogodeni(this.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            brojac++;
            topcinja.Move();
            Invalidate(true);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            topcinja.isHit(e.KeyChar);
            Invalidate(true);
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Hits: {0}", topcinja.hits);
        }

        private void toolStripStatusLabel2_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel2.Text = string.Format("Miss: {0}", topcinja.miss);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topcinja = new BallDoc();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Ball flying docs (*.bfd)|*.bfd";
                dialog.Title = "Save your flying doc";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;
                }
                try
                {
                    using (FileStream stream = new FileStream(FileName, FileMode.Create))
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(stream, (BallDoc)topcinja);
                        FileName = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving  the file");
                }

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Ball flying docs (.bfd)|.bfd";
                dialog.Title = "Open your flying doc";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;
                }
                try
                {
                    using (FileStream stream = new FileStream(FileName, FileMode.Open))
                    {
                        var formatter = new BinaryFormatter();
                        topcinja = (BallDoc)formatter.Deserialize(stream);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving  the file");
                }

            }

        }
        }
    }

