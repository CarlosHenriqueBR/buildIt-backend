using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> GetById(string id);

        Task<T> GetById(Guid id);

        Task<T> Add(T model);

        Task<T> Update(T model);

        Task<T> Delete(T model);
    }
}