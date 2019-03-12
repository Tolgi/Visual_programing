namespace Timer___lab
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIgrac = new System.Windows.Forms.TextBox();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOperand = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPogodi = new System.Windows.Forms.Button();
            this.labela2 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.lblPoeniii = new System.Windows.Forms.Label();
            this.pbPoeni = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPreostanatoVreme = new System.Windows.Forms.Label();
            this.pbPreostanatoVreme = new System.Windows.Forms.ProgressBar();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnNajdobriIgraci = new System.Windows.Forms.Button();
            this.btnIskluci = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Играч:";
            // 
            // txtIgrac
            // 
            this.txtIgrac.Location = new System.Drawing.Point(60, 13);
            this.txtIgrac.Name = "txtIgrac";
            this.txtIgrac.Size = new System.Drawing.Size(100, 20);
            this.txtIgrac.TabIndex = 1;
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(16, 68);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.ReadOnly = true;
            this.txtOp1.Size = new System.Drawing.Size(60, 20);
            this.txtOp1.TabIndex = 2;
            // 
            // txtOperand
            // 
            this.txtOperand.Location = new System.Drawing.Point(99, 68);
            this.txtOperand.Name = "txtOperand";
            this.txtOperand.ReadOnly = true;
            this.txtOperand.Size = new System.Drawing.Size(41, 20);
            this.txtOperand.TabIndex = 3;
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(159, 68);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.ReadOnly = true;
            this.txtOp2.Size = new System.Drawing.Size(68, 20);
            this.txtOp2.TabIndex = 4;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(284, 68);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(81, 20);
            this.txtRezultat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // btnPogodi
            // 
            this.btnPogodi.Location = new System.Drawing.Point(404, 65);
            this.btnPogodi.Name = "btnPogodi";
            this.btnPogodi.Size = new System.Drawing.Size(110, 23);
            this.btnPogodi.TabIndex = 7;
            this.btnPogodi.Text = "Погоди";
            this.btnPogodi.UseVisualStyleBackColor = true;
            this.btnPogodi.Click += new System.EventHandler(this.btnPogodi_Click);
            // 
            // labela2
            // 
            this.labela2.AutoSize = true;
            this.labela2.Location = new System.Drawing.Point(18, 124);
            this.labela2.Name = "labela2";
            this.labela2.Size = new System.Drawing.Size(42, 13);
            this.labela2.TabIndex = 8;
            this.labela2.Text = "Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(82, 111);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(0, 13);
            this.lblPoeni.TabIndex = 9;
            // 
            // lblPoeniii
            // 
            this.lblPoeniii.AutoSize = true;
            this.lblPoeniii.Location = new System.Drawing.Point(82, 124);
            this.lblPoeniii.Name = "lblPoeniii";
            this.lblPoeniii.Size = new System.Drawing.Size(35, 13);
            this.lblPoeniii.TabIndex = 10;
            this.lblPoeniii.Text = "label3";
            // 
            // pbPoeni
            // 
            this.pbPoeni.Location = new System.Drawing.Point(17, 153);
            this.pbPoeni.Name = "pbPoeni";
            this.pbPoeni.Size = new System.Drawing.Size(497, 23);
            this.pbPoeni.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Преостанато време:";
            // 
            // lblPreostanatoVreme
            // 
            this.lblPreostanatoVreme.AutoSize = true;
            this.lblPreostanatoVreme.Location = new System.Drawing.Point(156, 217);
            this.lblPreostanatoVreme.Name = "lblPreostanatoVreme";
            this.lblPreostanatoVreme.Size = new System.Drawing.Size(34, 13);
            this.lblPreostanatoVreme.TabIndex = 13;
            this.lblPreostanatoVreme.Text = "01:00";
            // 
            // pbPreostanatoVreme
            // 
            this.pbPreostanatoVreme.Location = new System.Drawing.Point(16, 245);
            this.pbPreostanatoVreme.Name = "pbPreostanatoVreme";
            this.pbPreostanatoVreme.Size = new System.Drawing.Size(498, 23);
            this.pbPreostanatoVreme.TabIndex = 14;
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Location = new System.Drawing.Point(16, 282);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(75, 23);
            this.btnNovaIgra.TabIndex = 15;
            this.btnNovaIgra.Text = "Нова игра";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnNajdobriIgraci
            // 
            this.btnNajdobriIgraci.Location = new System.Drawing.Point(210, 282);
            this.btnNajdobriIgraci.Name = "btnNajdobriIgraci";
            this.btnNajdobriIgraci.Size = new System.Drawing.Size(115, 23);
            this.btnNajdobriIgraci.TabIndex = 16;
            this.btnNajdobriIgraci.Text = "Најдобри играчи";
            this.btnNajdobriIgraci.UseVisualStyleBackColor = true;
            this.btnNajdobriIgraci.Click += new System.EventHandler(this.btnNajdobriIgraci_Click);
            // 
            // btnIskluci
            // 
            this.btnIskluci.Location = new System.Drawing.Point(439, 282);
            this.btnIskluci.Name = "btnIskluci";
            this.btnIskluci.Size = new System.Drawing.Size(75, 23);
            this.btnIskluci.TabIndex = 17;
            this.btnIskluci.Text = "Исклучи";
            this.btnIskluci.UseVisualStyleBackColor = true;
            this.btnIskluci.Click += new System.EventHandler(this.btnIskluci_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 317);
            this.Controls.Add(this.btnIskluci);
            this.Controls.Add(this.btnNajdobriIgraci);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.pbPreostanatoVreme);
            this.Controls.Add(this.lblPreostanatoVreme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbPoeni);
            this.Controls.Add(this.lblPoeniii);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.labela2);
            this.Controls.Add(this.btnPogodi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOperand);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.txtIgrac);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIgrac;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtOperand;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPogodi;
        private System.Windows.Forms.Label labela2;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label lblPoeniii;
        private System.Windows.Forms.ProgressBar pbPoeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPreostanatoVreme;
        private System.Windows.Forms.ProgressBar pbPreostanatoVreme;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnNajdobriIgraci;
        private System.Windows.Forms.Button btnIskluci;
        private System.Windows.Forms.Timer timer1;
    }
}

