using PizzaOrderingSystem.Models.Classes.Pizzas;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Xml.Linq;
using System;

namespace PizzaOrderingSystem.FileRepositories.Classes.Pizzas
{
    public class PizzaToppingRepository
    {
        private string BaseFolderPath;

        public PizzaToppingRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
        }

        public List<PizzaTopping> All()
        {
            try
            {
                List<PizzaTopping> bases = new List<PizzaTopping>();
                var jsonData = System.IO.File.ReadAllText(BaseFolderPath + "\\pizzaToppings.json");
                if (string.IsNullOrWhiteSpace(jsonData)) return null;
                bases = JsonConvert.DeserializeObject<List<PizzaTopping>>(jsonData);
                return bases;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
