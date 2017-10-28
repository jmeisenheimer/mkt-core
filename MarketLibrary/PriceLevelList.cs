using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGC
{
    public enum PriceDepthStyle
    {
        Sweepable,
        Banded
    }

    public class PriceLevelList : List<PriceLevel>
    {
        public PriceDepthStyle DepthStyle { get; private set; }

        public PriceLevelList(PriceDepthStyle style=PriceDepthStyle.Sweepable)
        {
            this.DepthStyle = style;
        }


    }
}
