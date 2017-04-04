using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
   public class Wood : Item
    {
        private const int woodValue = 2;

        public Wood(string name, Location location = null) : base(name, woodValue, ItemType.Wood, location)
        {

        }

        public override void UpdateWithInteraction(string interaction)
        {
            if (interaction == "drop" && this.Value > 0)
            {
                this.Value--;
            }
        }
    }
}
