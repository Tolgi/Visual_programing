using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airports
{
    public class Aerodrom
    {
        public string grad { get; set; }
        public string ime { get; set; }
        public string kratenka { get; set; }
        public List<Destinacii> destinacii { get; set; }



        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", kratenka, ime, grad);
        }
    }
}
