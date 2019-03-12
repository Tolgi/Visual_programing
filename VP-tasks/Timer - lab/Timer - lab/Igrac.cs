using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer___lab
{
   public class Igrac
    {
        public string Ime { get; set; }
        public int OsvoeniPoeni { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - поени: {1}", Ime, OsvoeniPoeni);
        }
    }
}
