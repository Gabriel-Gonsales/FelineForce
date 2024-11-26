using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Repository.Interfaces
{
    public interface IGatoRepository : IGenericRepository<Gato>
    {
        Task<IEnumerable<Gato>> BuscarGatosPorCpfClienteAsync(string cpf);
        Task<IEnumerable<Gato>> BuscarGatosComDadosDoTutorAsync();
    }
}
