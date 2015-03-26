using System;
using System.Collections.Generic;

namespace TradeAndTravel
{
    public class Merchant : Shopkeeper, ITraveller
    {
        public Merchant(string inputName, Location initialLocation)
            : base(inputName, initialLocation)
        {

        }

        public void TravelTo(Location location)
        {
            this.Location = location;
        }
    }
}
