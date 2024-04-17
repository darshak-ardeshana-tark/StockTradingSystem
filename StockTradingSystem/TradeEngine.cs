using StockTradingSystem.Domain;
using StockTradingSystem.Repository;

namespace StockTradingSystem
{
    public class TradeEngine
    {
        public static Trade Trade(Order order)
        {
            List<Order> ordersToTrade = OrderRepository.GetOrdersToTrade();

            foreach (Order orderToTrade in ordersToTrade)
            {
                if (orderToTrade.CanTradeWith(order))
                {
                    Trade trade = orderToTrade.TradeWith(order);
                    TradeRepository.AddTrade(trade);
                }
            }

            return null;
        }
    }
}
