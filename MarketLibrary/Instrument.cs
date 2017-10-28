using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGC
{
    public class Instrument
    {
        public string TickerSymbol { get; private set; }

        public Instrument(string tickerSymbol)
        {
            this.TickerSymbol = tickerSymbol;
        }
    }
}
