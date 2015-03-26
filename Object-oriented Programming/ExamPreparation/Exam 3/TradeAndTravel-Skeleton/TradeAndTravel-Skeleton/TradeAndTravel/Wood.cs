using System;
using System.Collections.Generic;

namespace TradeAndTravel
{
    public class Wood : Item
    {
        private const int InitialWoodValue = 2;

        public Wood(string name, Location location)
            : base(name, InitialWoodValue, ItemType.Wood, location)
        {
        }

        public override void UpdateWithInteraction(string interaction) // need to check what the interaction should be
        {
            if (interaction == "drop")
            {
                if (this.Value > 0) // check if interaction == "drop" ?!?
                {
                    this.Value--;
                }   
            }
       
            base.UpdateWithInteraction(interaction);
        }
    }
}
