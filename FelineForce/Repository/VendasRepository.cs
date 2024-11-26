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
    public class VendasRepository : GenericRepository<Venda>, IVendasRepository
    {
        private readonly FelineForceContext _context;
        public VendasRepository(FelineForceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Venda>> BuscaTodasVendas()
        {
            return _context.Vendas.Include(v => v.Itens).Where(v => !v.Excluido);
        }

    }
}
