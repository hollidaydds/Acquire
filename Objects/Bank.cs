using System;
using System.Collections.Generic;
using System.Text;
using static Acquire.Enums;

namespace Acquire.Objects
{
    public class Bank
    {
        public List<Stock> Stocks { get; set; }

        public Bank(string userName)
        {
            Stocks = new List<Stock>();
            var stocksTypes = EnumExtensions.GetValues<StockType>();

            foreach (StockType stockType in stocksTypes)
            {
                for (int i = 1; i <= Constants.DefaultStocksPerHotel; i++)
                {
                    Stocks.Add(new Stock(stockType));
                }
            }
        }
    }
}
