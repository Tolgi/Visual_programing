using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer___lab
{
   public class GenerirajRandomRavenka
    {
        private Random random = new Random();
        private char[] operatori = {'+', '-', '/', '*'};

        public int GenerirajBroj()
        {
            int broj = random.Next(1, 11);
            return broj;
        }


        public char GenerirajOperand()
        {
            char operand = operatori[random.Next(operatori.Length)];

            return operand;
        }


    }
}
