using PizzaOrderingSystem.Models.Classes.Orders;
using System.Collections.Generic;

namespace ProjectAssignment.Repositories.Contracts
{
    public interface IOrderRepository
    {
        public bool Save(Order order);
        public Order GetOrder(int OrderId);
        public List<Order> GetOrders(int UserId);
        public bool Cancel(Order order);
    }
}
