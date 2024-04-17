namespace StockTradingSystem.Domain
{
    public class User
    {
        public String Name { get; private set; }

        public User(String name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            User user = (User)obj;
            return Name.Equals(user.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
