using Liquid.Repository;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace apirest.Domain.Entities
{
    [Table("tb_produto")]
    public class ProdutoEntity : LiquidEntity<Int64>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string nome { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal quantidade { get; set; }
        [Column(TypeName = "numeric(19, 2)")]
        public decimal valor { get; set; }
    }
}
