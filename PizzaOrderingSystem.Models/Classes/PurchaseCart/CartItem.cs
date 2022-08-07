using PizzaOrderingSystem.Models.Classes.Pizzas;

namespace PizzaOrderingSystem.Models.Classes.PurchaseCart
{
    public class CartItem : BaseModel
    {
        public Pizza Pizza { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double DiscountPercent { get; set; }


    }
}
