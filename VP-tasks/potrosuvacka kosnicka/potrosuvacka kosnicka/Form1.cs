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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiProdukt_Click(object sender, EventArgs e)
        {
            NovProdukt pro = new NovProdukt();
            DialogResult rezultat = pro.ShowDialog();
            if(rezultat == System.Windows.Forms.DialogResult.OK)
            {
                lstProdukti.Items.Add(pro.produkt);
            }
        }

        private void btnIzbrisiProdukt_Click(object sender, EventArgs e)
        {
            if(lstProdukti.SelectedIndex != -1)
            {
                lstProdukti.Items.RemoveAt(lstProdukti.SelectedIndex);
            }
        }

        private void btnIsprazniProdukti_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstProdukti.Items.Count > 0)
                {
                    lstProdukti.Items.Clear();
                }
            }catch(Exception ex)
            {

            }
        }

        private void lstProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Produkt p = (Produkt)(lstProdukti.SelectedItem);
                txtIme.Text = p.ime;
                txtKategorija.Text = p.kategorija;
                txtCena.Text = p.cena.ToString();
            }catch(Exception ex)
            {

            }

            //  lstKosnicka.Items.Add(p);       
        }
    }
}
