using FluentValidation;

namespace apirest.Domain.Handlers.Produto.Update
{
    public class UpdateProdutoCommandValidator : AbstractValidator<UpdateProdutoCommand>
    {
        public UpdateProdutoCommandValidator()
        {
            RuleFor(request => request.Body.Id).NotEmpty().NotNull();
        }
    }
}
