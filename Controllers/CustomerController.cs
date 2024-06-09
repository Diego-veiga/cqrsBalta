using MediatR;
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
        public async Task<IActionResult>  Create(
            [FromServices] IMediator mediator,
            [FromBody]CreateCustomerRequest command)
            {
                  mediator.Send(command);
                 return Ok();
            } 
    }
}