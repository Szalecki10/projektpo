using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkielete_na_obiektowe
{
    class Player
    {
        protected string? name;
        public int playerID;
        private int points = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        //tokeny
        protected int emeraldTokenOwned = 0;
        protected int diamondTokenOwned = 0;
        protected int sapphireTokenOwned = 0;
        protected int onyxTokenOwned = 0;
        protected int rubyTokenOwned = 0;
        protected int jokerTokenOwned = 0;

        //kopalnie
        protected int emeraldCardOwned = 0;
        protected int diamondCardOwned = 0;
        protected int sapphireCardOwned = 0;
        protected int onyxCardOwned = 0;
        protected int rubyCardOwned = 0;


    }
}
