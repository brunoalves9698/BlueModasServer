using BlueModas.Domain.Entities;
using BlueModas.Domain.Repositories;
using BlueModas.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueModas.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Order order)
        {
            _context.Order.Add(order);
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
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

        public IEnumerable<Order> GetByClient(Guid clientId)
        {
            return _context.Order
                .Include(x => x.Client)
                .Where(x => x.ClientId == clientId)
                .OrderBy(x => x.Date);
        }

        public Order GetById(Guid id)
        {
            return _context.Order.SingleOrDefault(x => x.Id == id);
        }
    }
}
