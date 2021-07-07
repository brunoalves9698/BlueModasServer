using BlueModas.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BlueModas.Domain.Repositories
{
    public interface IProductRepository
    {
        void Save(Product product);
        void Update(Product product);
        bool Delete(Guid id);
        Product GetById(Guid id);
        IEnumerable<Product> GetAll();
    }
}
