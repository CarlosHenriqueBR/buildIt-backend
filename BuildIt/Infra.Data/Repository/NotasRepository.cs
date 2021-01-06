using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidades;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository
{
    public class NotasRepository : RepositoryBase<Notas>, INotasRepository
    {
        private readonly EFContext _context;
        public NotasRepository(EFContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Notas>> SugerirNotas()
        {
            return await _context.Notas
                .Where(x => x.Ativo && x.Disponivel)
                .Include(x => x.NotasSugeridas).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Notas>> VerificarNotasDisponiveis()
        {
            return await _context.Notas.Where(x => x.Ativo && x.Disponivel).AsNoTracking().ToListAsync();
        }
    }
}