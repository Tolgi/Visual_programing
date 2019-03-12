using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
       
        public CarDoc cars;
        public Random random; 
        public string FileName;

        public Form1()
        {
            InitializeComponent();
            cars = new CarDoc();
            FileName = null;
            this.DoubleBuffered = true;
            RoadMover.Start();
            Enemy1_mover.Start();
            Enemy2_mover.Start();
            Enemy3_mover.Start();
            random = new Random();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cars.AddCar((pictureBox1));
            cars.AddCar((pictureBox2));
            cars.AddCar((pictureBox3));
            cars.AddCar((pictureBox4));
            cars.AddCar((pictureBox5));
            cars.AddCar((pictureBox6));
            cars.AddCar((pictureBox7));
            cars.AddCar((pictureBox8));
            cars.AddCar((Car));
            cars.AddCar((enemy_car1));
            cars.AddCar((enemy_car2));
            cars.AddCar((enemy_car3));
           

        }

        private void RoadMover_Tick(object sender, EventArgs e)
        {
            for(int i=0; i<8; i++)
            {
                cars.Cars[i].Top += cars.speed;
       

                if (cars.Cars[i].Top >= this.Height)
                {
                    cars.Cars[i].Top = - cars.Cars[i].Height;

                }
                
            }

            if(cars.score  > 10 && cars.score < 20)
            {
                cars.speed = 4;
            }

            if(cars.score > 20 && cars.score < 30)
            {
                cars.speed = 5;
            }

            if(cars.score > 30)
            {
                cars.speed = 6;
            }


           lblSpeed.Text = "Speed " + cars.speed;

            if (cars.Cars.ElementAt(8).Bounds.IntersectsWith(enemy_car1.Bounds))
            {
                gameOver();
            }

            if (cars.Cars.ElementAt(8).Bounds.IntersectsWith(enemy_car2.Bounds))
            {
                gameOver();
            }

            if (cars.Cars.ElementAt(8).Bounds.IntersectsWith(enemy_car3.Bounds))
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


        private void newGame()
        {
            InitializeComponent();
            cars = new CarDoc();
            FileName = null;
            this.DoubleBuffered = true;
            RoadMover.Start();
            Enemy1_mover.Start();
            Enemy2_mover.Start();
            Enemy3_mover.Start();
            random = new Random();
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
            if (cars.Cars.ElementAt(8).Location.X > 0)
            {
                Car.Left -= 5;
            }
         

        }

        private void Right_mover_Tick(object sender, EventArgs e)
        {
            if (cars.Cars.ElementAt(8).Location.X < 187)
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
            cars.Cars.ElementAt(9).Top += cars.speed * 4/ 2;
            if(cars.Cars.ElementAt(9).Top >= this.Height)
            {
                cars.score++;
                lblScore.Text = "Score " + cars.score;
                cars.Cars.ElementAt(9).Top = -(int)((Math.Ceiling(random.NextDouble() * 150)) + cars.Cars.ElementAt(9).Height);
                cars.Cars.ElementAt(9).Left = (int)(Math.Ceiling(random.NextDouble() * 50)) + 0;
            }
           
        }



        private void Enemy2_mover_Tick(object sender, EventArgs e)
        {
            cars.Cars.ElementAt(10).Top += cars.speed * 3 / 2;
            if (cars.Cars.ElementAt(10).Top >= this.Height)
            {
               cars. score++;
                lblScore.Text = "Score " + cars.score;
                cars.Cars.ElementAt(10).Top = -(int)((Math.Ceiling(random.NextDouble() * 150)) + cars.Cars.ElementAt(10).Height);
                cars.Cars.ElementAt(10).Left = (int)(Math.Ceiling(random.NextDouble() * 50)) + 100;
            }
            

        }

        private void Enemy3_mover_Tick(object sender, EventArgs e)
        {
            cars.Cars.ElementAt(11).Top +=  cars.speed * 5 / 3;
            if (cars.Cars.ElementAt(11).Top >= this.Height)
            {
                cars.score++;
                lblScore.Text = "Score " + cars.score;
                cars.Cars.ElementAt(11).Top = -(int)((Math.Ceiling(random.NextDouble() * 150)) + cars.Cars.ElementAt(11).Height );
                cars.Cars.ElementAt(11).Left = (int)(Math.Ceiling(random.NextDouble() * 40)) + 150;
            }
           
        }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            newGame();
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
                    if (FileName != null)
                    {
                        using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                        {
                            IFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(fileStream, (CarDoc)cars);
                        }

                    }

                }

           
            }
            

            if(e.KeyChar == 'o')
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Circles doc file (*.plc)|*.plc";
                openFileDialog.Title = "Open circles doc file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = openFileDialog.FileName;
                    try
                    {
                        using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                        {
                            IFormatter formater = new BinaryFormatter();
                            cars = (CarDoc)formater.Deserialize(fileStream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not read file: " + FileName);
                        FileName = null;
                        return;
                    }
                    
                }
            }
        }

       
    }
}
