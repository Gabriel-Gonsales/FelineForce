using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Services.Interfaces
{
    public interface IGatoService
    {
        public Task<IEnumerable<Cliente>> BuscarClienteCPF(string pesquisa);
        public Task<IEnumerable<Gato>> BuscarGatosPorCpfClienteAsync(string cpf);
        public Task<IEnumerable<Gato>> BuscarGatosComDadosDoTutorAsync();
        public Task CriarGato(string nome, string cor, string cpf, Cliente clienteId);
        public Task ExcluirGato(Guid id);
        public Task AtualizarGato(Gato usuario);
        public Task<Gato> ObterGatoPorId(Guid id);
        public Task<IEnumerable<Gato>> ObterTodosGatos();
        Task<IEnumerable<Gato>> BuscarGatosAsync(string pesquisa);
    }
}
