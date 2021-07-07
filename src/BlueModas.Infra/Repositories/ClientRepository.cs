using BlueModas.Domain.Entities;
using BlueModas.Domain.Repositories;
using BlueModas.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueModas.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;

        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public void Save(Client client)
        {
            _context.Client.Add(client);
            _context.SaveChanges();
        }

        public void Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
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

        public IEnumerable<Client> GetAll()
        {
            return _context.Client.OrderBy(x => x.Name);
        }

        public Client GetById(Guid id)
        {
            return _context.Client.SingleOrDefault(x => x.Id == id);
        }
    }
}
