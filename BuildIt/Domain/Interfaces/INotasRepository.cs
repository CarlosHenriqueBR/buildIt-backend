using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entidades;

namespace Domain.Interfaces
{
    public interface INotasRepository : IRepositoryBase<Notas>
    {
        Task<IEnumerable<Notas>> SugerirNotas();
        Task<IEnumerable<Notas>> VerificarNotasDisponiveis();
    }
}