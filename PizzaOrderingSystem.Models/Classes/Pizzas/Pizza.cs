using System.Collections.Generic;

namespace PizzaOrderingSystem.Models.Classes.Pizzas
{

    public class Pizza : BaseModel
    {
        public string Type { get; set; }
        public string Image { get; set; }
        public double BasePrice { get; set; }
        public double Totalprice { get; set; }
        public List<PizzaSauce> Sauce { get; set; }
        public List<PizzaTopping> Toppings { get; set; }
        public PizzaBase Base { get; set; }
        public PizzaSize Size { get; set; }

        public Pizza()
        {
            Image = string.Empty;
            Sauce = new List<PizzaSauce>();
            Toppings = new List<PizzaTopping>();
            Base = new PizzaBase();
            Size = new PizzaSize();

        }
    }
}
