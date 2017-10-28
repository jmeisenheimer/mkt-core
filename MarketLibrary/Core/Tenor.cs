using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary.Core
{
    public enum TenorOffsetType
    {
        Relative,
        Absolute
    }

    public class Tenor
    {
        public string Name { get; private set; }
        
    }
}
