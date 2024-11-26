using FelineForce.Models;
using FelineForce.Repository.Interfaces;
using FelineForce.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FelineForce.Services
{
    public class GatoService : IGatoService
    {
        private readonly IGatoRepository _gatoRepository;
        private readonly IGenericRepository<Cliente> _clienteRepository;

        public GatoService(IGatoRepository gatoRepository, IGenericRepository<Cliente> clienteRepository)
        {
            _gatoRepository = gatoRepository;
            _clienteRepository = clienteRepository;
        }
        public async Task<IEnumerable<Gato>> BuscarGatosPorCpfClienteAsync(string cpf)
        {
            return await _gatoRepository.BuscarGatosPorCpfClienteAsync(cpf);
        }
        public async Task<IEnumerable<Cliente>> BuscarClienteCPF(string pesquisa)
        {
            if (string.IsNullOrEmpty(pesquisa))
            {
                // Retorna todos os clientes caso a pesquisa esteja vazia
                return await _clienteRepository.GetAllAsync();
            }
            pesquisa = pesquisa.Trim();
            // Cria a expressão de pesquisa
            Expression<Func<Cliente, bool>> predicate = cliente =>
                cliente.CPF == pesquisa;

            // Retorna os clientes filtrados conforme a expressão
            return await _clienteRepository.GetAllAsync(predicate);
        }
        public async Task<IEnumerable<Gato>> BuscarGatosComDadosDoTutorAsync()
        {
            return await _gatoRepository.BuscarGatosComDadosDoTutorAsync();
        }
        public async Task CriarGato(string nome, string cor, string cpf, Cliente tutor)
        {
            var gato = new Gato
            {
                Nome = nome,
                Cor = cor,
                TutorId = tutor.Id,
                Tutor = tutor,
                Excluido = false
            };
            await _gatoRepository.AddAsync(gato);
            var a = await _gatoRepository.GetByIdAsync(gato.Id);
        }

        public async Task AtualizarGato(Gato gato)
        {
            await _gatoRepository.UpdateAsync(gato);
        }
        public async Task ExcluirGato(Guid id)
        {
            await _gatoRepository.DeleteAsync(id);
        }

        public async Task<Gato> ObterGatoPorId(Guid id)
        {
            return await _gatoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Gato>> ObterTodosGatos()
        {
            return await _gatoRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Gato>> BuscarGatosAsync(string pesquisa)
        {
            if (string.IsNullOrEmpty(pesquisa))
            {
                // Retorna todos os gatos caso a pesquisa esteja vazia
                return await _gatoRepository.GetAllAsync();
            }

            // Cria a expressão de pesquisa
            Expression<Func<Gato, bool>> predicate = gato =>
                gato.Nome.Contains(pesquisa) || gato.Tutor.CPF.Contains(pesquisa) || gato.Tutor.Nome.Contains(pesquisa);

            // Retorna os gatos filtrados conforme a expressão
            return await _gatoRepository.GetAllAsync(predicate);
        }
    }
}