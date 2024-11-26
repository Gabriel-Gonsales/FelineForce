using FelineForce.Models;
using FelineForce.Repository.Interfaces;
using FelineForce.Services.Interfaces;
using System.Linq.Expressions;

namespace FelineForce.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendasRepository _vendaRepository;
        private readonly IEstoqueService _estoqueService;

        public VendaService(IVendasRepository vendaRepository, IEstoqueService estoqueService)
        {
            _vendaRepository = vendaRepository;
            _estoqueService = estoqueService;
        }

        public async Task CriarVenda(Venda venda)
        {
            // Processar a venda e ajustar o estoque
            foreach (var item in venda.Itens)
            {
                // Busca o produto correspondente no banco
                var produto = await _estoqueService.ObterProdutoPorId(item.ItemProdId);

                if (produto == null)
                {
                    throw new Exception($"Produto com ID {item.Id} não encontrado.");
                }

                // Verifica se há estoque suficiente
                if (produto.Quantidade < item.Quantidade)
                {
                    throw new Exception($"Estoque insuficiente para o produto {produto.Nome}. Estoque disponível: {produto.Quantidade}");
                }

                // Diminui o estoque
                produto.Quantidade -= item.Quantidade;

                // Atualiza o produto no banco
                await _estoqueService.AtualizarProduto(produto, 0, 0, null);
            }

            // Adiciona a venda no banco
            await _vendaRepository.AddAsync(venda);
        }

        public async Task AtualizarVenda(Venda usuario)
        {
            await _vendaRepository.UpdateAsync(usuario);
        }
        public async Task ExcluirVenda(Guid id)
        {
            await _vendaRepository.DeleteAsync(id);
        }

        public async Task<Venda> ObterVendaPorId(Guid id)
        {
            return await _vendaRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Venda>> ObterTodosVendas()
        {
            return await _vendaRepository.BuscaTodasVendas();
        }
        public async Task<IEnumerable<Venda>> BuscarVendasAsync(string pesquisa)
        {
            if (string.IsNullOrEmpty(pesquisa))
            {
                // Retorna todos os vendas caso a pesquisa esteja vazia
                return await _vendaRepository.GetAllAsync();
            }

            // Cria a expressão de pesquisa
            Expression<Func<Venda, bool>> predicate = venda =>
                venda.Inclusao.ToString().Contains(pesquisa);

            // Retorna os vendas filtrados conforme a expressão
            return await _vendaRepository.GetAllAsync(predicate);
        }
    }
}