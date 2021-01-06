using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repository
{
    /// <summary>
    /// Implementação do Entity Framework Core 5.0
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        private readonly EFContext _context;

        public RepositoryBase(EFContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.FindAsync<T>(id);
        }

        public async Task<T> GetById(string id)
        {
            return await _context.FindAsync<T>(id);
        }

        public async Task<T> GetById(Guid id)
        {
            return await _context.FindAsync<T>(id);
        }

        public async Task<T> Add(T model)
        {
             await _context.Set<T>().AddAsync(model);
             await _context.SaveChangesAsync();
             return model;
        }

        public async Task<T> Update(T model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<T> Delete(T model)
        {
            _context.Set<T>().Remove(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}