using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Map
{
    public class CaixaEletronicaMap : IEntityTypeConfiguration<CaixaEletronica>
    {
        public void Configure(EntityTypeBuilder<CaixaEletronica> builder)
        {
            builder.ToTable("CaixaEletronica");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NotasId);
            builder.Property(x => x.ClienteId);
            builder.Property(x => x.QuantidadeNotas);
            builder.Property(x => x.Valor);

            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.DataCadastro).HasColumnType("Datetime");
        }
    }
}