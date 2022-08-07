using PizzaOrderingSystem.Models.Classes.Orders;
using System;
using System.Collections.Generic;
namespace PizzaOrderingSystem.API.DataManagers
{
    public interface IOrderDataManger
    {
        public bool Save(Order order);
        public List<Order> Get(int UserId);
    }
}
