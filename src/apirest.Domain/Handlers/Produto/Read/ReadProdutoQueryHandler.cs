using Liquid.Repository;
using MediatR;
using apirest.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace apirest.Domain.Handlers.Produto.Read
{
    public class ReadProdutoQueryHandler : IRequestHandler<ReadProdutoQuery, ReadProdutoQueryResponse>
    {
        private readonly ILiquidRepository<ProdutoEntity, Int64> _repository;

        public ReadProdutoQueryHandler(ILiquidRepository<ProdutoEntity, Int64> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ReadProdutoQueryResponse> Handle(ReadProdutoQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            return new ReadProdutoQueryResponse(data);
        }
    }
}
