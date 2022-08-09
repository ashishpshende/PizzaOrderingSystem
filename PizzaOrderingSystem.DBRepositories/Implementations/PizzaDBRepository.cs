
using PizzaOrderingSystem.Models.Classes.Pizzas;
using ProjectAssignment.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace PizzaOrderingSystem.API.DataManagers
{
    public class PizzaDBRepository : IPizzaRepository
    {
        public List<PizzaBase> GetAllBases()
        {
            throw new System.NotImplementedException("DB Not Connected. Using File System for Storage");
        }

        public List<PizzaCheese> GetAllCheeseList()
        {
            throw new System.NotImplementedException("DB Not Connected. Using File System for Storage");
        }

        public List<Pizza> GetAllPizzas()
        {
            throw new System.NotImplementedException("DB Not Connected. Using File System for Storage");
        }

        public List<PizzaSauce> GetAllSauses()
        {
            throw new System.NotImplementedException("DB Not Connected. Using File System for Storage");
        }

        public List<PizzaSize> GetAllSizes()
        {
            throw new System.NotImplementedException("DB Not Connected. Using File System for Storage");
        }

        public List<PizzaTopping> GetAllTopping()
        {
            throw new System.NotImplementedException("DB Not Connected. Using File System for Storage");
        }
       
    }
}
