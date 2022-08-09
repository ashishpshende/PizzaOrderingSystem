using Newtonsoft.Json;
using PizzaOrderingSystem.Models.Classes.Orders;
using ProjectAssignment.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PizzaOrderingSystem.FileRepositories.Classes
{
    public class OrderFileRepository : IOrderRepository
    {

        private string BaseFolderPath;
        private string FilePath;

        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        public OrderFileRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
            FilePath = BaseFolderPath + "\\orders.json";
        }
        public bool Cancel(Order order)
        {
            try
            {
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
                var index = 0;
                foreach (var existingorder in orders)
                {
                    if (existingorder.Id == order.Id)
                    {
                        existingorder.Status = OrderStatus.Cancelled;
                        order = existingorder;
                    }
                }
                orders.RemoveAt(index + 1);
                orders.Add(order);
                var jsonString = System.Text.Json.JsonSerializer.Serialize(orders, _options);
                File.WriteAllText(FilePath, jsonString);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Order GetOrder(int OrderId)
        {
            try
            {
                var order = new Order();
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
                order = orders.FirstOrDefault(x => x.Id == OrderId);
                return order;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Order> GetOrders(int UserId)
        {
            try
            {
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);
                return orders.FindAll(x => x.Id == UserId);                ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Save(Order order)
        {
            try
            {
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var orders = JsonConvert.DeserializeObject<List<Order>>(jsonData);                
                orders.Add(order);
                var jsonString = System.Text.Json.JsonSerializer.Serialize(orders, _options);
                File.WriteAllText(FilePath, jsonString);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
