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
    public partial class Нов_аеродром : Form
    {
        public Aerodrom aero { get; set; }
        public Нов_аеродром()
        {
            InitializeComponent();
        }

        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            aero = new Aerodrom();
            aero.grad = txtGrad.Text;
            aero.ime = txtIme.Text;
            aero.kratenka = txtKratenka.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void txtGrad_Validating(object sender, CancelEventArgs e)
        {
            if(txtGrad.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtGrad, "Imeto na gradot e zadolzitelno!");
                e.Cancel = true;
            }else
            {
                errorProvider1.SetError(txtGrad, null);
                e.Cancel = false;
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if(txtIme.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(txtIme, "Imeto e zadolzitelno!");
                e.Cancel = true;
            }else
            {
                errorProvider2.SetError(txtIme, null);
                e.Cancel = false;
            }
        }

        private void txtKratenka_Validating(object sender, CancelEventArgs e)
        {
            if(txtKratenka.Text.Trim().Length != 3)
            {
                errorProvider3.SetError(txtKratenka, "Kratenkata mora da bide 3 golemi bukvi!");
                e.Cancel = true;
            }else
            {
                string str = txtKratenka.Text.Trim();
                foreach(char c in str)
                {
                    if (Char.IsLower(c))
                    {
                        errorProvider3.SetError(txtKratenka, "Kratenkata mora da bide sostavena od golemi bukvi!");
                        e.Cancel = true;
                        return;
                    }
                }

                errorProvider3.SetError(txtKratenka, null);
                e.Cancel = false;
                
            }
        } 
    }
}
