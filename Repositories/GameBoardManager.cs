using Acquire.Objects.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Acquire.Enums;

namespace Acquire.Repositories
{
    public class GameBoardManager : IGameBoardManager
    {
        private GameBoard gameBoard = new GameBoard();
        private readonly TileManager tileManager = new TileManager();

        internal void PlaceTileByCoordinatesAndTileType(Coordinates coordinates, TileType tileType)
        {
            tileManager.UpdateTileType(GetTileByCoordinates(coordinates), tileType);
        }

        public Tile GetTileByCoordinates(Coordinates coordinates)
        {
            var row = coordinates.Row;
            var col = coordinates.Column;

            return gameBoard.Tiles.Find(tile => tile.Coordinates.Row == row && tile.Coordinates.Column == col);
        }

        public List<Tile> GetTileNeigborsByCoordinates(Coordinates coordinates)
        {
            var row = coordinates.Row;
            var col = coordinates.Column;

            List<Tile> neighbors = new List<Tile>
            {
                GetTileByCoordinates(new Coordinates(row, col - 1)),
                GetTileByCoordinates(new Coordinates(row, col + 1)),
                GetTileByCoordinates(new Coordinates(row - 1, col)),
                GetTileByCoordinates(new Coordinates(row + 1, col))
            };

            neighbors.RemoveAll(tile => tile == null);

            return neighbors;
        }

        public int GetTileTypeCount(TileType tileType)
        {
            return gameBoard.Tiles.Count(tile => tile.TileType == tileType);
        }

        public void PrintBoard()
        {
            for (int c = 1; c <= Constants.DefaultGameboardRows; c++)
            {
                Console.WriteLine();
                for (int r = 1; r <= Constants.DefaultGameBoardColumns; r++)
                {
                    var tile = GetTileByCoordinates(new Coordinates(c, r));
                    Console.Write($" |{tile.TileType}| ");
                }
            }
            Console.WriteLine();
        }


    }
}
