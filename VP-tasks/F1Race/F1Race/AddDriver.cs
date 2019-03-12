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
    public partial class AddDriver : Form
    {
        public Vozac vozac { get; set; }
        public AddDriver()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            vozac = new Vozac();
            vozac.ime = txtIme.Text;
            vozac.godini = (int)nudVozrast.Value;
            vozac.prvVozac = chbPrvVozac.Checked;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
