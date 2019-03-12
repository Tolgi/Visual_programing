using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiVozac_Click(object sender, EventArgs e)
        {
            AddDriver addD = new AddDriver();
            DialogResult rezultat = addD.ShowDialog();
            if(rezultat == System.Windows.Forms.DialogResult.OK)
            {
               lsVozaci.Items.Add(addD.vozac);
            }
        }

        private void btnIbrisiVozac_Click(object sender, EventArgs e)
        {
            if(lsVozaci.SelectedIndex == -1)
            {
                MessageBox.Show("Izberete vozac!");
            }else
            {
                DialogResult dialogRezultat = MessageBox.Show("Dali ste sigurni?", "Brisenje Vozac", MessageBoxButtons.YesNo);
                if(dialogRezultat == DialogResult.Yes)
                {
                    lsVozaci.Items.RemoveAt(lsVozaci.SelectedIndex);
                }else
                {

                }
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Krug krug;
            Vozac vozac;
            List<Krug> krug_list = new List<Krug>();
            if (lsVozaci.SelectedIndex != -1)
            {
                    vozac = (Vozac)(lsVozaci.SelectedItem);
                    krug = new Krug();
                    krug.min = (int)nudMinuti.Value;
                    krug.sek = (int)nudSekundi.Value;
                if(vozac.krugovi != null)
                {
                    krug_list = vozac.krugovi;

                }

                krug_list.Add(krug);
                vozac.krugovi = krug_list;

            }
            else
            {
                MessageBox.Show("Prvo Izberi vozac!");
            }
        }

        private void lsVozaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsKrugovi.Items.Clear();
            Vozac vozacc = (Vozac)(lsVozaci.SelectedItem);
            if(vozacc.krugovi != null)
            {
                foreach(var v in vozacc.krugovi)
                {
                    lsKrugovi.Items.Add((Krug)v);

                }
            }
        }
    }
}
