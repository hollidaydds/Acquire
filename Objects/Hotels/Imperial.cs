using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects.Hotels
{
    public class Imperial : Hotel
    {
        public Imperial()
        {
            HotelName = "Imperial";
            Price = Constants.HighEndHotelBasePrice;
            TileType = Enums.TileType.Imperial;
            IsSafe = false;
        }
    }
}
