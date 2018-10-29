using System;
using System.Collections.Generic;
using System.Text;
using static Acquire.Enums;

namespace Acquire.Objects
{
    public class Stock
    {
        public TileType StockType { get; set; }

        public Stock(TileType tileType)
        {
            StockType = tileType;
        }
    }
}
