using System;
using System.Collections.Generic;
using System.Text;
using static Acquire.Enums;

namespace Acquire.Objects.Hotels
{
    public abstract class Hotel
    {
        public string HotelName { get; set; }
        public int Price { get; set; }
        public int ChainSize { get; set; }
        public TileType TileType { get; set; }
        public bool IsSafe { get; set; }
    }
}
