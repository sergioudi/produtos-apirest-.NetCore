using apirest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apirest.Repository.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<ProdutoEntity>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
        {
            builder.Property(b => b.Id).HasColumnName("id");

            builder.Property(o => o.Id).UseIdentityAlwaysColumn();

            builder.HasKey(o => o.Id);

        }
    }
}
