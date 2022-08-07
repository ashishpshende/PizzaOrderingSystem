using Newtonsoft.Json;
using PizzaOrderingSystem.FileRepositories.Classes.Pizzas;
using PizzaOrderingSystem.Models.Classes.Pizzas;
using ProjectAssignment.Repositories.Contracts;
using System.Collections.Generic;
using System.IO;
namespace PizzaOrderingSystem.FileRepositories.Classes
{
    public class PizzaFileRepository : IPizzaRepository
    {
        private string BaseFolderPath;
        PizzaBaseRepository _pizzaBaseRepository;
        PizzaSauseRepository _pizzaSauseRepository;
        PizzaCheeseRepository _pizzaCheezeRepository;
        PizzaToppingRepository _pizzaToppingRepository;
        PizzaSizeRepository _pizzaSizeRepository;


        public PizzaFileRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
            _pizzaBaseRepository = new PizzaBaseRepository();
            _pizzaSizeRepository = new PizzaSizeRepository();
            _pizzaCheezeRepository = new PizzaCheeseRepository();
            _pizzaSauseRepository = new PizzaSauseRepository();
            _pizzaToppingRepository = new PizzaToppingRepository();

        }

        public List<PizzaBase> GetAllBases()
        {
            return _pizzaBaseRepository.All();
        }

        public List<Pizza> GetAllPizzas()
        {
            List<Pizza> pizzas = new List<Pizza>();            

            var jsonData = System.IO.File.ReadAllText(BaseFolderPath+ "\\pizzaList.json");

            if (string.IsNullOrWhiteSpace(jsonData)) return null;

            pizzas = JsonConvert.DeserializeObject<List<Pizza>>(jsonData);          

            return pizzas;
        }

        public List<PizzaSauce> GetAllSauses()
        {
            return _pizzaSauseRepository.All();
        }

        public List<PizzaSize> GetAllSizes()
        {
            return _pizzaSizeRepository.All();
        }

        public List<PizzaTopping> GetAllToppings()
        {
            return _pizzaToppingRepository.All();
        }

        public List<PizzaCheese> GetAllCheeseList()
        {
            return _pizzaCheezeRepository.All();
        }
    }
}
