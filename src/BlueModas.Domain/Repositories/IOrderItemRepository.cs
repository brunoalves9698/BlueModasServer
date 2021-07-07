using BlueModas.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BlueModas.Domain.Repositories
{
    public interface IOrderItemRepository
    {
        void SaveRange(List<OrderItem> orderItems);
        void Update(OrderItem orderItem);
        bool Delete(Guid id);
        OrderItem GetById(Guid id);
        IEnumerable<OrderItem> GetAll();
        IEnumerable<OrderItem> GetByOrder(Guid idOrder);
    }
}
