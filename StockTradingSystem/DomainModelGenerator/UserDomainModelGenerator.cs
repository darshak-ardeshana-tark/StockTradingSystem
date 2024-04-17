using StockTradingSystem.Domain;
using StockTradingSystem.Repository;

namespace StockTradingSystem.DomainModelGenerator
{
    public class UserDomainModelGenerator
    {
        public static User GenerateUserDomainModel(string userName)
        {
            var user = UserRepository.GetUser(userName);

            if (user == null)
            {
                user = new User(userName);
                UserRepository.AddUser(user);
            }

            return user;
        }
    }
}
