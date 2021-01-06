using System.Linq;
using System.Threading.Tasks;
using Domain.Entidades;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repository
{
    public class CaixaEletronicaRepository : RepositoryBase<CaixaEletronica>, ICaixaEletronicaRepository
    {
        public CaixaEletronicaRepository(EFContext context) : base(context)
        {
       
        }
    }
}