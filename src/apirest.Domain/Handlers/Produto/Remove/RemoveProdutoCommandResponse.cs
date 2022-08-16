using apirest.Domain.Entities;

namespace apirest.Domain.Handlers.Produto.Remove
{
    public class RemoveProdutoCommandResponse
    {
        public ProdutoEntity Data { get; set; }

        public RemoveProdutoCommandResponse(ProdutoEntity data)
        {
            Data = data;
        }
    }
}
