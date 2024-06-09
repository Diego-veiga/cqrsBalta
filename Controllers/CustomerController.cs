using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Handlers;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody]CreateCustomerRequest command)
            {
                 return handler.Handle(command);
            } 
    }
}