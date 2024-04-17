namespace StockTradingSystem.Domain
{
    public class Trade
    {
        public BuyOrder BuyOrder { get; private set; }
        public SellOrder SellOrder { get; private set; }
        public double Price { get; private set; }
        public DateTime Time { get; private set; }

        public Trade(BuyOrder buyOrder, SellOrder sellOrder, double price)
        {
            BuyOrder = buyOrder;
            SellOrder = sellOrder;
            Price = price;
            Time = DateTime.Now;
        }

        public override string ToString()
        {
            if (BuyOrder.Time <= SellOrder.Time)
            {
                return $"{BuyOrder.ToString()}\t{SellOrder.ToString()}\t{Price}";
            }
            else
            {
                return $"{SellOrder.ToString()}\t{BuyOrder.ToString()}\t{Price}";
            }
        }
    }
}
