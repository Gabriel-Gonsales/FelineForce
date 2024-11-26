using FelineForce.Models;
using FelineForce.Repository.Interfaces;
using FelineForce.Services.Interfaces;
using System.Linq.Expressions;

namespace FelineForce.Services
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IGenericRepository<Produto> _produtoRepository;
        private readonly IGenericRepository<ItemCompra> _itemCompraRepository;

        public EstoqueService(IGenericRepository<Produto> produtoRepository, IGenericRepository<ItemCompra> itemCompraRepository)
        {
            _produtoRepository = produtoRepository;
            _itemCompraRepository = itemCompraRepository;
        }

        public async Task CriarProduto(string nome, int quantidade, float preco)
        {
            // Criação do produto
            var produto = new Produto
            {
                Nome = nome,
                Quantidade = quantidade,
                Preco = preco,
                Excluido = false
            };

            await _produtoRepository.AddAsync(produto);

            // Registro no histórico de compras
            var itemCompra = new ItemCompra
            {
                Nome = nome,
                Quantidade = quantidade,
                Excluido = false
            };
            await _itemCompraRepository.AddAsync(itemCompra);
        }
        public async Task<IEnumerable<ItemCompra>> ConsultarCompras()
        {
            return await _itemCompraRepository.GetAllAsync();
        }
        public async Task AtualizarProduto(Produto produto, int quantidadeAdicional, float preco = 0, string fornecedor = "")
        {
            // Atualiza a quantidade do produto
            produto.Quantidade += quantidadeAdicional;
            await _produtoRepository.UpdateAsync(produto);

            // Registro no histórico de compras
            var itemCompra = new ItemCompra
            {
                Nome = produto.Nome,
                Quantidade = quantidadeAdicional,
                Preco = preco,
                Fornecedor = fornecedor,
                Excluido = false
            };
            await _itemCompraRepository.AddAsync(itemCompra);
        }

        public async Task ExcluirProduto(Guid id)
        {
            await _produtoRepository.DeleteAsync(id);
        }

        public async Task<Produto> ObterProdutoPorId(Guid id)
        {
            return await _produtoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Produto>> ObterTodosProdutos()
        {
            return await _produtoRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Produto>> BuscarProdutosAsync(string pesquisa)
        {
            if (string.IsNullOrEmpty(pesquisa))
            {
                return await _produtoRepository.GetAllAsync();
            }

            Expression<Func<Produto, bool>> predicate = produto =>
                produto.Nome.Contains(pesquisa);

            return await _produtoRepository.GetAllAsync(predicate);
        }
    }
}