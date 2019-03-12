namespace airports
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsAerodromi = new System.Windows.Forms.ListBox();
            this.lsDestinacii = new System.Windows.Forms.ListBox();
            this.btnDodadiAero = new System.Windows.Forms.Button();
            this.btnIzbrisiAero = new System.Windows.Forms.Button();
            this.btnDodadiDesti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNajskapaDesti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProsecnaDolzina = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аеродроми";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дестинации";
            // 
            // lsAerodromi
            // 
            this.lsAerodromi.FormattingEnabled = true;
            this.lsAerodromi.Location = new System.Drawing.Point(12, 39);
            this.lsAerodromi.Name = "lsAerodromi";
            this.lsAerodromi.Size = new System.Drawing.Size(303, 225);
            this.lsAerodromi.TabIndex = 2;
            this.lsAerodromi.SelectedIndexChanged += new System.EventHandler(this.lsAerodromi_SelectedIndexChanged);
            // 
            // lsDestinacii
            // 
            this.lsDestinacii.FormattingEnabled = true;
            this.lsDestinacii.Location = new System.Drawing.Point(381, 39);
            this.lsDestinacii.Name = "lsDestinacii";
            this.lsDestinacii.Size = new System.Drawing.Size(330, 212);
            this.lsDestinacii.TabIndex = 3;
            // 
            // btnDodadiAero
            // 
            this.btnDodadiAero.Location = new System.Drawing.Point(13, 280);
            this.btnDodadiAero.Name = "btnDodadiAero";
            this.btnDodadiAero.Size = new System.Drawing.Size(302, 23);
            this.btnDodadiAero.TabIndex = 4;
            this.btnDodadiAero.Text = "Додади аеродром";
            this.btnDodadiAero.UseVisualStyleBackColor = true;
            this.btnDodadiAero.Click += new System.EventHandler(this.btnDodadiAero_Click);
            // 
            // btnIzbrisiAero
            // 
            this.btnIzbrisiAero.Location = new System.Drawing.Point(12, 320);
            this.btnIzbrisiAero.Name = "btnIzbrisiAero";
            this.btnIzbrisiAero.Size = new System.Drawing.Size(303, 23);
            this.btnIzbrisiAero.TabIndex = 5;
            this.btnIzbrisiAero.Text = "Избриши аеродром";
            this.btnIzbrisiAero.UseVisualStyleBackColor = true;
            this.btnIzbrisiAero.Click += new System.EventHandler(this.btnIzbrisiAero_Click);
            // 
            // btnDodadiDesti
            // 
            this.btnDodadiDesti.Location = new System.Drawing.Point(12, 353);
            this.btnDodadiDesti.Name = "btnDodadiDesti";
            this.btnDodadiDesti.Size = new System.Drawing.Size(302, 23);
            this.btnDodadiDesti.TabIndex = 6;
            this.btnDodadiDesti.Text = "Додади дестинација";
            this.btnDodadiDesti.UseVisualStyleBackColor = true;
            this.btnDodadiDesti.Click += new System.EventHandler(this.btnDodadiDesti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProsecnaDolzina);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNajskapaDesti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(381, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // txtNajskapaDesti
            // 
            this.txtNajskapaDesti.Location = new System.Drawing.Point(21, 37);
            this.txtNajskapaDesti.Name = "txtNajskapaDesti";
            this.txtNajskapaDesti.ReadOnly = true;
            this.txtNajskapaDesti.Size = new System.Drawing.Size(291, 20);
            this.txtNajskapaDesti.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Најскапа дестинација";
            // 
            // txtProsecnaDolzina
            // 
            this.txtProsecnaDolzina.Location = new System.Drawing.Point(21, 87);
            this.txtProsecnaDolzina.Name = "txtProsecnaDolzina";
            this.txtProsecnaDolzina.ReadOnly = true;
            this.txtProsecnaDolzina.Size = new System.Drawing.Size(291, 20);
            this.txtProsecnaDolzina.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodadiDesti);
            this.Controls.Add(this.btnIzbrisiAero);
            this.Controls.Add(this.btnDodadiAero);
            this.Controls.Add(this.lsDestinacii);
            this.Controls.Add(this.lsAerodromi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsAerodromi;
        private System.Windows.Forms.ListBox lsDestinacii;
        private System.Windows.Forms.Button btnDodadiAero;
        private System.Windows.Forms.Button btnIzbrisiAero;
        private System.Windows.Forms.Button btnDodadiDesti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNajskapaDesti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProsecnaDolzina;
    }
}

