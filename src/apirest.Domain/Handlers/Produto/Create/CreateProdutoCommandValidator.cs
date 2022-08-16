using FluentValidation;

namespace apirest.Domain.Handlers.Produto.Create
{
    public class CreateProdutoCommandValidator : AbstractValidator<CreateProdutoCommand>
    {
        public CreateProdutoCommandValidator()
        {

        }
    }
}
