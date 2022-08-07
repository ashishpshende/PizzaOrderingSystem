using System.Collections.Generic;

namespace PizzaOrderingSystem.Models.Classes.PurchaseCart
{
    public class Cart : BaseModel
    {
        public BaseModel User { get; set; }
        public List<CartItem> Items { get; set; }
        public double CartTotal { get; set; }

        public Cart()
        {
            Items = new List<CartItem>();
            CartTotal = 0;
        }
    }
}
