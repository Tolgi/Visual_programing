using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer___lab
{
   public class Ravenka
    {
        public int prvBroj { get; set; }
        public int vtorBroj { get; set; }
        public int rezultat { get; set; }
        public char operand { get; set; }
        public GenerirajRandomRavenka random;

        public Ravenka()
        {
            random = new GenerirajRandomRavenka();
            prvBroj = random.GenerirajBroj();
            operand = random.GenerirajOperand();
            vtorBroj = random.GenerirajBroj();
        }
        


    }
}
