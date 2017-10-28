using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary
{
    public class MarketPicture
    {
        public PriceLevelList BidLevels { get; private set; }
        public PriceLevelList OfferLevels { get; private set; }

        public MarketDefinition MktDef { get; private set; }

        public MarketPicture(MarketDefinition mktDef)
        {
            this.MktDef = mktDef;
        }
    }
}
