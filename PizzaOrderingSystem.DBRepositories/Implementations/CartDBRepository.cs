using PizzaOrderingSystem.Models.Classes.PurchaseCart;
using PizzaOrderingSystem.Models.Classes.Users;
using ProjectAssignment.Repositories.Contracts;

namespace PizzaOrderingSystem.DBRepositories.Implementations
{
    public class CartDBRepository : ICartRepository
    {
        public Cart GetCart(User user)
        {
            throw new System.NotImplementedException();
        }
        public bool AddItem(CartItem cartItem, User user)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveItem(CartItem cartItem, User user )
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateItem(CartItem cartItem, User user )
        {   
            throw new System.NotImplementedException();
        }

        public bool ClearCart(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
