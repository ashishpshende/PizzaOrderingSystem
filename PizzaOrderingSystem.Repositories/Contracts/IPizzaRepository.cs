using PizzaOrderingSystem.Models.Classes.Pizzas;
using System.Collections.Generic;

namespace ProjectAssignment.Repositories.Contracts
{
    public interface IPizzaRepository
    {
        List<Pizza> GetAllPizzas();
        List<PizzaBase> GetAllBases();
        List<PizzaTopping> GetAllToppings();
        List<PizzaSauce> GetAllSauses();
        List<PizzaSize> GetAllSizes();
        List<PizzaCheese> GetAllCheeseList();

    }
}
