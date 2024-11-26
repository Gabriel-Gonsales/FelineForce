using FelineForce.Models;
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

        private async Task LogAsync(LogSistema.TipoLog tipo, string mensagem)
        {
            if (Sessao.UsuarioLogado == null)
                return;

            var log = new LogSistema
            {
                Tipo = tipo,
                Mensagem = mensagem,
                Inclusao = DateTime.Now,
                Usuario = Sessao.UsuarioLogado
            };

            await _context.Logs.AddAsync(log);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> query = _dbSet.Where(e => EF.Property<bool>(e, "Excluido") == false);

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).Where(e => EF.Property<bool>(e, "Excluido") == false).ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                await LogAsync(LogSistema.TipoLog.Cadastro, $"Registro adicionado na entidade {typeof(T).Name}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                await LogAsync(LogSistema.TipoLog.Alteracao, $"Registro atualizado na entidade {typeof(T).Name}");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
                    await LogAsync(LogSistema.TipoLog.Exclusao, $"Registro marcado como excluído na entidade {typeof(T).Name}");
                }
            }
        }
    }
}
