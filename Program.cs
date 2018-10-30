using Acquire.Objects.Boards;
using Acquire.Repositories;
using System;

namespace Acquire
{
    public class Program
    {
        static void Main(string[] args)
        {
            TileManager tileManager = new TileManager();
            GameBoardManager gameBoardManager = new GameBoardManager();

            tileManager.UpdateTileType(gameBoardManager.GetTileByCoordinates(1, 1), Enums.TileType.Blocked);

            gameBoardManager.PrintBoard();


            //foreach (Tile t in gameBoard.Tiles)
            //{
            //    Console.WriteLine($"row: {t.Coordinates.Row} col:{t.Coordinates.Column} type:{t.TileType}");
            //}



            var hi = gameBoardManager.GetTileByCoordinates(3, 4);

            tileManager.UpdateTileType(hi, Enums.TileType.Placed);
            var tiles = gameBoardManager.GetTileNeigborsByCoordinates(1, 1);

            tileManager.UpdateTileType(gameBoardManager.GetTileByCoordinates(3, 4), Enums.TileType.Continental);
            gameBoardManager.PrintBoard();

            Console.ReadLine();            
            Console.WriteLine("Hello World!");
        }
    }
}
