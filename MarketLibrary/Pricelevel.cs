using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGC
{
    public class PriceLevel
    {
        public double Size { get; private set; }
        public double Price { get; private set; }

        public PriceLevel(double size,double price)
        {
            this.Size = size;
            this.Price = price;
        }
    }
}
