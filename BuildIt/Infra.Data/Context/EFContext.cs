using System.Linq;
using Domain.Entidades;
using Infra.Data.Extensao;
using Infra.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public sealed class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<CaixaEletronica> CaixaEletronica { get; set; }
        public DbSet<Saque> Saque { get; set; }
        public DbSet<TipoCliente> TipoCliente { get; set; }
        public DbSet<NotasSugerida> NotasSugerida { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("dbo");

            builder.RemoveCascadeDeleteConvention();

            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new CaixaEletronicaMap());
            builder.ApplyConfiguration(new NotasMap());
            builder.ApplyConfiguration(new SaqueMap());
            builder.ApplyConfiguration(new TipoClienteMap());
            builder.ApplyConfiguration(new NotasSugeridaMap());
        }
    }
}