using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
namespace Szkielete_na_obiektowe
{
    [Serializable]
    class Nobles : Board
    {
        public int nobleID { get; set; }
        public int pointsGiving { get; set; }
        protected bool ownedNoble = false;
        protected bool onboardNoble = false;


        public int emeraldCost { get; set; }
        public int diamondCost { get; set; }
        public int sapphireCost { get; set; }
        public int onyxCost { get; set; }
        public int rubyCost { get; set; }



        public override void transfering(int typzmiany)
        {
            switch (typzmiany)
            {
                case 0:
                    this.onboardNoble = true;
                    break;
                case 1:
                    this.ownedNoble = true;
                    break;
                default: break;

            }
        }
    }
}
