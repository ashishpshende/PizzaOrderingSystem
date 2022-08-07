using PizzaOrderingSystem.Models.Classes.PurchaseCart;
using PizzaOrderingSystem.Models.Classes.Users;
using System;
using System.Collections.Generic;

namespace PizzaOrderingSystem.Models.Classes.Orders
{
    public enum OrderStatus
    {
        Ordered,
        Cooking,
        ReadyToPickUp,
        PickedUp,
        InTransit,
        Delivered,
        Cancelled,
        PaymentPending,
        PaymentDone,
        RefundInitiated,
        RefundDone
    }

    public class Order : BaseModel
    {
        public BaseModel User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Address DeliveryAddress { get; set; }
        public Address BillingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public double OrderTotal { get; set; }
        public double Discount { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
            Status = OrderStatus.Ordered;
            OrderTotal = 0;
            Discount = 0;
            OrderDate = DateTime.Now;

        }
        public Order(Cart cart)
        {
            OrderItems = new List<OrderItem>();
            OrderTotal = 0;
            Discount = 0;
            OrderDate = DateTime.Now;
            Status = OrderStatus.Ordered;
            foreach (var cartItem in cart.Items)
            {
                OrderItems.Add(new OrderItem(cartItem));
            }



        }
    }
}
