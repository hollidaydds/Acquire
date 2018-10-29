using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects.Hotels
{
    public class WorldWide : Hotel
    {
        public WorldWide()
        {
            HotelName = "World-Wide";
            Price = Constants.MidLevelHotelBasePrice;
            TileType = Enums.TileType.WorldWide;
            IsSafe = false;
        }
    }
}
