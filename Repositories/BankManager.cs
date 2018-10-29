using Acquire.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Acquire.Enums;

namespace Acquire.Repositories
{
    public class BankManager
    {
        public void AddBankStock(Bank bank, StockType stockType)
        {
            bank.Stocks.Add(new Stock(stockType));
        }

        public void RemoveBankStock(Bank bank, StockType stockType)
        {
            bank.Stocks.Remove(new Stock(stockType));
        }

        public int BankStockCountForStockType(Bank bank, StockType stockType)
        {
            return bank.Stocks.Count(stocks => stocks.StockType == stockType); 
        }
    }
}
