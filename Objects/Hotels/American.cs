using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects.Hotels
{
    public class American : Hotel
    {
        public American()
        {
            HotelName = "Tower";
            Price = Constants.MidLevelHotelBasePrice;
            TileType = Enums.TileType.American;
            IsSafe = false;
        }
    }
}
