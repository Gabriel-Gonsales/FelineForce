using FelineForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelineForce.Services.Interfaces
{
    public interface IEstoqueService
    {
        public Task<IEnumerable<ItemCompra>> ConsultarCompras();
        public Task CriarProduto(string nome, int quantidade, float preco);
        public Task ExcluirProduto(Guid id);
        public Task AtualizarProduto(Produto usuario, int quantidadeAdicional, float preco, string fornecedor);
        public Task<Produto> ObterProdutoPorId(Guid id);
        public Task<IEnumerable<Produto>> ObterTodosProdutos();
        Task<IEnumerable<Produto>> BuscarProdutosAsync(string pesquisa);
    }
}
