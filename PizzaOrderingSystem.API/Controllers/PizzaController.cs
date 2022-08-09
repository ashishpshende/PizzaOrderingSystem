using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystem.API.DataManagers;
using PizzaOrderingSystem.Models.Classes.Pizzas;
using System.Collections.Generic;

namespace PizzaOrderingSystem.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IPizzaDataManager _pizzaDataManager;
        public PizzaController(IPizzaDataManager pizzaDataManager)
        {
            _pizzaDataManager = pizzaDataManager;
        }

        [HttpGet("all")]
        public List<Pizza> GetAllPizzas()
        {
            List<Pizza> results = _pizzaDataManager.GetAllPizzas();

            return results;
        }

        [HttpGet("sizes")]
        public List<PizzaSize> GetAllSizes()
        {
            List<PizzaSize> results = _pizzaDataManager.GetAllSizes();

            return results;
        }
        [HttpGet("sauces")]
        public List<PizzaSauce> GetAllSauses()
        {
            List<PizzaSauce> results = _pizzaDataManager.GetAllSauses();

            return results;
        }
        [HttpGet("Topping")]
        public List<PizzaTopping> GetAllTopping()
        {
            List<PizzaTopping> results = _pizzaDataManager.GetAllTopping();

            return results;
        }
        [HttpGet("cheeses")]
        public List<PizzaCheese> GetSizes()
        {
            List<PizzaCheese> results = _pizzaDataManager.GetAllCheeseList();

            return results;
        }
        [HttpGet("bases")]
        public List<PizzaBase> GetBases()
        {
            List<PizzaBase> results = _pizzaDataManager.GetAllBases();

            return results;
        }
    }
}
