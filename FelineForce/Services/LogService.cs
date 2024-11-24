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
    public class LogService
    {
        public readonly IGenericRepository<LogSistema> _logRepository;
        public LogService(IGenericRepository<LogSistema> logRepository)
        {
            _logRepository = logRepository;
        }

        public async Task CriarLog(string nome, string senha, Usuario.TipoUsuario tipo)
        {
            var usuario = new LogSistema
            {
            };

            await _logRepository.AddAsync(usuario);
        }
    }
}
