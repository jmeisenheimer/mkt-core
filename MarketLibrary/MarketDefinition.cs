using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGC
{
    public class MarketDefinition
    {
        public Instrument Instrument { get; private set; }
        public string Source { get; private set; }

        public MarketDefinition(Instrument instrument,string source)
        {
            this.Instrument = instrument;
            this.Source = source;
        }
    }
}
