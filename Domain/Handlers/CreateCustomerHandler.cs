using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler: IRequestHandler<CreateCustomerRequest,CreateCustomerResponse>
    {


        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //verifucar se o cliente já está cadastrado
            //Valida os dados
            //Insere o cliente
            //Envia E-mail de boas vindas 

            return Task.FromResult(new  CreateCustomerResponse{
                Id=Guid.NewGuid(),
                Name = "Andre Baltieri",
                Email ="andre@balta.io",
                Date = DateTime.Now
            });
        }
    }
}