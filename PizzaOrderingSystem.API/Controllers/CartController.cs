using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystem.Managers.Contracts;
using PizzaOrderingSystem.Models.Classes.PurchaseCart;
using PizzaOrderingSystem.Models.Classes.Users;

namespace PizzaOrderingSystem.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        ICartManager _cartManager;
        public CartController(ICartManager cartManager)
        {
            _cartManager = cartManager;
        }

        [HttpGet("items")]
        public Cart GetCartItem()
        {
            User user = new User();
            user.Id = 1;
            return _cartManager.Get(user);
        }

        [HttpPost("addItem")]
        public bool AddItemToCart(CartItem cartItem)
        {
            User user = new User();
            return _cartManager.AddItem(cartItem,user);
        }
        [HttpPost("removeItem")]
        public bool RemoveItemFromCart(CartItem cartItem)
        {
            User user = new User();
            return _cartManager.RemoveItem(cartItem, user);

        }
        [HttpPost("clear")]
        public bool ClearCart( User user)
        {
            return _cartManager.Clear(user);

        }
    }
}
