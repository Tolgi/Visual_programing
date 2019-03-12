using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potrosuvacka_kosnicka
{
    public class Produkt
    {
        public string ime { get; set; }
        public string kategorija { get; set; }
        public int cena { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", ime);
        }
    }
}
