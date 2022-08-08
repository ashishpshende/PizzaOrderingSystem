using Newtonsoft.Json;
using PizzaOrderingSystem.Models.Classes.PurchaseCart;
using PizzaOrderingSystem.Models.Classes.Users;
using ProjectAssignment.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PizzaOrderingSystem.FileRepositories.Classes
{
    public class CartFileRepository : ICartRepository
    {
        private string BaseFolderPath;
        private string FilePath;

        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        public CartFileRepository()
        {
            var path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf('\\'));
            BaseFolderPath = Path.Combine(path, "PizzaOrderingSystem.FileRepositories\\AppData");
            FilePath = BaseFolderPath + "\\cart.json";
        }
        public bool AddItem(CartItem cartItem, User user)
        {           
            try
            {
                var cart = new Cart();
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonData);
                cart = carts.FirstOrDefault(x => x.User.Id == cartItem.Id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ClearCart(User user)
        {
            try
            {
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonData);
                foreach (var cart in carts)
                {
                    if (cart.User.Id == user.Id)
                    {
                        cart.Items = new List<CartItem>();
                        break;
                    }
                }
            
                var jsonString = System.Text.Json.JsonSerializer.Serialize(carts, _options);
                File.WriteAllText(FilePath, jsonString);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cart GetCart(User user)
        {
            try
            {
                var cart = new Cart();
                var jsonData = System.IO.File.ReadAllText(BaseFolderPath + "\\cart.json");
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonData);
                cart = carts.FirstOrDefault(x => x.User.Id == user.Id);
                return cart;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool RemoveItem(CartItem cartItem, User user)
        {
            try
            {
                Cart userCart = null;
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonData);
                foreach (var cart in carts)
                {
                    if (cart.User.Id == user.Id)
                    {                        
                        var index = 0;
                        foreach (var userCartItem in cart.Items)
                        {
                            if (cartItem.Id == userCartItem.Id)
                                break;
                            index++;
                        }
                        userCart.Items.RemoveAt(++index);
                    }
                }              
                var jsonString = System.Text.Json.JsonSerializer.Serialize(carts, _options);
                File.WriteAllText(FilePath, jsonString);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateItem(CartItem cartItem, User user)
        {
            try
            {
                Cart userCart = null;
                var jsonData = System.IO.File.ReadAllText(FilePath);
                var carts = JsonConvert.DeserializeObject<List<Cart>>(jsonData);
                foreach (var cart in carts)
                {
                    if (cart.User.Id == user.Id)
                    {
                        var index = 0;
                        foreach (var userCartItem in cart.Items)
                        {
                            if (cartItem.Id == userCartItem.Id)
                                break;
                            index++;
                        }
                        userCart.Items.RemoveAt(index+1);
                        userCart.Items.Insert(index + 1, cartItem);

                    }
                }
                var jsonString = System.Text.Json.JsonSerializer.Serialize(carts, _options);
                File.WriteAllText(FilePath, jsonString);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
