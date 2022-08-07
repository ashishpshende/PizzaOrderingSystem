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
    public class PizzaSizeRepository
    {
        private string BaseFolderPath;
        public PizzaSizeRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
        }

        public List<PizzaSize> All()
        {
            try
            {
                List<PizzaSize> bases = new List<PizzaSize>();
                var jsonData = System.IO.File.ReadAllText(BaseFolderPath + "\\pizzaSizes.json");
                if (string.IsNullOrWhiteSpace(jsonData)) return null;
                bases = JsonConvert.DeserializeObject<List<PizzaSize>>(jsonData);
                return bases;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
