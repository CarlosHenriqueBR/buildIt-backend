using System;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Map
{
    public class TipoClienteMap : IEntityTypeConfiguration<TipoCliente>
    {
        public void Configure(EntityTypeBuilder<TipoCliente> builder)
        {
            builder.ToTable("TipoCliente");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Sigla);
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.DataCadastro).IsRequired();

            builder.HasData(
                new TipoCliente { Id = 1, Nome = "Pessoa Fisica", Sigla = "PF", Ativo = true, DataCadastro = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) },
                new TipoCliente { Id = 2, Nome = "Pessoa Juridica", Sigla = "PJ", Ativo = true, DataCadastro = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) });
        }
    }
}