using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Map
{
    public class SaqueMap :IEntityTypeConfiguration<Saque>
    {
        public void Configure(EntityTypeBuilder<Saque> builder)
        {
            builder.ToTable("Saque");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CodigoSaque).IsRequired();
            builder.Property(x => x.DataSaque).IsRequired().HasColumnType("Datetime");
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("Datetime");
        }
    }
}