namespace F1Race
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
            this.Возачи = new System.Windows.Forms.GroupBox();
            this.btnIbrisiVozac = new System.Windows.Forms.Button();
            this.btnDodadiVozac = new System.Windows.Forms.Button();
            this.lsVozaci = new System.Windows.Forms.ListBox();
            this.Кругови = new System.Windows.Forms.GroupBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.nudSekundi = new System.Windows.Forms.NumericUpDown();
            this.nudMinuti = new System.Windows.Forms.NumericUpDown();
            this.lsKrugovi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNajdobarKrug = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudVreme = new System.Windows.Forms.NumericUpDown();
            this.Возачи.SuspendLayout();
            this.Кругови.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekundi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).BeginInit();
            this.SuspendLayout();
            // 
            // Возачи
            // 
            this.Возачи.Controls.Add(this.btnIbrisiVozac);
            this.Возачи.Controls.Add(this.btnDodadiVozac);
            this.Возачи.Controls.Add(this.lsVozaci);
            this.Возачи.Location = new System.Drawing.Point(12, 12);
            this.Возачи.Name = "Возачи";
            this.Возачи.Size = new System.Drawing.Size(301, 414);
            this.Возачи.TabIndex = 0;
            this.Возачи.TabStop = false;
            this.Возачи.Text = "Возачи";
            // 
            // btnIbrisiVozac
            // 
            this.btnIbrisiVozac.Location = new System.Drawing.Point(6, 377);
            this.btnIbrisiVozac.Name = "btnIbrisiVozac";
            this.btnIbrisiVozac.Size = new System.Drawing.Size(289, 31);
            this.btnIbrisiVozac.TabIndex = 2;
            this.btnIbrisiVozac.Text = "Избриши возач";
            this.btnIbrisiVozac.UseVisualStyleBackColor = true;
            this.btnIbrisiVozac.Click += new System.EventHandler(this.btnIbrisiVozac_Click);
            // 
            // btnDodadiVozac
            // 
            this.btnDodadiVozac.Location = new System.Drawing.Point(6, 342);
            this.btnDodadiVozac.Name = "btnDodadiVozac";
            this.btnDodadiVozac.Size = new System.Drawing.Size(289, 29);
            this.btnDodadiVozac.TabIndex = 1;
            this.btnDodadiVozac.Text = "Додади возач";
            this.btnDodadiVozac.UseVisualStyleBackColor = true;
            this.btnDodadiVozac.Click += new System.EventHandler(this.btnDodadiVozac_Click);
            // 
            // lsVozaci
            // 
            this.lsVozaci.FormattingEnabled = true;
            this.lsVozaci.Location = new System.Drawing.Point(6, 17);
            this.lsVozaci.Name = "lsVozaci";
            this.lsVozaci.Size = new System.Drawing.Size(289, 316);
            this.lsVozaci.TabIndex = 0;
            this.lsVozaci.SelectedIndexChanged += new System.EventHandler(this.lsVozaci_SelectedIndexChanged);
            // 
            // Кругови
            // 
            this.Кругови.Controls.Add(this.nudVreme);
            this.Кругови.Controls.Add(this.label4);
            this.Кругови.Controls.Add(this.txtNajdobarKrug);
            this.Кругови.Controls.Add(this.label3);
            this.Кругови.Controls.Add(this.label2);
            this.Кругови.Controls.Add(this.label1);
            this.Кругови.Controls.Add(this.btnDodadi);
            this.Кругови.Controls.Add(this.nudSekundi);
            this.Кругови.Controls.Add(this.nudMinuti);
            this.Кругови.Controls.Add(this.lsKrugovi);
            this.Кругови.Location = new System.Drawing.Point(319, 12);
            this.Кругови.Name = "Кругови";
            this.Кругови.Size = new System.Drawing.Size(298, 408);
            this.Кругови.TabIndex = 1;
            this.Кругови.TabStop = false;
            this.Кругови.Text = "Кругови";
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(204, 258);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(75, 23);
            this.btnDodadi.TabIndex = 3;
            this.btnDodadi.Text = "Додади круг";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // nudSekundi
            // 
            this.nudSekundi.Location = new System.Drawing.Point(105, 261);
            this.nudSekundi.Name = "nudSekundi";
            this.nudSekundi.Size = new System.Drawing.Size(80, 20);
            this.nudSekundi.TabIndex = 2;
            // 
            // nudMinuti
            // 
            this.nudMinuti.Location = new System.Drawing.Point(6, 264);
            this.nudMinuti.Name = "nudMinuti";
            this.nudMinuti.Size = new System.Drawing.Size(85, 20);
            this.nudMinuti.TabIndex = 1;
            // 
            // lsKrugovi
            // 
            this.lsKrugovi.FormattingEnabled = true;
            this.lsKrugovi.Location = new System.Drawing.Point(6, 22);
            this.lsKrugovi.Name = "lsKrugovi";
            this.lsKrugovi.Size = new System.Drawing.Size(286, 212);
            this.lsKrugovi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Минути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Секунди";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Најдобар круг";
            // 
            // txtNajdobarKrug
            // 
            this.txtNajdobarKrug.Location = new System.Drawing.Point(9, 319);
            this.txtNajdobarKrug.Name = "txtNajdobarKrug";
            this.txtNajdobarKrug.Size = new System.Drawing.Size(270, 20);
            this.txtNajdobarKrug.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Време";
            // 
            // nudVreme
            // 
            this.nudVreme.Location = new System.Drawing.Point(9, 374);
            this.nudVreme.Name = "nudVreme";
            this.nudVreme.Size = new System.Drawing.Size(120, 20);
            this.nudVreme.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 438);
            this.Controls.Add(this.Кругови);
            this.Controls.Add(this.Возачи);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Возачи.ResumeLayout(false);
            this.Кругови.ResumeLayout(false);
            this.Кругови.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekundi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Возачи;
        private System.Windows.Forms.Button btnIbrisiVozac;
        private System.Windows.Forms.Button btnDodadiVozac;
        private System.Windows.Forms.ListBox lsVozaci;
        private System.Windows.Forms.GroupBox Кругови;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.NumericUpDown nudSekundi;
        private System.Windows.Forms.NumericUpDown nudMinuti;
        private System.Windows.Forms.ListBox lsKrugovi;
        private System.Windows.Forms.NumericUpDown nudVreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNajdobarKrug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

