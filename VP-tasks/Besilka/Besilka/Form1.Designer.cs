namespace Besilka
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
            this.lblMask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMask1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pbWrong = new System.Windows.Forms.ProgressBar();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.gbPogodeni = new System.Windows.Forms.GroupBox();
            this.txtPogodeniBukvi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbPogodeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(42, 71);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(0, 13);
            this.lblMask.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lblMask1
            // 
            this.lblMask1.AutoSize = true;
            this.lblMask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask1.Location = new System.Drawing.Point(18, 56);
            this.lblMask1.Name = "lblMask1";
            this.lblMask1.Size = new System.Drawing.Size(122, 44);
            this.lblMask1.TabIndex = 2;
            this.lblMask1.Text = "label2";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(467, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(82, 31);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "10:00";
            // 
            // pbWrong
            // 
            this.pbWrong.Location = new System.Drawing.Point(20, 271);
            this.pbWrong.Name = "pbWrong";
            this.pbWrong.Size = new System.Drawing.Size(529, 23);
            this.pbWrong.TabIndex = 4;
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(20, 300);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(529, 23);
            this.pbTime.TabIndex = 5;
            // 
            // gbPogodeni
            // 
            this.gbPogodeni.Controls.Add(this.txtPogodeniBukvi);
            this.gbPogodeni.Location = new System.Drawing.Point(20, 195);
            this.gbPogodeni.Name = "gbPogodeni";
            this.gbPogodeni.Size = new System.Drawing.Size(529, 70);
            this.gbPogodeni.TabIndex = 6;
            this.gbPogodeni.TabStop = false;
            this.gbPogodeni.Text = "Погодени букви";
            // 
            // txtPogodeniBukvi
            // 
            this.txtPogodeniBukvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPogodeniBukvi.Location = new System.Drawing.Point(6, 19);
            this.txtPogodeniBukvi.Name = "txtPogodeniBukvi";
            this.txtPogodeniBukvi.ReadOnly = true;
            this.txtPogodeniBukvi.Size = new System.Drawing.Size(517, 38);
            this.txtPogodeniBukvi.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 53);
            this.textBox1.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(146, 118);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 53);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 335);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbPogodeni);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.pbWrong);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblMask1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPogodeni.ResumeLayout(false);
            this.gbPogodeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMask1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ProgressBar pbWrong;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.GroupBox gbPogodeni;
        private System.Windows.Forms.TextBox txtPogodeniBukvi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer timer1;
    }
}

