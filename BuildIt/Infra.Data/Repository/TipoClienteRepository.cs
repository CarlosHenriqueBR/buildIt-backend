using Domain.Entidades;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class TipoClienteRepository : RepositoryBase<TipoCliente>, ITipoClienteRepository
    {
        public TipoClienteRepository(EFContext context) : base(context)
        {
        }
    }
}