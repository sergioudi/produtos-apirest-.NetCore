using MediatR;
using System;

namespace apirest.Domain.Handlers.Produto.Remove
{
    public class RemoveProdutoCommand : IRequest<RemoveProdutoCommandResponse>
    {
        public Int64 Id { get; set; }

        public RemoveProdutoCommand(Int64 id)
        {
            Id = id;
        }
    }
}
