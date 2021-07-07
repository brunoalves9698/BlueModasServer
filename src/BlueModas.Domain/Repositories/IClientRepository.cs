using BlueModas.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BlueModas.Domain.Repositories
{
    public interface IClientRepository
    {
        void Save(Client client);
        void Update(Client client);
        bool Delete(Guid id);
        Client GetById(Guid id);
        IEnumerable<Client> GetAll();
    }
}
