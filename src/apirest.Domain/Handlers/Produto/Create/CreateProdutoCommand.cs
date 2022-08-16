using MediatR;
using apirest.Domain.Entities;

namespace apirest.Domain.Handlers.Produto.Create
{
    public class CreateProdutoCommand : IRequest
    {
        public ProdutoEntity Body { get; set; }

        public CreateProdutoCommand(ProdutoEntity body)
        {
            Body = body;
        }
    }
}
