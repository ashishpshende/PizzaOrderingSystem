namespace PizzaOrderingSystem.Models.Classes.Users
{
    public class Address : BaseModel
    {
       
        public string Plot { get; set; }

        public string Landmark { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

    }
}
