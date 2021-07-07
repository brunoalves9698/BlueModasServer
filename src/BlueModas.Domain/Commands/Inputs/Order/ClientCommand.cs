using System;

namespace BlueModas.Domain.Commands.Inputs.Order
{
    public class ClientCommand
    {
        public ClientCommand() { }

        public ClientCommand(
            Guid? id,
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
            Id = id;
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

        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Neighborhood { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
    }
}
