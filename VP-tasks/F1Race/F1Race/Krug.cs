using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Krug
    {
        public int min { get; set; }
        public int sek { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1}", min, sek);
            
        }
    }
}
