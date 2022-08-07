using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using PizzaOrderingSystem.Models.Classes.Pizzas;

namespace PizzaOrderingSystem.FileRepositories.Classes.Pizzas
{
    public class PizzaCheeseRepository 
    {
        private string BaseFolderPath;
        public PizzaCheeseRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
        }
        public List<PizzaCheese> All()
        {
            try
            {
                List<PizzaCheese> cheeseCollection = new List<PizzaCheese>();
                var jsonData = System.IO.File.ReadAllText(BaseFolderPath + "\\pizzaCheeseList.json");
                if (string.IsNullOrWhiteSpace(jsonData)) return null;
                cheeseCollection = JsonConvert.DeserializeObject<List<PizzaCheese>>(jsonData);
                return cheeseCollection;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
