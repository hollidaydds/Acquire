using static Acquire.Enums;

namespace Acquire.Objects.Boards
{
    public class Tile
    {
        public TileType TileType { get; set; }
        public Coordinates Coordinates { get; set; }

        public Tile(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            TileType = TileType.Empty;
        }
    }
}
