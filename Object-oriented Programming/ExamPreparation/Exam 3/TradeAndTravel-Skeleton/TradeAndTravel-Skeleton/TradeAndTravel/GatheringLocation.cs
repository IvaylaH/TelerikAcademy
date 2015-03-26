using System;
using System.Collections.Generic;

namespace TradeAndTravel
{
    public abstract class GatheringLocation : Location, IGatheringLocation
    {
        public GatheringLocation(string name, LocationType locationType, ItemType gatheredItemType, ItemType requiredItemType)
            : base(name, locationType)
        {
            this.GatheredType = gatheredItemType;
            this.RequiredItem = requiredItemType;
        }

        public virtual ItemType GatheredType { get; protected set; }
        

        public virtual ItemType RequiredItem { get; protected set; }

        public abstract Item ProduceItem(string name);
    }
}
