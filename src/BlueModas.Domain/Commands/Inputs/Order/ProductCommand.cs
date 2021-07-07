using System;

namespace BlueModas.Domain.Commands.Inputs.Order
{
    public class ProductCommand
    {
        public ProductCommand() { }

        public ProductCommand(Guid id, int quantity)
        {
            Id = id;
            Quantity = quantity;
        }

        public Guid Id { get; set; }
        public int Quantity { get; set; }
    }
}
