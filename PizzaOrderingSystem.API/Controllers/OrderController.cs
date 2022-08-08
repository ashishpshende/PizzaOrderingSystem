using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystem.API.DataManagers;
using PizzaOrderingSystem.Models.Classes.Orders;
using System.Collections.Generic;

namespace PizzaOrderingSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderDataManger _orderDataManger;
        public OrderController(IOrderDataManger orderDataManger)
        {
            _orderDataManger = orderDataManger;
        }

        [HttpGet("all")]
        public List<Order> GetAllOrders()
        {
            List<Order> results = _orderDataManger.GetOrders(1);

            return results;
        }

    }
}
