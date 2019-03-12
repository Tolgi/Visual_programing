using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airports
{
    public class Destinacii
    {
        public string imeD { get; set; }
        public int oddalecenost { get; set; }
        public int cena { get; set; }

        public override string ToString()
        {
            return string.Format("{0}   {1} km - {2}  EUR", imeD, oddalecenost, cena);
        }
    }
}
