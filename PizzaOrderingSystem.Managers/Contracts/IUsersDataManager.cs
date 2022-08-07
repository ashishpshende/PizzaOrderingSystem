
using PizzaOrderingSystem.Models.Classes.Users;

namespace PizzaOrderingSystem.API.DataManagers
{
    public interface IUsersDataManager
    {
        public bool Login(User user);
        public bool Save(User user);
        public bool Update(User user);
        public User Get(int userId);

    }
}
