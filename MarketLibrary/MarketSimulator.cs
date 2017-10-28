using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary
{
    public class MarketSimulator
    {
        public MarketSimulatorDefinition Definition { get; private set; }

        public MarketSimulator(MarketSimulatorDefinition simDefinition)
        {
            this.Definition = simDefinition;
        }

    }
}
