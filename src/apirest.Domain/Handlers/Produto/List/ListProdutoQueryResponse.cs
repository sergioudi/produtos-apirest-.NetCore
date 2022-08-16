using apirest.Domain.Entities;
using System.Collections.Generic;

namespace apirest.Domain.Handlers.Produto.List
{
    public class ListProdutoQueryResponse
    {
        public IEnumerable<ProdutoEntity> Data { get; set; }

        public ListProdutoQueryResponse(IEnumerable<ProdutoEntity> data)
        {
            Data = data;
        }
    }
}
