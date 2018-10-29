using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects.Hotels
{
    public class Luxor : Hotel
    {
        public Luxor()
        {
            HotelName = "Luxor";
            Price = Constants.LowEndHotelBasePrice;
            TileType = Enums.TileType.Luxor;
            IsSafe = false;
        }
    }
}
