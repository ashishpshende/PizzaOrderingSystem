

using PizzaOrderingSystem.Models.Classes.Orders;
using ProjectAssignment.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace PizzaOrderingSystem.API.DataManagers
{
    public class OrderDBRepository : IOrderRepository
    {
        public List<Order> Get(int UserId)
        {
            throw new NotImplementedException();
        }

        public bool Save(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
