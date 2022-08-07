using System;
using PizzaOrderingSystem.Models.Classes.Users;
using ProjectAssignment.Repositories.Contracts;

namespace PizzaOrderingSystem.API.DataManagers
{
    public class UserDBRepository : IUserRepository
    {
        public User Get(int userId)
        {
            throw new NotImplementedException();
        }

        public bool Save(User user)
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
