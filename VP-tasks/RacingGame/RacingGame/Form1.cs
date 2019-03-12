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

namespace RacingGame
{
    [Serializable]
    public partial class Form1 : Form
    {
        int speed;
        PictureBox[] road;
        Random random;
        int score;
        private string FileName;
        public Form1()
        {
            InitializeComponent();
            road = new PictureBox[12];
            this.DoubleBuffered = true;
            RoadMover.Start();
            Enemy1_mover.Start();
            Enemy2_mover.Start();
            Enemy3_mover.Start();
            random = new Random();
            score = 0;
            FileName = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speed = 3;
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
            road[6] = pictureBox7;
            road[7] = pictureBox8;
            road[8] = Car;
            road[9] = enemy_car1;
            road[10] = enemy_car2;
            road[11] = enemy_car3;
        }

        private void RoadMover_Tick(object sender, EventArgs e)
        {
            for(int i=0; i<8; i++)
            {
                road[i].Top += speed;

                if (road[i].Top >= this.Height)
                {
                    road[i].Top = -road[i].Height;

                }
                
            }

            if(score > 10 && score < 20)
            {
                speed = 4;
            }

            if(score > 20 && score < 30)
            {
                speed = 5;
            }

            if(score > 30)
            {
                speed = 6;
            }

            speedText.Text = "Speed " + speed;
            

            if (Car.Bounds.IntersectsWith(enemy_car1.Bounds))
            {
                gameOver();
            }

            if (Car.Bounds.IntersectsWith(enemy_car2.Bounds))
            {
                gameOver();
            }

            if (Car.Bounds.IntersectsWith(enemy_car3.Bounds))
            {
                gameOver();
            }

        }

        private void gameOver()
        {
            btn_replay.Visible = true;
            endGame.Visible = true;
            RoadMover.Stop();
            Enemy1_mover.Stop();
            Enemy2_mover.Stop();
            Enemy3_mover.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                Right_mover.Start();
            }

            if (e.KeyCode == Keys.Left)
            {
                Left_mover.Start();
            }
        }

        private void Left_mover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X > 0)
            {
                Car.Left -= 5;
            }
            
        }

        private void Right_mover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X < 187)
            {
                Car.Left += 5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Right_mover.Stop();
            Left_mover.Stop();
        }

        private void Enemy1_mover_Tick(object sender, EventArgs e)
        {
            enemy_car1.Top += speed * 4/ 2;
            if(enemy_car1.Top >= this.Height)
            {
                score++;
                scoreText.Text = "Score " + score;
                enemy_car1.Top = -(int)((Math.Ceiling(random.NextDouble() * 150)) + enemy_car1.Height);
                enemy_car1.Left = (int)(Math.Ceiling(random.NextDouble() * 50)) + 0;
            }
        }



        private void Enemy2_mover_Tick(object sender, EventArgs e)
        {
            enemy_car2.Top += speed * 3 / 2;
            if (enemy_car2.Top >= this.Height)
            {
                score++;
                scoreText.Text = "Score " + score;
                enemy_car2.Top = -(int)((Math.Ceiling(random.NextDouble() * 150)) + enemy_car2.Height);
                enemy_car2.Left = (int)(Math.Ceiling(random.NextDouble() * 50)) + 100;
            }

        }

        private void Enemy3_mover_Tick(object sender, EventArgs e)
        {
            enemy_car3.Top +=  speed * 5 / 3;
            if (enemy_car3.Top >= this.Height)
            {
                score++;
                scoreText.Text = "Score " + score;
                enemy_car3.Top = -(int)((Math.Ceiling(random.NextDouble() * 150)) + enemy_car3.Height );
                enemy_car3.Left = (int)(Math.Ceiling(random.NextDouble() * 40)) + 150;
            }
        }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's')
            {
                if (FileName == null)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Racing Car docs (.bfd)|.bfd";
                    dialog.Title = "Save your racing car doc";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FileName = dialog.FileName;
                    }
                    try
                    {
                        using (FileStream stream = new FileStream(FileName, FileMode.Create))
                        {
                            var formatter = new BinaryFormatter();
                            formatter.Serialize(stream, (PictureBox[])road);
                            FileName = null;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while saving the file");
                    }

                }
            }

            if(e.KeyChar == 'o')
            {
                if (FileName == null)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "BRacing game docs (.bfd)|.bfd";
                    dialog.Title = "Open your racing game doc";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FileName = dialog.FileName;
                    }
                    try
                    {
                        using (FileStream stream = new FileStream(FileName, FileMode.Open))
                        {
                            var formatter = new BinaryFormatter();
                            road = (PictureBox[])formatter.Deserialize(stream);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while opening the file");
                    }

                }
            }
        }
    }
}
