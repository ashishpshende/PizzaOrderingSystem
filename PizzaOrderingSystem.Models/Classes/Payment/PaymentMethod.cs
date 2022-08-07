namespace PizzaOrderingSystem.Models.Classes.Payment
{
    public enum PaymentMethodType
    {
        DebitCard,
        CreditCard,
        NetBanking,
        UPI,
        Wallet
    }
    public class PaymentMethod : BaseModel
    {
        public PaymentMethodType Type  { get; set; }
    }
}
