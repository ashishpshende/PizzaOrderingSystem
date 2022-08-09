using System.Collections.Generic;

namespace PizzaOrderingSystem.Models.Classes.Pizzas
{

    public class Pizza : BaseModel
    {
        public string Type { get; set; }
        public string Image { get; set; }
        public double BasePrice { get; set; }
        public double Totalprice { get; set; }
        public PizzaSauce Sauce { get; set; }
        public PizzaTopping Topping { get; set; }
        public PizzaBase Base { get; set; }
        public PizzaSize Size { get; set; }
        public PizzaCheese Cheese { get; set; }

        public Pizza()
        {
            Image = string.Empty;
            Sauce = new PizzaSauce();
            Topping = new PizzaTopping();
            Base = new PizzaBase();
            Size = new PizzaSize();

        }
    }
}
