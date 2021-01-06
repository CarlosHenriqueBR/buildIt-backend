using System;
using Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Map
{
    public class NotasSugeridaMap : IEntityTypeConfiguration<NotasSugerida>
    {
        public void Configure(EntityTypeBuilder<NotasSugerida> builder)
        {
            builder.ToTable("NotasSugerida");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ValorNotaSugerida);
            builder.Property(x => x.NotasId);
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.DataCadastro).IsRequired();

            builder.HasData(
                new NotasSugerida(1,true, DateTime.Now, 5, 1),
                new NotasSugerida(2,true, DateTime.Now, 5, 2),
                new NotasSugerida(3,true, DateTime.Now, 10, 2),
                new NotasSugerida(4, true, DateTime.Now, 5, 3),
                new NotasSugerida(5, true, DateTime.Now, 10, 3),
                new NotasSugerida(6, true, DateTime.Now, 20, 3),
                new NotasSugerida(7, true, DateTime.Now, 5, 4),
                new NotasSugerida(8, true, DateTime.Now, 10, 4),
                new NotasSugerida(9, true, DateTime.Now, 20, 4),
                new NotasSugerida(10, true, DateTime.Now, 50, 4),
                new NotasSugerida(11, true, DateTime.Now, 5, 5),
                new NotasSugerida(12, true, DateTime.Now, 10, 5),
                new NotasSugerida(13, true, DateTime.Now, 20, 5),
                new NotasSugerida(14, true, DateTime.Now, 50, 5),
                new NotasSugerida(15, true, DateTime.Now, 100, 5)
            );
        }
    }
}

