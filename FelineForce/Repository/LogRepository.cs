using FelineForce.Models;
using FelineForce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Repository
{
    public class LogRepository : GenericRepository<LogSistema>, ILogRepository
    {
        private readonly FelineForceContext _context;
        public LogRepository(FelineForceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LogSistema>> ObterTodosLogs()
        {
            return _context.Logs.Include(v => v.Usuario).Where(v => !v.Excluido);
        }

    }
}
