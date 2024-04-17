using StockTradingSystem.Domain;

namespace StockTradingSystem.Repository
{
    public class UserRepository
    {
        private static List<User> Users = new List<User>();

        public static void AddUser(User user)
        {
            Users.Add(user);
        }

        public static User GetUser(String name)
        {
            return Users.FirstOrDefault(user => user.Name == name);
        }
    }
}
