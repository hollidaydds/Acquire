using System;
using System.Collections.Generic;
using System.Text;
using static Acquire.Enums;

namespace Acquire.Objects
{
    public class Stock
    {
        public StockType StockType { get; set; }

        public Stock(StockType stockType)
        {
            StockType = stockType;
        }
    }
}
