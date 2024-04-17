using StockTradingSystem.Domain;
using StockTradingSystem.DomainModelGenerator;
using System.Diagnostics;

namespace StockTradingSystem.Parser
{
    public class OrderParser
    {
        readonly static string SEPARATOR = ",";
        readonly static string SELL = "OFFER";
        readonly static string BUY = "BID";

        public static Order? ParseOrder(string input)
        {
            string[] inputArray = input.Split(SEPARATOR);

            string orderId = inputArray[0];
            string userName = inputArray[1];
            string stockCode = inputArray[2];
            string orderType = inputArray[3];
            int price = int.Parse(inputArray[4]);

            var user = UserDomainModelGenerator.GenerateUserDomainModel(userName);
            var stock = StockDomainGenerator.GenerateStockDomainModel(stockCode);

            if (orderType == BUY)
            {
                return new BuyOrder(orderId, user, stock, price);
            }
            else if (orderType == SELL)
            {
                return new SellOrder(orderId, user, stock, price);
            }
            else
            {
                Debug.WriteLine("Invalid order type");
                return null;
            }
        }
    }
}
