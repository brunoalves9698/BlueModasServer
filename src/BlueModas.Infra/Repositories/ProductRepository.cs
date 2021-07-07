using BlueModas.Domain.Entities;
using BlueModas.Domain.Repositories;
using BlueModas.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueModas.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public bool Delete(Guid id)
        {
            try
            {
                _context.Remove(GetById(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Product.OrderBy(x => x.Title);
        }

        public Product GetById(Guid id)
        {
            return _context.Product.SingleOrDefault(x => x.Id == id);
        }
    }
}
