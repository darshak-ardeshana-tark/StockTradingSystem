using StockTradingSystem.Domain;
using StockTradingSystem.Repository;

namespace StockTradingSystem.DomainModelGenerator
{
    public class StockDomainGenerator
    {
        public static Stock GenerateStockDomainModel(string stockCode)
        {
            var stock = StockRepository.GetStock(stockCode);

            if (stock == null)
            {
                stock = new Stock(stockCode);
                StockRepository.AddStock(stock);
            }

            return stock;
        }
    }
}
