using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FelineForce.Models.Atendimento;

namespace FelineForce.Services.Interfaces
{
    public interface IAgendamentoService
    {
        public Task<Gato> BuscarGatoPorNomeECPF(string nomeGato, string cpfTutor);
        public Task CriarAtendimento(TipoAtendimento Tipo, DateTime data, string? descricao, Gato gato);
        public Task ExcluirAtendimento(Guid id);
        public Task AtualizarAtendimento(Atendimento atendimento);
        public Task<Atendimento> ObterAtendimentoPorId(Guid id);
        public Task<IEnumerable<Atendimento>> ObterTodosAtendimentos();
        Task<IEnumerable<Atendimento>> BuscarAtendimentosAsync(int pesquisa);
    }
}
