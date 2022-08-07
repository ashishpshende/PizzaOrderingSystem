using System.Collections.Generic;

namespace PizzaOrderingSystem.Models.Classes.Users
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
