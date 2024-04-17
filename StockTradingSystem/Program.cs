using StockTradingSystem.Domain;
using StockTradingSystem.Parser;
using StockTradingSystem.Repository;

namespace StockTradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Place the Orders:");
            while (true)
            {
                string input = Console.ReadLine();
                Order order = OrderParser.ParseOrder(input);

                if (order == null)
                {
                    continue;
                }

                TradeEngine.Trade(order);
                OrderRepository.AddOrder(order);
            }
        }
    }
}
