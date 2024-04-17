using StockTradingSystem.Domain;

namespace StockTradingSystem.Repository
{
    public class TradeRepository
    {
        private static List<Trade> Trades = new List<Trade>();

        public static void AddTrade(Trade trade)
        {
            Trades.Add(trade);
            log(trade);
        }

        private static void log(Trade trade)
        {
            int tradeId = Trades.Count;
            String log = $"Trade {tradeId}: {trade.ToString()}";
            Console.WriteLine(log);
        }
    }
}
