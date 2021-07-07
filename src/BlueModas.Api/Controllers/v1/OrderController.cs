using BlueModas.Domain.Commands.Core;
using BlueModas.Domain.Commands.Inputs.Order;
using BlueModas.Domain.Entities;
using BlueModas.Domain.Handlers;
using BlueModas.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BlueModas.Api.Controllers.v1
{
    [Route("v1/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("client/{id}")]
        public IEnumerable<Order> GetByClient(Guid id, [FromServices] IOrderRepository repository)
        {
            return repository.GetByClient(id);
        }

        [HttpGet]
        [Route("items/{id}")]
        public IEnumerable<OrderItem> GetOrderItems(Guid id, [FromServices] IOrderItemRepository repository)
        {
            return repository.GetByOrder(id);
        }

        [HttpPost]
        [Route("")]
        public GenericCommandResult Post(
            [FromBody]RegisterOrderCommand command,
            [FromServices]OrderHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}