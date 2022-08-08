using System.Collections.Generic;

namespace PizzaOrderingSystem.Models.Classes.Users
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Token{ get; set; }


        public List<Address> Addresses { get; set; }
    }
}
