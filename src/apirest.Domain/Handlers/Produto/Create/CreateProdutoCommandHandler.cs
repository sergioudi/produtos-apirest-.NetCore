using Liquid.Repository;
using MediatR;
using apirest.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace apirest.Domain.Handlers.Produto.Create
{
    public class CreateProdutoCommandHandler : IRequestHandler<CreateProdutoCommand>
    {
        private readonly ILiquidRepository<ProdutoEntity, long> _repository;

        public CreateProdutoCommandHandler(ILiquidRepository<ProdutoEntity, long> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<Unit> Handle(CreateProdutoCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(request.Body);

            return new Unit();
        }
    }
}
