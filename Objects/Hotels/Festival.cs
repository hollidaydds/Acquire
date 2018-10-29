using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects.Hotels
{
    public class Festival : Hotel
    {
        public Festival()
        {
            HotelName = "Festival";
            Price = Constants.MidLevelHotelBasePrice;
            TileType = Enums.TileType.Festival;
            IsSafe = false;
        }
    }
}
