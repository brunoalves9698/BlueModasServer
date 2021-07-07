using BlueModas.Domain.Entities;
using BlueModas.Domain.Repositories;
using BlueModas.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueModas.Infra.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly DataContext _context;

        public OrderItemRepository(DataContext context)
        {
            _context = context;
        }

        public void SaveRange(List<OrderItem> orderItems)
        {
            _context.OrderItem.AddRange(orderItems);
            _context.SaveChanges();
        }

        public void Update(OrderItem orderItem)
        {
            _context.Entry(orderItem).State = EntityState.Modified;
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

        public IEnumerable<OrderItem> GetAll()
        {
            return _context.OrderItem;
        }

        public IEnumerable<OrderItem> GetByOrder(Guid idOrder)
        {
            return _context.OrderItem
                .Include(x => x.Product)
                .Where(x => x.OrderId == idOrder)
                .OrderBy(x => x.Product.Title)
                .ToList();
        }

        public OrderItem GetById(Guid id)
        {
            return _context.OrderItem.SingleOrDefault(x => x.Id == id);
        }
    }
}
