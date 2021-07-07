using BlueModas.Domain.Entities.Core;
using System;
using System.Collections.Generic;

namespace BlueModas.Domain.Entities
{
    public class Order : Entity
    {
        public Order() { }

        public Order(Guid clientId)
        {
            ClientId = clientId;
            Date = DateTime.Now;
        }

        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }
        public Guid ClientId { get; private set; }
        public virtual Client Client { get; private set; }

        public void SetAmount(decimal amount)
        {
            Amount = amount;
        }
    }
}
