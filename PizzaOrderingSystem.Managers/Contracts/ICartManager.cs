using PizzaOrderingSystem.Models.Classes.PurchaseCart;
using PizzaOrderingSystem.Models.Classes.Users;

namespace PizzaOrderingSystem.Managers.Contracts
{
    public interface ICartManager
    {
        Cart Get(User user);
        bool AddItem(CartItem cartItem, User user);
        bool RemoveItem(CartItem cartItem, User user);
        bool UpdateItem(CartItem cartItem, User user);
        bool Clear(User user);

    }
}
