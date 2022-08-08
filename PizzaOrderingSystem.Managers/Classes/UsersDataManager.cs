using PizzaOrderingSystem.Models.Classes.Users;
using ProjectAssignment.Repositories.Contracts;
using System;

namespace PizzaOrderingSystem.API.DataManagers
{
    public class UsersDataManager : IUsersDataManager
    {
        IUserRepository _userRepository;
        public UsersDataManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User Get(int userId)
        {
           return _userRepository.Get(userId);
        }

        public bool Login(User user)
        {
            return _userRepository.Login(user);

        }

        public bool Save(User user)
        {
            return _userRepository.Save(user);
        }

        public bool Update(User user)
        {
            return _userRepository.Update(user);
        }
    }
}
