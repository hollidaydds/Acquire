using Acquire.Boards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects
{
    public class Player
    {
        public string UserName { get; set; }
        public int AccountBalance { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<Tile> Tiles { get; set; }

        public Player(string userName)
        {
            UserName = userName;
            AccountBalance = Constants.DefaultStartingBalance;
            Stocks = new List<Stock>();
            Tiles = new List<Tile>();
        }
    }
}
