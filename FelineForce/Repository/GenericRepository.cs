using FelineForce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FelineForce.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly FelineForceContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(FelineForceContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.Where(e => EF.Property<bool>(e, "Excluido") == false).ToListAsync(); // Filtra registros não excluídos
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).Where(e => EF.Property<bool>(e, "Excluido") == false).ToListAsync(); // Filtra registros não excluídos
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                var property = _context.Entry(entity).Property("Excluido");
                if (property != null)
                {
                    property.CurrentValue = true; 
                    await UpdateAsync(entity);
                }
            }
        }
    }
}