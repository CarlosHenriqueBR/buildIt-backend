using System;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Map
{
    public class NotasMap : IEntityTypeConfiguration<Notas>
    {
        public void Configure(EntityTypeBuilder<Notas> builder)
        {
            builder.ToTable("Notas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ValorNota);
            builder.Property(x => x.Disponivel);

            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.DataCadastro).IsRequired();

            builder.HasData(
                new Notas {Id = 1, ValorNota = 5, Disponivel = true, DataCadastro = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), Ativo = true},
                new Notas {Id = 2, ValorNota = 10, Disponivel = true, DataCadastro = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), Ativo = true},
                new Notas {Id = 3, ValorNota = 20, Disponivel = true, DataCadastro = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), Ativo = true},
                new Notas {Id = 4, ValorNota = 50, Disponivel = true, DataCadastro = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), Ativo = true},
                new Notas {Id = 5, ValorNota = 100, Disponivel = true, DataCadastro = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), Ativo = true}
            );
        }
    }
}