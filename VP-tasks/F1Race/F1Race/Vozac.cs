using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
   public class Vozac
    {
        public string ime { get; set; }
        public int godini { get; set; }
        public bool prvVozac { get; set; }
        public List <Krug> krugovi { get; set; }


        public override string ToString()
        {
            if (prvVozac == true) {
                return string.Format("{0} ({1}) - F", ime, godini);
             }else
            {
                return string.Format("{0} ({1}) - S", ime, godini);
            }
        }
    }
}
