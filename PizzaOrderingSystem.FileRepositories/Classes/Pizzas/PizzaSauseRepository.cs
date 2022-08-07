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
    public class PizzaSauseRepository
    {
        private string BaseFolderPath;
        public PizzaSauseRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
        }

        public List<PizzaSauce> All()
        {
            try
            {
                List<PizzaSauce> bases = new List<PizzaSauce>();
                var jsonData = System.IO.File.ReadAllText(BaseFolderPath + "\\pizzaSauses.json");
                if (string.IsNullOrWhiteSpace(jsonData)) return null;
                bases = JsonConvert.DeserializeObject<List<PizzaSauce>>(jsonData);
                return bases;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
