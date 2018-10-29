using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace Acquire
{
    public class Enums
    {
        public enum TileType
        {
            [Description("o")]
            Empty,

            [Description("P")]
            Placed,

            [Description("B")]
            Blocked,

            [Description("T")]
            Tower,

            [Description("L")]
            Luxor,

            [Description("A")]
            American,

            [Description("F")]
            Festival,

            [Description("W")]
            WorldWide,

            [Description("I")]
            Imperial,

            [Description("C")]
            Continental,
        }

        public enum StockType
        {
            [Description("T")]
            Tower,

            [Description("L")]
            Luxor,

            [Description("A")]
            American,

            [Description("F")]
            Festival,

            [Description("W")]
            WorldWide,

            [Description("I")]
            Imperial,

            [Description("C")]
            Continental,
        }
    }
}
