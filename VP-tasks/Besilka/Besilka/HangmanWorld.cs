using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besilka
{
  public class HangmanWorld
    {
        public string Zbor { get; set; }
        public static int maxObidi = 5;
        public int pogresniObidi { get; set; }
        public static int time = 600;
        

        public List<char> wordLetters { get; set;} // site bukvi od koi se sostoi zborot koj sto se pogoduva
        public List<char> allLetters  { get; set; } //site bukvi koi se vneseni za da se pogodi zborot (obidite)

        public HangmanWorld (string zbor)
        {
            Zbor = zbor;
            allLetters = new List<char>();
            wordLetters = new List<char>();
            foreach(char c in Zbor)
            {
                wordLetters.Add(char.ToLower(c));
            }
            pogresniObidi = 0;
        }

        public string MaskWord()
        {
           StringBuilder guess = new StringBuilder();
           for(int i=0; i<Zbor.Length; i++)
            {
                char c = Zbor[i];
                c = char.ToLower(c);
                if (wordLetters.Contains(c))
                {
                    guess.Append("_");
                }
                else
                {
                    guess.Append(c);
                }
                guess.Append(" ");
            }

            return guess.ToString();

            }

        public string getAllLetters()
        {
            StringBuilder sb = new StringBuilder();
            for(char c='a'; c<'z'; c++)
            {
                if (allLetters.Contains(c))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append("_");

                }
                sb.Append(" ");
            }
            return sb.ToString();
        }


        public bool GuessLetter(char c)
        {
            if (allLetters.Contains(c))
            {
                return false;
            }

            allLetters.Add(c);

            if (wordLetters.Contains(c))
            {
                wordLetters.Remove(c);
            }else
            {
                pogresniObidi++;
            }

            return true;    
                    
         }

        public bool didiWith()
        {
            return wordLetters.Count == 0;

        }

       




    }
   
    }
