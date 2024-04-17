namespace StockTradingSystem.Domain
{
    public class BuyOrder : Order
    {
        public BuyOrder(string orderId, User user, Stock stock, double price) : base(orderId, user, stock, price)
        {
        }

        public override bool CanTradeWith(Order order)
        {
            if (!order.IsSellOrder() || !order.OfStock(Stock) || order.IsTraded || order.hasSameUser(User))
            {
                return false;
            }

            return order.Price <= Price;
        }

        public override Trade TradeWith(Order order)
        {
            if (!CanTradeWith(order))
            {
                throw new InvalidOperationException("Cannot trade with order");
            }

            Traded();
            order.Traded();

            return new Trade(this, (SellOrder)order, Price);
        }
    }
}
