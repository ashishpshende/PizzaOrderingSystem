using PizzaOrderingSystem.Managers.Contracts;

namespace PizzaOrderingSystem.Managers.Classes
{
    public class PaymentDataManager : IPaymentDataManager
    {
        public bool Pay(double amount, string OrderId)
        {
            return true;
        }

        public void PaymentFailureCallback(string error, string OrderId)
        {

        }

        public void PaymentSuccessCallback(string transaction, string OrderId)
        {
        }

        public bool Refund(double amount, string OrderId)
        {
            return true;
        }

        public void RefundFailureCallback(string error, string OrderId)
        {

        }

        public void RefundSuccessCallback(string transaction, string OrderId)
        {
        }
    }
}
