using MediatR;
using System;

namespace apirest.Domain.Handlers.Produto.Read
{
    public class ReadProdutoQuery : IRequest<ReadProdutoQueryResponse>
    {
        public Int64 Id { get; set; }

        public ReadProdutoQuery(Int64 id)
        {
            Id = id;
        }
    }
}
