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
    class Card : Board
    {
        public int points  { get; set; }
        public int cardID { get; set; }
        public int cardLevel { get; set; }

        public int emeraldCost { get; set; }
        public int diamondCost { get; set; }
        public int sapphireCost { get; set; }
        public int onyxCost { get; set; }
        public int rubyCost { get; set; }

        public int colorGainedID { get; set; }

        public bool? ownedCard { get; set; }
        public bool? onboardCard { get; set; }


        public override void transfering(int typzmiany)
        {
            switch (typzmiany)
            {
                case 0:
                    this.ownedCard = true;
                    break;
                case 1:
                    this.onboardCard = true;
                    break;
                case 2:
                    this.onboardCard = false;
                    break;
                default: break;

            }
        }
    }
}
