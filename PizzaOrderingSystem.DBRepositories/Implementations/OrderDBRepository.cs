

using PizzaOrderingSystem.Models.Classes.Orders;
using ProjectAssignment.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace PizzaOrderingSystem.API.DataManagers
{
    public class OrderDBRepository : IOrderRepository
    {
        public bool Cancel(Order order)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int OrderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(int UserId)
        {
            throw new NotImplementedException();
        }

        public bool Save(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
