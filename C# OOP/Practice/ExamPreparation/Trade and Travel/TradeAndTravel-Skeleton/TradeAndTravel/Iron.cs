using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Iron : Item
    {
        private const int ironValue = 3;

        public Iron(string name, Location location = null) : base(name, ironValue, ItemType.Iron, location)
        {

        }


    }
}
