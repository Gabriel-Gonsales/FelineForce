using FelineForce.Migrations;
using FelineForce.Services;
using FelineForce.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_com_relatorio
{
    public partial class frmEstoque : Form
    {
        private readonly IEstoqueService _estoqueService;
        private Form form;
        public frmEstoque(Form Form, IEstoqueService estoqueService)
        {
            InitializeComponent();
            form = Form;
            _estoqueService = estoqueService;
        }

        private async void frmEstoque_Load(object sender, EventArgs e)
        {
            grdClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var produtos = await _estoqueService.BuscarProdutosAsync(txtPesquisa.Text);
            // Limpa as colunas existentes
            grdClientes.Columns.Clear();

            grdClientes.Columns.Add("Id", "Id");
            grdClientes.Columns.Add("Nome", "Nome");
            grdClientes.Columns.Add("Preco", "Preco");
            grdClientes.Columns.Add("Quantidade", "Quantidade");

            // Preenche o DataGridView com os dados de produtos
            foreach (var produto in produtos)
            {
                grdClientes.Rows.Add(produto.Id,produto.Nome, produto.Preco, produto.Quantidade);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async void OnChildFormClosed()
        {
            try
            {
                var produtos = await _estoqueService.BuscarProdutosAsync(txtPesquisa.Text);

                // Atualiza a exibição do DataGridView
                grdClientes.Rows.Clear(); // Limpa os dados existentes

                // Preenche o DataGridView com os dados de produtos
                foreach (var produto in produtos)
                {
                    grdClientes.Rows.Add(produto.Id, produto.Nome, produto.Preco, produto.Quantidade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroEstoque frmCadastroEstoque = new CadastroEstoque(this, _estoqueService);
            frmCadastroEstoque.Show();
            this.Hide();
        }

        private async void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            grdClientes.DataSource = null;
            var produtos = await _estoqueService.BuscarProdutosAsync(txtPesquisa.Text);
            // Limpa as colunas existentes
            grdClientes.Columns.Clear();
            grdClientes.Columns.Add("Id", "Id");
            grdClientes.Columns.Add("Nome", "Nome");
            grdClientes.Columns.Add("Preco", "Preco");
            grdClientes.Columns.Add("Quantidade", "Quantidade");

            // Preenche o DataGridView com os dados de produtos
            foreach (var produto in produtos)
            {
                grdClientes.Rows.Add(produto.Nome, produto.Preco, produto.Quantidade);
            }
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnProcurar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.Trim();

            // Chama o método do service para buscar produtos
            var produtos = await _estoqueService.BuscarProdutosAsync(pesquisa);

            // Atualiza o DataGridView com os resultados
            grdClientes.DataSource = produtos.ToList();
        }
        private async Task AtualizarTabelaProdutos()
        {
            var produtos = await _estoqueService.BuscarProdutosAsync(txtPesquisa.Text);

            // Limpa as colunas existentes
            grdClientes.DataSource = null;
            grdClientes.Rows.Clear();
            grdClientes.Columns.Clear();

            grdClientes.Columns.Add("Id", "Id");
            grdClientes.Columns.Add("Nome", "Nome");
            grdClientes.Columns.Add("Preco", "Preco");
            grdClientes.Columns.Add("Quantidade", "Quantidade");

            // Preenche o DataGridView com os dados de clientes
            foreach (var produto in produtos)
            {
                grdClientes.Rows.Add(produto.Id, produto.Nome, produto.Preco, produto.Quantidade);
            }
        }

        private async void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verifica se há uma linha selecionada
                if (grdClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um produto para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtém a linha selecionada
                var selectedRow = grdClientes.SelectedRows[0];

                // Obtém o ID do cliente da célula correspondente
                var produtoId = selectedRow.Cells["Id"]; // Substitua "Id" pelo nome da coluna correspondente ao GUID no DataGridView
                if (produtoId == null || produtoId.Value == null)
                {
                    MessageBox.Show("Não foi possível identificar o produto selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Converte o valor da célula para Guid
                if (!Guid.TryParse(produtoId.Value.ToString(), out Guid clienteId))
                {
                    MessageBox.Show("ID do produto inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chama o serviço para excluir o produto
                await _estoqueService.ExcluirProduto(clienteId);

                // Exibe mensagem de sucesso
                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza os dados no DataGridView
                await AtualizarTabelaProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
