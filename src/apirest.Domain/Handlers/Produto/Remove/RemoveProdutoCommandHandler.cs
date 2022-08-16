using Liquid.Repository;
using MediatR;
using apirest.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace apirest.Domain.Handlers.Produto.Remove
{
    public class RemoveProdutoCommandHandler : IRequestHandler<RemoveProdutoCommand, RemoveProdutoCommandResponse>
    {
        private readonly ILiquidRepository<ProdutoEntity, Int64> _repository;

        public RemoveProdutoCommandHandler(ILiquidRepository<ProdutoEntity, Int64> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<RemoveProdutoCommandResponse> Handle(RemoveProdutoCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            if (data != null)
            {
                await _repository.RemoveByIdAsync(request.Id);
                //await _mediator.Publish(new GenericEntityRemovedNotification<TEntity, TIdentifier>(entity));
            }

            return new RemoveProdutoCommandResponse(data);
        }
    }
}
