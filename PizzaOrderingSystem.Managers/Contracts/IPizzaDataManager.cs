
using PizzaOrderingSystem.Models.Classes.Pizzas;
using System.Collections.Generic;

namespace PizzaOrderingSystem.API.DataManagers
{
    public interface IPizzaDataManager
    {
        List<Pizza> GetAllPizzas();
        List<PizzaBase> GetAllBases();
        List<PizzaTopping> GetAllToppings();
        List<PizzaSauce> GetAllSauses();
        List<PizzaSize> GetAllSizes();
        List<PizzaCheese> GetAllCheeseList();

    }
}
