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
    public class GatoRepository : GenericRepository<Gato>, IGatoRepository
    {
        private readonly FelineForceContext _context;
        public GatoRepository(FelineForceContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Gato>> BuscarGatosPorCpfClienteAsync(string cpf)
        {
            return await _context.Gatos
                .Include(g => g.Tutor)
                .Where(g => g.Tutor.CPF == cpf && !g.Excluido) 
                .ToListAsync();
        }
        public async Task<IEnumerable<Gato>> BuscarGatosComDadosDoTutorAsync()
        {
            return await _context.Gatos
                .Include(g => g.Tutor) 
                .Where(g => !g.Excluido) 
                .ToListAsync();
        }

    }
}
