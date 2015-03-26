using System;
using System.Collections.Generic;

namespace TradeAndTravel
{
    public class Iron : Item
    {
        private const int IronValue = 3;

        public Iron(string name, Location location)
            : base(name, IronValue, ItemType.Iron, location)
        {

        }
    }
}
