using FelineForce.Models;
using FelineForce.Repository.Interfaces;
using FelineForce.Services.Interfaces;
using System.Linq.Expressions;

namespace FelineForce.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;

        public ClienteService(IGenericRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task CriarCliente(string nome, string email, string telefone, string endereco)
        {
            var cliente = new Cliente
            {
                Nome = nome,
                Email = email,
                Telefone = telefone,
                Endereco = endereco,
                Excluido = false
            };
            await _clienteRepository.AddAsync(cliente);
            var a = await _clienteRepository.GetByIdAsync(cliente.Id);
        }

        public async Task AtualizarCliente(Cliente cliente)
        {
            await _clienteRepository.UpdateAsync(cliente);
        }
        public async Task ExcluirCliente(Guid id)
        {
            await _clienteRepository.DeleteAsync(id);
        }

        public async Task<Cliente> ObterClientePorId(Guid id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Cliente>> ObterTodosClientes()
        {
            return await _clienteRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Cliente>> BuscarClientesAsync(string pesquisa)
        {
            if (string.IsNullOrEmpty(pesquisa))
            {
                // Retorna todos os clientes caso a pesquisa esteja vazia
                return await _clienteRepository.GetAllAsync();
            }

            // Cria a expressão de pesquisa
            Expression<Func<Cliente, bool>> predicate = cliente =>
                cliente.Nome.Contains(pesquisa) ||
                cliente.Email.Contains(pesquisa) ||
                cliente.Endereco.Contains(pesquisa) ||
                cliente.Telefone.Contains(pesquisa);

            // Retorna os clientes filtrados conforme a expressão
            return await _clienteRepository.GetAllAsync(predicate);
        }
        public async Task<IEnumerable<Cliente>> BuscarClienteCPF(string pesquisa)
        {
            if (string.IsNullOrEmpty(pesquisa))
            {
                // Retorna todos os clientes caso a pesquisa esteja vazia
                return await _clienteRepository.GetAllAsync();
            }

            // Cria a expressão de pesquisa
            Expression<Func<Cliente, bool>> predicate = cliente =>
                cliente.CPF.Contains(pesquisa);

            // Retorna os clientes filtrados conforme a expressão
            return await _clienteRepository.GetAllAsync(predicate);
        }
    }
}