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

namespace Flying_Balls___kolkviumska
{
    public partial class Form1 : Form
    {
        private BallDoc ballDoc { get; set; }
        private int timerCall { get; set; }
        private Random r;
        private string FileName;
        private bool isPaused;

        public Form1()
        {
            InitializeComponent();
            FileName = null;
            isPaused = false;
            timerCall = 0;
            ballDoc = new BallDoc(this.Width);
            timer1 = new Timer();
            timer1.Start();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPaused == false)
            {
                if (timerCall % 10 == 0)
                {
                    r = new Random();
                    var randomY = r.Next(2 * Ball.Radius, this.Height - (2 * Ball.Radius));
                    Ball b = new Ball(new Point(-Ball.Radius, randomY));
                    ballDoc.AddBall(b);
                }

                ballDoc.Move();
                Invalidate(true);
                timerCall++;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ballDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ballDoc.checkHit(e.X, e.Y);
            Invalidate(true);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ballDoc.Width = this.Width;
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Hits: {0}", ballDoc.Hits);
            toolStripStatusLabel2.Text = string.Format("Misses: {0}", ballDoc.Misses);


        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballDoc = new BallDoc(this.Width);
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FileName == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Balls doc file (*.bls)|*.bls";
                dialog.Title = "Save balls doc";
                dialog.FileName = FileName;
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;
                }
            }

            try
            {
                using(FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, (BallDoc)ballDoc);
                    FileName = null;

                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error while saving file!");
            }
        }

        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Balls doc file (*.bls)|*.bls";
                dialog.Title = "Open balls doc";
                dialog.FileName = FileName;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;
                }
            }

            try
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    ballDoc = (BallDoc)formatter.Deserialize(fileStream);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving file!");
            }
        }

        private void pausedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isPaused == false)
            {
                pausedToolStripMenuItem.Text = "Continue";
                isPaused = true;
            }else
            {
                pausedToolStripMenuItem.Text = "Paused";
                isPaused = false;
            }
        }
    }
}
