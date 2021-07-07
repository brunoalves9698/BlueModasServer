using BlueModas.Domain.Commands.Core;
using BlueModas.Domain.Commands.Inputs.Order;
using BlueModas.Domain.Entities;
using BlueModas.Domain.Handlers.Core;
using BlueModas.Domain.Repositories;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace BlueModas.Domain.Handlers
{
    public class OrderHandler : Notifiable, IHandler<RegisterOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IProductRepository _productRepository;
        private readonly IClientRepository _clientRepository;

        public OrderHandler(
            IOrderRepository orderRepository,
            IOrderItemRepository orderItemRepository,
            IProductRepository productRepository,
            IClientRepository clientRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _productRepository = productRepository;
            _clientRepository = clientRepository;
        }

        public ICommandResult Handle(RegisterOrderCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Dados inválidos. Verifique o preenchimento dos campos e tente novamente.", command.Notifications);

            // Gerar Entidades
            Client client;
            if (command.Client.Id == null || command.Client.Id == Guid.Empty)
            {
                client = new Client(
                command.Client.Name,
                command.Client.Email,
                command.Client.Phone,
                command.Client.ZipCode,
                command.Client.Address,
                command.Client.AddressNumber,
                command.Client.Neighborhood,
                command.Client.StateId,
                command.Client.CityId);
            }
            else
            {
                client = _clientRepository.GetById(Guid.Parse(command.Client.Id.ToString()));
                client.Update(
                command.Client.Name,
                command.Client.Email,
                command.Client.Phone,
                command.Client.ZipCode,
                command.Client.Address,
                command.Client.AddressNumber,
                command.Client.Neighborhood,
                command.Client.StateId,
                command.Client.CityId);
            }

            var order = new Order(client.Id);
            var amount = decimal.Parse("0");

            var orderItems = new List<OrderItem>();
            foreach(var item in command.Products)
            {
                Product product = _productRepository.GetById(item.Id);
                var orderItem = new OrderItem(
                    item.Quantity,
                    product.Price,
                    item.Quantity * product.Price,
                    order.Id,
                    product.Id);

                orderItems.Add(orderItem);

                amount += orderItem.Amount;
            }

            order.SetAmount(amount);

            // Checa as Notificações
            if (Invalid)
                return new GenericCommandResult(false, "Dados inválidos. Verifique o preenchimento dos campos e tente novamente.", Notifications);

            // Salva as Informações
            using (var transaction = new TransactionScope())
            {
                if(command.Client.Id == null || command.Client.Id == Guid.Empty)
                    _clientRepository.Save(client);
                else
                    _clientRepository.Update(client);

                _orderRepository.Save(order);
                _orderItemRepository.SaveRange(orderItems);
                transaction.Complete();
            }
               
            // Retorna as Informações
            return new GenericCommandResult(true, "Compra realizada com sucesso.", new { 
                orderId = order.Id, 
                clientId = client.Id 
            });
        }
    }
}
