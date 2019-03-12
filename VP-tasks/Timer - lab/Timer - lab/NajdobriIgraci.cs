using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer___lab
{
    public partial class NajdobriIgraci : Form
    {
        public List<Igrac> lista = new List<Igrac>();

       public void popolni()
        {
            foreach (Igrac i in lista)
            {
                lbNajdobriIgraci.Items.Add(i);
            }
           
        }
        public NajdobriIgraci()
        {
            InitializeComponent();
            
        }
    }
}
