using BlueModas.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BlueModas.Domain.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
        void Update(Order order);
        bool Delete(Guid id);
        Order GetById(Guid id);
        IEnumerable<Order> GetByClient(Guid clientId);
    }
}
