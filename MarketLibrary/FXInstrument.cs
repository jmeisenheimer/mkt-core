using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGC
{
    public class FXInstrument : Instrument
    {
        public decimal PipSize { get; private set; }

        public FXInstrument(string tickerSymbol,decimal pipSize) : base(tickerSymbol)
        {
            this.PipSize = pipSize;
        }
    }
}
