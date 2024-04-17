namespace StockTradingSystem.Domain
{
    public abstract class Order
    {
        public string OrderId { get; private set; }
        public User User { get; private set; }
        public Stock Stock { get; private set; }
        public double Price { get; private set; }
        public DateTime Time { get; private set; }
        public bool IsTraded { get; private set; }

        public Order(string orderId, User user, Stock stock, double price)
        {
            OrderId = orderId;
            User = user;
            Stock = stock;
            Price = price;
            Time = DateTime.Now;
            IsTraded = false;
        }

        public void Traded()
        {
            IsTraded = true;
        }

        public bool OfStock(Stock stock) => Stock.Equals(stock);

        public bool hasSameUser(User user)
        {
            return User.Equals(user);
        }

        public override string ToString()
        {
            String orderType = this is BuyOrder ? "Buy" : "Sell";
            return $"{OrderId} ({orderType})";
        }

        public bool IsBuyOrder() => this is BuyOrder;
        public bool IsSellOrder() => this is SellOrder;

        public abstract bool CanTradeWith(Order order);
        public abstract Trade TradeWith(Order order);
    }
}
