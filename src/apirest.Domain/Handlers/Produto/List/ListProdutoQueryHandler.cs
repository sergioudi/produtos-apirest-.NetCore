using Liquid.Repository;
using MediatR;
using apirest.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace apirest.Domain.Handlers.Produto.List
{
    public class ListProdutoQueryHandler : IRequestHandler<ListProdutoQuery, ListProdutoQueryResponse>
    {
        private readonly ILiquidRepository<ProdutoEntity, long> _repository;

        public ListProdutoQueryHandler(ILiquidRepository<ProdutoEntity, long> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ListProdutoQueryResponse> Handle(ListProdutoQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindAllAsync();

            return new ListProdutoQueryResponse(data);
        }
    }
}
