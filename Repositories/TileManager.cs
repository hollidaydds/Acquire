using Acquire.Objects.Boards;
using System;
using System.Collections.Generic;
using System.Text;
using static Acquire.Enums;

namespace Acquire.Repositories
{
    public class TileManager
    {
        public void UpdateTileType(Tile tile, TileType tileType)
        {
            tile.TileType = tileType;
        }

        public TileType GetTileType(Tile tile)
        {
            return tile.TileType;
        }
    }
}
