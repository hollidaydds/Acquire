using Acquire.Objects.Boards;

namespace Acquire.Repositories
{
    public interface ITileManager
    {
        Enums.TileType GetTileType(Tile tile);
        void UpdateTileType(Tile tile, Enums.TileType tileType);
    }
}