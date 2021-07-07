using BlueModas.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace BlueModas.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(
            int quantity, 
            decimal unitPrice, 
            decimal amount, 
            Guid orderId, 
            Guid productId)
        {
            Quantity = quantity;
            UnitPrice = unitPrice;
            Amount = amount;
            OrderId = orderId;
            ProductId = productId;
        }

        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Amount { get; private set; }
        public Guid OrderId { get; private set; }
        public Guid ProductId { get; private set; }
        public virtual Order Order { get; private set; }
        public virtual Product Product { get; private set; }
    }
}
