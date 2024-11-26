using FelineForce.Models;
using FelineForce.Repository.Interfaces;
using FelineForce.Services.Interfaces;
using System.Linq.Expressions;
using static FelineForce.Models.Atendimento;

namespace FelineForce.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IGenericRepository<Atendimento> _atendimentoRepository;
        private readonly IGatoRepository _gatoRepository;

        public AgendamentoService(IGenericRepository<Atendimento> atendimentoRepository, IGatoRepository gatoRepository)
        {
            _atendimentoRepository = atendimentoRepository;
            _gatoRepository = gatoRepository;
        }
        public async Task<Gato> BuscarGatoPorNomeECPF(string nomeGato, string cpfTutor)
        {
            if (string.IsNullOrWhiteSpace(nomeGato) || string.IsNullOrWhiteSpace(cpfTutor))
                throw new ArgumentException("Nome do gato e CPF do tutor são obrigatórios.");

            var gatos = await _gatoRepository.BuscarGatosPorCpfClienteAsync(cpfTutor);

            return gatos.FirstOrDefault(g => g.Nome.Contains(nomeGato)) ?? throw new Exception("Gato não encontrado para os critérios fornecidos.");
        }

        public async Task CriarAtendimento(TipoAtendimento Tipo, DateTime data, string? descricao, Gato gato)
        {
            var atendimento = new Atendimento
            {
                Tipo = Tipo,
                DataAtendimento = data,
                Descricao = descricao,
                Tutor = gato.Tutor,
                Gato = gato,
                Excluido = false
            };
            await _atendimentoRepository.AddAsync(atendimento);
            var a = await _atendimentoRepository.GetByIdAsync(atendimento.Id);
        }

        public async Task AtualizarAtendimento(Atendimento atendimento)
        {
            await _atendimentoRepository.UpdateAsync(atendimento);
        }
        public async Task ExcluirAtendimento(Guid id)
        {
            await _atendimentoRepository.DeleteAsync(id);
        }

        public async Task<Atendimento> ObterAtendimentoPorId(Guid id)
        {
            return await _atendimentoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Atendimento>> ObterTodosAtendimentos()
        {
            return await _atendimentoRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Atendimento>> BuscarAtendimentosAsync(int pesquisa)
        {
            if (pesquisa == null)
            {
                // Retorna todos os atendimentos caso a pesquisa esteja vazia
                return await _atendimentoRepository.GetAllAsync();
            }

            // Cria a expressão de pesquisa
            Expression<Func<Atendimento, bool>> predicate = atendimento =>
                (int)atendimento.Tipo == pesquisa;
            // Retorna os atendimentos filtrados conforme a expressão
            return await _atendimentoRepository.GetAllAsync(predicate);
        }
    }
}