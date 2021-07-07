using BlueModas.Domain.Entities;
using BlueModas.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlueModas.Api.Controllers.v1
{
    [Route("v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<Product> Get([FromServices] IProductRepository repository)
        {
            return repository.GetAll();
        }
    }
}