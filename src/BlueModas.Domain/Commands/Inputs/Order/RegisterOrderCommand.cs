using BlueModas.Domain.Commands.Core;
using Flunt.Notifications;
using Flunt.Validations;
using System.Collections.Generic;

namespace BlueModas.Domain.Commands.Inputs.Order
{
    public class RegisterOrderCommand : Notifiable, ICommand
    {
        public RegisterOrderCommand() { }

        public RegisterOrderCommand(ClientCommand client, List<ProductCommand> products)
        {
            Client = client;
            Products = products;
        }

        public ClientCommand Client { get; set; }
        public List<ProductCommand> Products { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(Client.Name, 100, "Client.Name", "O nome do cliente deve conter no máximo 100 caracteres.")
                .IsEmail(Client.Email, "Client.Email", "E-mail inválido.")
                .HasMaxLen(Client.Phone, 15, "Client.Phone", "Telefone inválido.")
                .HasMinLen(Client.ZipCode, 9, "Client.ZipCode", "CEP inválido."));
        }
    }
}
