using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
   public class Weapon : Item
    {
        private const int weaponValue = 10;

        public Weapon(string name, Location location = null) : base(name, weaponValue, ItemType.Weapon, location)
        {

        }

        public static List<ItemType> GetComposingItems()
        {
            return new List<ItemType> { ItemType.Iron, ItemType.Wood };
        }
    }
}
