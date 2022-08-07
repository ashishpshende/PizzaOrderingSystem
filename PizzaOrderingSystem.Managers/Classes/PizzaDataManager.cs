
using PizzaOrderingSystem.Models.Classes.Pizzas;
using ProjectAssignment.Repositories.Contracts;
using System;
using System.Collections.Generic;
namespace PizzaOrderingSystem.API.DataManagers
{
    public class PizzaDataManager : IPizzaDataManager
    {
        IPizzaRepository _pizzaRepository;
        public PizzaDataManager(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public List<PizzaBase> GetAllBases()
        {
            return _pizzaRepository.GetAllBases();
        }

        public List<PizzaCheese> GetAllCheeseList()
        {
            return _pizzaRepository.GetAllCheeseList();
        }

        public List<Pizza> GetAllPizzas()
        {
            return _pizzaRepository.GetAllPizzas();
            
        }

        public List<PizzaSauce> GetAllSauses()
        {
            return _pizzaRepository.GetAllSauses();
        }

        public List<PizzaSize> GetAllSizes()
        {
            return _pizzaRepository.GetAllSizes();
        }

        public List<PizzaTopping> GetAllToppings()
        {
            return _pizzaRepository.GetAllToppings();
        }

      
    }
}
