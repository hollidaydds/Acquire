using Acquire.Objects;
using Acquire.Objects.Boards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acquire.Repositories
{
    class PlayerManager
    {
        // Balance Management
        public void AddPLayerBalance(Player player, int amount)
        {
            player.AccountBalance += amount;
        }

        public void DeductPLayerBalance(Player player, int amount)
        {
            player.AccountBalance -= amount;
        }

        // Stock Management
        public void AddPlayerStock(Player player, Stock stock)
        {
            player.Stocks.Add(stock);
        }

        public void RemovePlayerStock(Player player, Stock stock)
        {
            player.Stocks.Remove(stock);
        }

        // Tile Management
        public void AddPLayerTile(Player player, Tile tile)
        {
            player.Tiles.Add(tile);
        }

        public void RemovePlayerTile(Player player, Tile tile)
        {
            player.Tiles.Remove(tile);
        }
    }
}
