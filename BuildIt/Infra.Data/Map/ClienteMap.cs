using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Map
{
    public class ClienteMap :IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Telefone);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.CpfCnpj).IsRequired();
            builder.Property(x => x.TipoClienteId).IsRequired();
        }
    }
}