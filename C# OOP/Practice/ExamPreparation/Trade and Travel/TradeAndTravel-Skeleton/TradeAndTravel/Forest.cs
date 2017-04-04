using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
   public class Forest : Location, IGatheringLocation
    {
        private const string nameOfForest = "Cherokee";

        public Forest(string name, LocationType type) : base (name, LocationType.Forest)
        {

        }

        public ItemType GatheredType
        {
            get { return ItemType.Wood; }
        }

        public ItemType RequiredItem
        {
            get { return ItemType.Weapon; }
        }

        public Item ProduceItem(string name)
        {
            return new Wood(name);
        }
    }
}
