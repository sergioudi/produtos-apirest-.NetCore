using MediatR;
using apirest.Domain.Entities;

namespace apirest.Domain.Handlers.Produto.Update
{
    public class UpdateProdutoCommand : IRequest<UpdateProdutoCommandResponse>
    {
        public ProdutoEntity Body { get; set; }

        public UpdateProdutoCommand(ProdutoEntity body)
        {
            Body = body;
        }
    }
}
