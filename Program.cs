using Acquire.Objects.Boards;
using Acquire.Repositories;
using System;
using static Acquire.Enums;

namespace Acquire
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameBoardManager gameBoardManager = new GameBoardManager();

            gameBoardManager.PlaceTileByCoordinatesAndTileType(new Coordinates(1, 1), TileType.Placed);

            gameBoardManager.PrintBoard();

            gameBoardManager.PlaceTileByCoordinatesAndTileType(new Coordinates(4, 5), TileType.American);

            gameBoardManager.PrintBoard();

            gameBoardManager.PlaceTileByCoordinatesAndTileType(new Coordinates(5, 5), TileType.American);

            gameBoardManager.PrintBoard();

            Console.WriteLine(gameBoardManager.GetTileTypeCount(TileType.Placed));

            Console.WriteLine(gameBoardManager.GetTileTypeCount(TileType.American));

            Console.ReadLine();            
            Console.WriteLine("Hello World!");
        }
    }
}
