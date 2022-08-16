using apirest.Domain.Entities;

namespace apirest.Domain.Handlers.Produto.Update
{
    public class UpdateProdutoCommandResponse
    {
        public ProdutoEntity Data { get; set; }

        public UpdateProdutoCommandResponse(ProdutoEntity data)
        {
            Data = data;
        }
    }
}
