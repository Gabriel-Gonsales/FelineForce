using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Services.Interfaces
{
    public interface IClienteService
    {
        public Task<IEnumerable<Cliente>> BuscarClienteCPF(string pesquisa);
        public Task CriarCliente(string nome, string email, string telefone, string endereco);
        public Task ExcluirCliente(Guid id);
        public Task AtualizarCliente(Cliente usuario);
        public Task<Cliente> ObterClientePorId(Guid id);
        public Task<IEnumerable<Cliente>> ObterTodosClientes();
        Task<IEnumerable<Cliente>> BuscarClientesAsync(string pesquisa);
    }
}
