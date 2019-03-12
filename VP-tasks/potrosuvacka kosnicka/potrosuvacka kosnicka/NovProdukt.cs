using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace potrosuvacka_kosnicka
{
    public partial class NovProdukt : Form
    {
        public Produkt produkt { get; set; }
        public NovProdukt()
        {
            InitializeComponent();
        }

         
        private void btnDodadi_Click(object sender, EventArgs e)
        {
            produkt = new Produkt();
            produkt.ime = txtIme.Text;
            produkt.kategorija = txtKategorija.Text;
            produkt.cena = Convert.ToInt32(txtCena.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
