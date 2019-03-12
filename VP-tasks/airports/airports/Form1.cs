using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object MessageBoxButton { get; private set; }

        private void btnDodadiAero_Click(object sender, EventArgs e)
        {
            Нов_аеродром dodadiAero = new Нов_аеродром();
            DialogResult rezultat = dodadiAero.ShowDialog();

            if(rezultat == System.Windows.Forms.DialogResult.OK)
            {
                lsAerodromi.Items.Add(dodadiAero.aero);
            }
        }

        private void btnIzbrisiAero_Click(object sender, EventArgs e)
        {
            if(lsAerodromi.SelectedIndex == -1)
            {
                MessageBox.Show("Селектирајте аеродром кој што сакате да го избришете!");
            }else
            {
                DialogResult dialogResult = MessageBox.Show("Дали  сте сигурни дека сакате да го избришете аеродромот?", "Избриши аеродром", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lsAerodromi.Items.RemoveAt(lsAerodromi.SelectedIndex);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
        }

        private void btnDodadiDesti_Click(object sender, EventArgs e)
        {
            Aerodrom aero = null;
            List<Destinacii> listDestinacii = new List<Destinacii>();

            if (lsAerodromi.SelectedIndex != -1)
            {
                Додади_дестинација dodadiDest = new Додади_дестинација();
                DialogResult rezultat = dodadiDest.ShowDialog();
                aero = (Aerodrom)(lsAerodromi.SelectedItem);
                if (rezultat == System.Windows.Forms.DialogResult.OK)
                {
                    if (aero.destinacii != null)
                    {
                        listDestinacii = aero.destinacii;
                    }

                    listDestinacii.Add(dodadiDest.dest);
                    aero.destinacii = listDestinacii;
                   
                }
            }
            else
            {
                MessageBox.Show("Изберете аеродром за кој што сакате да додадете дестинации!");
            }
        }

        private void lsAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsDestinacii.Items.Clear();
            Aerodrom aero = (Aerodrom)(lsAerodromi.SelectedItem);
            if (aero.destinacii != null)
            {
                foreach (var d in aero.destinacii)
                {
                    lsDestinacii.Items.Add((Destinacii)d);
                }
            }
        }
    }
}
