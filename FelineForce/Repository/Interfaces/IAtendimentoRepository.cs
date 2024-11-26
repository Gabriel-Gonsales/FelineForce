using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Repository.Interfaces
{
    public interface IAtendimentoRepository : IGenericRepository<Atendimento>
    {
        Task<IEnumerable<Atendimento>> BuscarAtendimentosPorTipoAsync(int tipo);
    }
}
