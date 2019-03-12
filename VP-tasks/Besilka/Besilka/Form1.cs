using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Besilka
{
    public partial class Form1 : Form
    {
        private HangmanWorld game;
        private int timeElapsed;

        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        public void newGame()
        {
            game = new HangmanWorld("Macedonia");
            timer1.Start();
            pbWrong.Minimum = 0;
            pbWrong.Maximum = HangmanWorld.maxObidi;
           //// pbWrong.Value = 0;

            pbTime.Maximum = HangmanWorld.time;
            pbTime.Minimum = 0;
            pbTime.Value = HangmanWorld.time;
           

            timeElapsed = HangmanWorld.time;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed--;
            pbTime.Value = timeElapsed;
            pbWrong.Value = game.pogresniObidi;
            lblTimer.Text = String.Format("{0:00} : {1:00}", timeElapsed/60, timeElapsed%60);
            if(timeElapsed == 0 || game.pogresniObidi == HangmanWorld.maxObidi)
            {
                EndGame();
                return;
            }

            lblMask1.Text = game.MaskWord();
            txtPogodeniBukvi.Text = game.getAllLetters();

            
        }

        public void EndGame()
        {
            timer1.Stop();
            lblMask1.Text = game.Zbor;
            MessageBox.Show("Играта заврши!");
            DialogResult rez = MessageBox.Show("Дали сакате нова игра?","Нова игра", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                newGame();
            }else
            {

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!game.GuessLetter(Convert.ToChar(textBox1.Text)))
            {
                MessageBox.Show("Veke e vnesena soodvetnata bukva!");
            }
        }
    }
}
