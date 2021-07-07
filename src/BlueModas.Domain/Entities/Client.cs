using BlueModas.Domain.Entities.Core;

namespace BlueModas.Domain.Entities
{
    public class Client : Entity
    {
        public Client() { }

        public Client(
            string name, 
            string email, 
            string phone, 
            string zipCode, 
            string address, 
            string addressNumber, 
            string neighborhood,
            string stateId,
            string cityId)
        {
            Name = name;
            Email = email;
            Phone = phone;
            ZipCode = zipCode;
            Address = address;
            AddressNumber = addressNumber;
            Neighborhood = neighborhood;
            StateId = stateId;
            CityId = cityId;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string ZipCode { get; private set; }
        public string Address { get; private set; }
        public string AddressNumber { get; private set; }
        public string Neighborhood { get; private set; }
        public string StateId { get; private set; }
        public string CityId { get; private set; }

        public void Update(
            string name,
            string email,
            string phone,
            string zipCode,
            string address,
            string addressNumber,
            string neighborhood,
            string stateId,
            string cityId)
        {
            Name = name;
            Email = email;
            Phone = phone;
            ZipCode = zipCode;
            Address = address;
            AddressNumber = addressNumber;
            Neighborhood = neighborhood;
            StateId = stateId;
            CityId = cityId;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
