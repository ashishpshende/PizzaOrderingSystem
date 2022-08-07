using PizzaOrderingSystem.Models.Classes.PurchaseCart;
using PizzaOrderingSystem.Models.Classes.Users;

namespace ProjectAssignment.Repositories.Contracts
{
    public interface ICartRepository
    {
        Cart GetCart(User user);
        bool AddItem(CartItem cartItem, User user);
        bool RemoveItem(CartItem cartItem, User user);
        bool UpdateItem(CartItem cartItem, User user);
        bool ClearCart(User user);
    }
}
