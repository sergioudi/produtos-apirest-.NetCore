using apirest.Domain.Entities;

namespace apirest.Domain.Handlers.Produto.Read
{
    public class ReadProdutoQueryResponse
    {
        public ProdutoEntity Data { get; set; }

        public ReadProdutoQueryResponse(ProdutoEntity data)
        {
            Data = data;
        }
    }
}
