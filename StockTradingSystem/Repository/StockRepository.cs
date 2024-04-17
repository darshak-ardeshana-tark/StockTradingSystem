using StockTradingSystem.Domain;

namespace StockTradingSystem.Repository
{
    public class StockRepository
    {
        private static List<Stock> Stocks = new List<Stock>();

        public static void AddStock(Stock stock)
        {
            Stocks.Add(stock);
        }

        public static Stock GetStock(String code)
        {
            return Stocks.FirstOrDefault(stock => stock.Code == code);
        }
    }
}
