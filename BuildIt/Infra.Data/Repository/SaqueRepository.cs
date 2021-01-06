using Domain.Entidades;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class SaqueRepository : RepositoryBase<Saque>, ISaqueRepository
    {
        public SaqueRepository(EFContext context) : base(context)
        {
        }
    }
}