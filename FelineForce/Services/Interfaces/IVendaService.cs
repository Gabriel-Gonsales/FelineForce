using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FelineForce.Models.Atendimento;

namespace FelineForce.Services.Interfaces
{
    public interface IVendaService
    {
        public Task CriarVenda(Venda venda);
        public Task ExcluirVenda(Guid id);
        public Task AtualizarVenda(Venda atendimento);
        public Task<Venda> ObterVendaPorId(Guid id);
        public Task<IEnumerable<Venda>> ObterTodosVendas();
        Task<IEnumerable<Venda>> BuscarVendasAsync(string pesquisa);
    }
}
