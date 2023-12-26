using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkielete_na_obiektowe
{
    internal class TokensOnBoard
    {
        public int emeraldTokenOnBoard {  get; set; }
        public int diamondTokenOnBoard { get; set; }
        public int sapphireTokenOnBoard { get; set; }
        public int onyxTokenOnBoard { get; set; }
        public int rubyTokenOnBoard { get; set; }
        public int jokerTokenOnBoard = 5;

        public void transfertoken(int kolorid, int wartoscpozmianie)
        {
            switch(kolorid)
            {
                case 1:
                    emeraldTokenOnBoard = wartoscpozmianie; 
                    break;
                case 2:
                    diamondTokenOnBoard = wartoscpozmianie;
                    break;
                case 3:
                    sapphireTokenOnBoard = wartoscpozmianie;
                    break;
                case 4:
                    onyxTokenOnBoard = wartoscpozmianie;
                    break;
                case 5:
                    rubyTokenOnBoard = wartoscpozmianie;
                    break;
                case 6:
                    jokerTokenOnBoard = wartoscpozmianie;
                    break;
                default:
                    Console.WriteLine("blad");
                    break;
            }
        }
    }
}
