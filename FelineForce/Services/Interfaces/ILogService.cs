using FelineForce.Models;
using FelineForce.Repository;
using FelineForce.Repository.Interfaces;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Services
{
    public interface ILogService
    {
        public Task CriarLog(string nome, string senha, Usuario.TipoUsuario tipo);
        public Task<IEnumerable<LogSistema>> BuscarTodosLogs();
    }
}
