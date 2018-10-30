using Acquire.Objects.Boards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Repositories
{
    public class GameBoardManager
    {
        private GameBoard gameBoard = new GameBoard();

        public Tile GetTileByCoordinates(int row, int col)
        {
            return gameBoard.Tiles.Find(tile => tile.Coordinates.Row == row && tile.Coordinates.Column == col);
        }

        public List<Tile> GetTileNeigborsByCoordinates(int row, int col)
        {
            List<Tile> neighbors = new List<Tile>
            {
                GetTileByCoordinates(row, col - 1),
                GetTileByCoordinates(row, col + 1),
                GetTileByCoordinates(row - 1, col),
                GetTileByCoordinates(row + 1, col)
            };

            return neighbors;
        }

        public void PrintBoard()
        {
            for (int c = 1; c <= Constants.DefaultGameboardRows; c++)
            {
                Console.WriteLine();
                for (int r = 1; r <= Constants.DefaultGameBoardColumns; r++)
                {
                    var tile = GetTileByCoordinates(c, r);
                    Console.Write($" |{tile.TileType}| ");
                }
            }
        }


    }
}
