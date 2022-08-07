using PizzaOrderingSystem.Models.Classes.Pizzas;
using PizzaOrderingSystem.Models.Classes.PurchaseCart;

namespace PizzaOrderingSystem.Models.Classes
{
    public class OrderItem: BaseModel
    {
        public Pizza Pizza { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double DiscountPercent { get; set; }
        public double ItemTotal { get; set; }
        public OrderItem()
        {

        }
        public OrderItem(CartItem cartItem)
        {
            Pizza = cartItem.Pizza;
            Quantity = cartItem.Quantity;
            Discount = cartItem.Discount;
            DiscountPercent = cartItem.DiscountPercent;
            ItemTotal = Quantity * Pizza.Totalprice;
        }
    }
}
