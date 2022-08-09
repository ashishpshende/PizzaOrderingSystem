using PizzaOrderingSystem.Models.Classes.Orders;
using ProjectAssignment.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace PizzaOrderingSystem.API.DataManagers
{
    public class OrderDataManger : IOrderDataManger
    {
        private IOrderRepository _orderRepository;
        public OrderDataManger(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public bool Cancel(Order order)
        {
            return _orderRepository.Cancel(order);
        }

        public Order GetOrder(int OrderId)
        {
            return _orderRepository.GetOrder(OrderId);
        }

        public List<Order> GetOrders(int UserId)
        {
            return _orderRepository.GetOrders(UserId);
        }

        public bool Save(Order order)
        {
            return _orderRepository.Save(order);
        }
    }
}
