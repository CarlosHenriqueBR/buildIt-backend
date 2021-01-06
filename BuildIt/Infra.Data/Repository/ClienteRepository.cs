using Domain.Entidades;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(EFContext context) : base(context)
        {
        }
    }
}