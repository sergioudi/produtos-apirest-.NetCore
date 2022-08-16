using MediatR;

namespace apirest.Domain.Handlers.Produto.List
{
    public class ListProdutoQuery : IRequest<ListProdutoQueryResponse>
    {
        public ListProdutoQuery()
        {

        }
    }
}
