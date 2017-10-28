using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary
{
    public class MarketSimulatorDefinition
    {
        public MarketDefinition MktDef { get; private set; }

        public MarketSimulatorDefinition(MarketDefinition mktDef)
        {
            this.MktDef = mktDef;
        }
    }
}
