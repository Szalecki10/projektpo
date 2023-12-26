using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkielete_na_obiektowe
{
    abstract class Board
    {
        /*
        public Vector<int> lvl3Board;
        public Vector<int> lvl2Board;
        public Vector<int> lvl1Board;
        public Vector<int> noblesOnBoard;
        */

        public int emeraldTokenOnBoard = 7;
        public int diamondTokenOnBoard = 7;
        public int sapphireTokenOnBoard = 7;
        public int onyxTokenOnBoard = 7;
        public int rubyTokenOnBoard = 7;
        public int jokerTokenOnBoard = 5;

        public abstract void transfering(int zmienna);
    }

}
