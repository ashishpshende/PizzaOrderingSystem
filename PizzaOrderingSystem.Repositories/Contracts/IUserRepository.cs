using PizzaOrderingSystem.Models.Classes.Users;

namespace ProjectAssignment.Repositories.Contracts
{
    public interface IUserRepository
    {
        public bool Login(User user);
        public bool Save(User user);
        public bool Update(User user);
        public User Get(int userId);
    }
}
