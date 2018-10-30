using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects.Hotels
{
    public class Continental : Hotel
    {
        public Continental()
        {
            HotelName = "Continental";
            Price = Constants.HighEndHotelBasePrice;
            TileType = Enums.TileType.Continental;
            IsSafe = false;
            ChainSize = 0;
        }
    }
}
