using PizzaOrderingSystem.Models.Classes.Orders;
using System;
using System.Collections.Generic;
namespace PizzaOrderingSystem.API.DataManagers
{
    public interface IOrderDataManger
    {
        public bool Save(Order order);
        public Order GetOrder(int OrderId);
        public List<Order> GetOrders(int UserId);
    }
}
