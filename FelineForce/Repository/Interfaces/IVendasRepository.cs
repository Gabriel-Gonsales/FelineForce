using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Repository.Interfaces
{
    public interface IVendasRepository : IGenericRepository<Venda>
    {
        public Task<IEnumerable<Venda>> BuscaTodasVendas();
    }
}
