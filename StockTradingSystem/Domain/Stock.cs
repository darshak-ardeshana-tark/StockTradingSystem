namespace StockTradingSystem.Domain
{
    public class Stock
    {
        public String Code { get; private set; }

        public Stock(String code)
        {
            Code = code;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Stock stock = (Stock)obj;
            return Code.Equals(stock.Code);
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }
    }
}
