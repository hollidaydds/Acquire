using System.Collections.Generic;
using Acquire.Objects.Boards;

namespace Acquire.Repositories
{
    public interface IGameBoardManager
    {
        Tile GetTileByCoordinates(Coordinates coordinates);
        List<Tile> GetTileNeigborsByCoordinates(Coordinates coordinates);
        int GetTileTypeCount(Enums.TileType tileType);
        void PrintBoard();
    }
}