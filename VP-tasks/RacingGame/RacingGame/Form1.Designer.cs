namespace RacingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.Left_mover = new System.Windows.Forms.Timer(this.components);
            this.Right_mover = new System.Windows.Forms.Timer(this.components);
            this.enemy_car1 = new System.Windows.Forms.PictureBox();
            this.enemy_car2 = new System.Windows.Forms.PictureBox();
            this.enemy_car3 = new System.Windows.Forms.PictureBox();
            this.Enemy1_mover = new System.Windows.Forms.Timer(this.components);
            this.Enemy2_mover = new System.Windows.Forms.Timer(this.components);
            this.Enemy3_mover = new System.Windows.Forms.Timer(this.components);
            this.endGame = new System.Windows.Forms.Label();
            this.speedText = new System.Windows.Forms.Label();
            this.btn_replay = new System.Windows.Forms.Button();
            this.scoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(60, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(151, -30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 85);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.RoadMover_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(151, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 85);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(60, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 85);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(60, 198);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 85);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(151, 198);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 85);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(60, 320);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 85);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(151, 320);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 85);
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // Car
            // 
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(115, 291);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(30, 64);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 4;
            this.Car.TabStop = false;
            // 
            // Left_mover
            // 
            this.Left_mover.Interval = 10;
            this.Left_mover.Tick += new System.EventHandler(this.Left_mover_Tick);
            // 
            // Right_mover
            // 
            this.Right_mover.Interval = 10;
            this.Right_mover.Tick += new System.EventHandler(this.Right_mover_Tick);
            // 
            // enemy_car1
            // 
            this.enemy_car1.Image = ((System.Drawing.Image)(resources.GetObject("enemy_car1.Image")));
            this.enemy_car1.Location = new System.Drawing.Point(2, 134);
            this.enemy_car1.Name = "enemy_car1";
            this.enemy_car1.Size = new System.Drawing.Size(32, 67);
            this.enemy_car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_car1.TabIndex = 5;
            this.enemy_car1.TabStop = false;
            // 
            // enemy_car2
            // 
            this.enemy_car2.Image = ((System.Drawing.Image)(resources.GetObject("enemy_car2.Image")));
            this.enemy_car2.Location = new System.Drawing.Point(88, 35);
            this.enemy_car2.Name = "enemy_car2";
            this.enemy_car2.Size = new System.Drawing.Size(32, 62);
            this.enemy_car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_car2.TabIndex = 5;
            this.enemy_car2.TabStop = false;
            // 
            // enemy_car3
            // 
            this.enemy_car3.Image = ((System.Drawing.Image)(resources.GetObject("enemy_car3.Image")));
            this.enemy_car3.Location = new System.Drawing.Point(193, 172);
            this.enemy_car3.Name = "enemy_car3";
            this.enemy_car3.Size = new System.Drawing.Size(34, 64);
            this.enemy_car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_car3.TabIndex = 5;
            this.enemy_car3.TabStop = false;
            // 
            // Enemy1_mover
            // 
            this.Enemy1_mover.Enabled = true;
            this.Enemy1_mover.Interval = 10;
            this.Enemy1_mover.Tick += new System.EventHandler(this.Enemy1_mover_Tick);
            // 
            // Enemy2_mover
            // 
            this.Enemy2_mover.Enabled = true;
            this.Enemy2_mover.Interval = 10;
            this.Enemy2_mover.Tick += new System.EventHandler(this.Enemy2_mover_Tick);
            // 
            // Enemy3_mover
            // 
            this.Enemy3_mover.Enabled = true;
            this.Enemy3_mover.Interval = 10;
            this.Enemy3_mover.Tick += new System.EventHandler(this.Enemy3_mover_Tick);
            // 
            // endGame
            // 
            this.endGame.AutoSize = true;
            this.endGame.BackColor = System.Drawing.Color.White;
            this.endGame.Font = new System.Drawing.Font("Ravie", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGame.ForeColor = System.Drawing.Color.Red;
            this.endGame.Location = new System.Drawing.Point(29, 114);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(169, 30);
            this.endGame.TabIndex = 6;
            this.endGame.Text = "Game Over";
            this.endGame.Visible = false;
            // 
            // speedText
            // 
            this.speedText.AutoSize = true;
            this.speedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedText.ForeColor = System.Drawing.Color.Cornsilk;
            this.speedText.Location = new System.Drawing.Point(167, 9);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(60, 15);
            this.speedText.TabIndex = 7;
            this.speedText.Text = "Speed 0";
            // 
            // btn_replay
            // 
            this.btn_replay.BackColor = System.Drawing.Color.White;
            this.btn_replay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replay.ForeColor = System.Drawing.Color.Red;
            this.btn_replay.Location = new System.Drawing.Point(60, 175);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(101, 34);
            this.btn_replay.TabIndex = 8;
            this.btn_replay.Text = "Replay";
            this.btn_replay.UseVisualStyleBackColor = false;
            this.btn_replay.Visible = false;
            this.btn_replay.Click += new System.EventHandler(this.btn_replay_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Cornsilk;
            this.scoreText.Location = new System.Drawing.Point(-2, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(56, 15);
            this.scoreText.TabIndex = 7;
            this.scoreText.Text = "Score 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(224, 367);
            this.Controls.Add(this.btn_replay);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.speedText);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.enemy_car3);
            this.Controls.Add(this.enemy_car2);
            this.Controls.Add(this.enemy_car1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(240, 600);
            this.MinimumSize = new System.Drawing.Size(240, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Timer Left_mover;
        private System.Windows.Forms.Timer Right_mover;
        private System.Windows.Forms.PictureBox enemy_car1;
        private System.Windows.Forms.PictureBox enemy_car2;
        private System.Windows.Forms.PictureBox enemy_car3;
        private System.Windows.Forms.Timer Enemy1_mover;
        private System.Windows.Forms.Timer Enemy2_mover;
        private System.Windows.Forms.Timer Enemy3_mover;
        private System.Windows.Forms.Label endGame;
        private System.Windows.Forms.Label speedText;
        private System.Windows.Forms.Button btn_replay;
        private System.Windows.Forms.Label scoreText;
    }
}

