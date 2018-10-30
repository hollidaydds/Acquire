using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects.Hotels
{
    public class Tower : Hotel
    {
        public Tower()
        {
            HotelName = "Tower";
            Price = Constants.LowEndHotelBasePrice;
            TileType = Enums.TileType.Tower;
            IsSafe = false;
            ChainSize = 0;
        }
    }
}
