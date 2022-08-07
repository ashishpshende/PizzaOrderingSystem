using PizzaOrderingSystem.Managers.Contracts;
using PizzaOrderingSystem.Models.Classes.PurchaseCart;
using PizzaOrderingSystem.Models.Classes.Users;
using ProjectAssignment.Repositories.Contracts;

namespace PizzaOrderingSystem.Managers.Classes
{
    public class CartManager : ICartManager
    {
        ICartRepository _cartRepository;
        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public bool AddItem(CartItem cartItem, User user)
        {
            return _cartRepository.AddItem(cartItem, user);
        }

        public bool Clear(User user)
        {
            return _cartRepository.ClearCart( user);

        }

        public Cart Get(User user)
        {
            return _cartRepository.GetCart(user);

        }

        public bool RemoveItem(CartItem cartItem, User user)
        {
            return _cartRepository.RemoveItem(cartItem, user);
        }

        public bool UpdateItem(CartItem cartItem, User user)
        {
            return _cartRepository.UpdateItem(cartItem, user);
        }

    }
}
