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
    public class AtendimentoRepository : GenericRepository<Atendimento>, IAtendimentoRepository
    {
        private readonly FelineForceContext _context;
        public AtendimentoRepository(FelineForceContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Atendimento>> BuscarAtendimentosPorTipoAsync(int tipo)
        {
            if (tipo != null) return _context.Atendimentos.Include(a => a.Gato).Where(a => !a.Excluido && (int)a.Tipo == tipo);
            else return _context.Atendimentos.Include(a => a.Gato);
        }

    }
}
