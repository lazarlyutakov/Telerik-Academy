using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Mine : Location
    {

        public Mine(string name, LocationType type) : base(name, LocationType.Mine)
        {

        }

        public ItemType GatheredType
        {
            get { return ItemType.Iron; }
        }

        public ItemType RequiredItem
        {
            get { return ItemType.Armor; }
        }

        public Item ProduceItem(string name)
        {
            return new Iron(name);
        }

    }
}
