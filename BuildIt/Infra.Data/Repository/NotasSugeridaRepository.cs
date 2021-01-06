using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidades;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository
{
    public class NotasSugeridaRepository : RepositoryBase<NotasSugerida>, INotasSugeridaRepository
    {
        public NotasSugeridaRepository(EFContext context) : base(context)
        {
            
        }
    }
}