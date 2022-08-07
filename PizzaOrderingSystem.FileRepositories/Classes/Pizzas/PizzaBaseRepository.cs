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
    public class PizzaBaseRepository
    {

        private string BaseFolderPath;
        
        public PizzaBaseRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
        }
        
        public List<PizzaBase> All()
        {
            try
            {
                List<PizzaBase> bases = new List<PizzaBase>();
                var jsonData = System.IO.File.ReadAllText(BaseFolderPath + "\\pizzaBaseList.json");
                if (string.IsNullOrWhiteSpace(jsonData)) return null;
                bases = JsonConvert.DeserializeObject<List<PizzaBase>>(jsonData);             
                return bases;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
