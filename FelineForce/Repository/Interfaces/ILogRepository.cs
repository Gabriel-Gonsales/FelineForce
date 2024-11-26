using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Repository.Interfaces
{
    public interface ILogRepository : IGenericRepository<LogSistema>
    {
        public Task<IEnumerable<LogSistema>> ObterTodosLogs();
    }
}
