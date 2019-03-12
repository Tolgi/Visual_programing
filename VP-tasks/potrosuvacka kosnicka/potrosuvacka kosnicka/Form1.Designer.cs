namespace potrosuvacka_kosnicka
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
            this.lstProdukti = new System.Windows.Forms.ListBox();
            this.btnIsprazniProdukti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstKosnicka = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKategorija = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnDodadiKosnicka = new System.Windows.Forms.Button();
            this.btnIzbrisiKosnicka = new System.Windows.Forms.Button();
            this.btnDodadiProdukt = new System.Windows.Forms.Button();
            this.btnIzbrisiProdukt = new System.Windows.Forms.Button();
            this.btnIzprazniKosnicka = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на продукти";
            // 
            // lstProdukti
            // 
            this.lstProdukti.FormattingEnabled = true;
            this.lstProdukti.Location = new System.Drawing.Point(13, 43);
            this.lstProdukti.Name = "lstProdukti";
            this.lstProdukti.Size = new System.Drawing.Size(202, 303);
            this.lstProdukti.TabIndex = 1;
            this.lstProdukti.SelectedIndexChanged += new System.EventHandler(this.lstProdukti_SelectedIndexChanged);
            // 
            // btnIsprazniProdukti
            // 
            this.btnIsprazniProdukti.Location = new System.Drawing.Point(12, 348);
            this.btnIsprazniProdukti.Name = "btnIsprazniProdukti";
            this.btnIsprazniProdukti.Size = new System.Drawing.Size(203, 23);
            this.btnIsprazniProdukti.TabIndex = 2;
            this.btnIsprazniProdukti.Text = "Испразни ја листата со продукти?";
            this.btnIsprazniProdukti.UseVisualStyleBackColor = true;
            this.btnIsprazniProdukti.Click += new System.EventHandler(this.btnIsprazniProdukti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKategorija);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(221, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кошничка";
            // 
            // lstKosnicka
            // 
            this.lstKosnicka.FormattingEnabled = true;
            this.lstKosnicka.Location = new System.Drawing.Point(454, 43);
            this.lstKosnicka.Name = "lstKosnicka";
            this.lstKosnicka.Size = new System.Drawing.Size(214, 277);
            this.lstKosnicka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вкупно";
            // 
            // txtVkupno
            // 
            this.txtVkupno.Location = new System.Drawing.Point(522, 326);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.ReadOnly = true;
            this.txtVkupno.Size = new System.Drawing.Size(146, 20);
            this.txtVkupno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Име";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(10, 37);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(211, 20);
            this.txtIme.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = " Категорија";
            // 
            // txtKategorija
            // 
            this.txtKategorija.Location = new System.Drawing.Point(10, 81);
            this.txtKategorija.Name = "txtKategorija";
            this.txtKategorija.ReadOnly = true;
            this.txtKategorija.Size = new System.Drawing.Size(211, 20);
            this.txtKategorija.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Цена";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(10, 124);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 5;
            // 
            // btnDodadiKosnicka
            // 
            this.btnDodadiKosnicka.Location = new System.Drawing.Point(221, 197);
            this.btnDodadiKosnicka.Name = "btnDodadiKosnicka";
            this.btnDodadiKosnicka.Size = new System.Drawing.Size(227, 23);
            this.btnDodadiKosnicka.TabIndex = 8;
            this.btnDodadiKosnicka.Text = "Додади во кошничка>>";
            this.btnDodadiKosnicka.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiKosnicka
            // 
            this.btnIzbrisiKosnicka.Location = new System.Drawing.Point(221, 226);
            this.btnIzbrisiKosnicka.Name = "btnIzbrisiKosnicka";
            this.btnIzbrisiKosnicka.Size = new System.Drawing.Size(227, 23);
            this.btnIzbrisiKosnicka.TabIndex = 9;
            this.btnIzbrisiKosnicka.Text = "Избриши од кошничка ";
            this.btnIzbrisiKosnicka.UseVisualStyleBackColor = true;
            // 
            // btnDodadiProdukt
            // 
            this.btnDodadiProdukt.Location = new System.Drawing.Point(221, 255);
            this.btnDodadiProdukt.Name = "btnDodadiProdukt";
            this.btnDodadiProdukt.Size = new System.Drawing.Size(227, 23);
            this.btnDodadiProdukt.TabIndex = 10;
            this.btnDodadiProdukt.Text = "Додади нов продукт";
            this.btnDodadiProdukt.UseVisualStyleBackColor = true;
            this.btnDodadiProdukt.Click += new System.EventHandler(this.btnDodadiProdukt_Click);
            // 
            // btnIzbrisiProdukt
            // 
            this.btnIzbrisiProdukt.Location = new System.Drawing.Point(221, 284);
            this.btnIzbrisiProdukt.Name = "btnIzbrisiProdukt";
            this.btnIzbrisiProdukt.Size = new System.Drawing.Size(227, 23);
            this.btnIzbrisiProdukt.TabIndex = 11;
            this.btnIzbrisiProdukt.Text = "Избриши продукт";
            this.btnIzbrisiProdukt.UseVisualStyleBackColor = true;
            this.btnIzbrisiProdukt.Click += new System.EventHandler(this.btnIzbrisiProdukt_Click);
            // 
            // btnIzprazniKosnicka
            // 
            this.btnIzprazniKosnicka.Location = new System.Drawing.Point(454, 352);
            this.btnIzprazniKosnicka.Name = "btnIzprazniKosnicka";
            this.btnIzprazniKosnicka.Size = new System.Drawing.Size(214, 23);
            this.btnIzprazniKosnicka.TabIndex = 12;
            this.btnIzprazniKosnicka.Text = "Испразни ја кошничката ?";
            this.btnIzprazniKosnicka.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 383);
            this.Controls.Add(this.btnIzprazniKosnicka);
            this.Controls.Add(this.btnIzbrisiProdukt);
            this.Controls.Add(this.btnDodadiProdukt);
            this.Controls.Add(this.btnIzbrisiKosnicka);
            this.Controls.Add(this.btnDodadiKosnicka);
            this.Controls.Add(this.txtVkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstKosnicka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIsprazniProdukti);
            this.Controls.Add(this.lstProdukti);
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
        private System.Windows.Forms.ListBox lstProdukti;
        private System.Windows.Forms.Button btnIsprazniProdukti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKategorija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKosnicka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.Button btnDodadiKosnicka;
        private System.Windows.Forms.Button btnIzbrisiKosnicka;
        private System.Windows.Forms.Button btnDodadiProdukt;
        private System.Windows.Forms.Button btnIzbrisiProdukt;
        private System.Windows.Forms.Button btnIzprazniKosnicka;
    }
}

