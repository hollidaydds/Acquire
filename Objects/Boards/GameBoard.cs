using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Objects.Boards
{
    public class GameBoard
    {
        public List<Tile> Tiles { get; set; }

        public GameBoard()
        {
            Tiles = new List<Tile>();
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Tiles.Add(new Tile(i, j));
                }
            }
        }

    }
}
