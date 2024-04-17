using StockTradingSystem.Domain;

namespace StockTradingSystem.Repository
{
    public class OrderRepository
    {
        private static List<Order> Orders = new List<Order>();

        public static void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public static List<Order> GetOrdersToTrade()
        {
            return Orders.Where(order => !order.IsTraded).ToList();
        }
    }
}
