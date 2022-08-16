using Liquid.Repository;
using MediatR;
using apirest.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace apirest.Domain.Handlers.Produto.Update
{
    public class UpdateProdutoCommandHandler : IRequestHandler<UpdateProdutoCommand, UpdateProdutoCommandResponse>
    {
        private readonly ILiquidRepository<ProdutoEntity, Int64> _repository;

        public UpdateProdutoCommandHandler(ILiquidRepository<ProdutoEntity, Int64> repository)
        {
            _repository = repository;
        }


        public async Task<UpdateProdutoCommandResponse> Handle(UpdateProdutoCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Body.Id);

            if (data != null)
            {
                await _repository.UpdateAsync(request.Body);
            }

            return new UpdateProdutoCommandResponse(request.Body);
        }
    }
}
