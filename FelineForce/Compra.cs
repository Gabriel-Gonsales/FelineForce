using FelineForce.Models;
using FelineForce.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace ERP_com_relatorio
{
    public partial class frmCompra : Form
    {
        private readonly IEstoqueService _estoqueService; // Serviço para gerenciar produtos
        private Form _formAnterior;

        public frmCompra(Form formAnterior, IEstoqueService estoqueService)
        {
            InitializeComponent();
            _formAnterior = formAnterior;
            _estoqueService = estoqueService;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            // Qualquer lógica necessária ao carregar o formulário
        }

        private void frmCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formAnterior.Show(); // Retorna para o formulário anterior
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) ||
                    string.IsNullOrEmpty(txtQuantidade.Text))
                {
                    MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nome = txtID.Text;
                var quantidade = int.Parse(txtQuantidade.Text);
                var preco = float.Parse(textBox2.Text);
                var fornecedor = textBox1.Text;

                var produtoExistente = await _estoqueService.BuscarProdutosAsync(nome);

                if (produtoExistente != null && produtoExistente.Any())
                {
                    var produto = produtoExistente.First();
                    await _estoqueService.AtualizarProduto(produto, quantidade, preco, fornecedor);
                    MessageBox.Show("Produto atualizado e compra registrada no histórico!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _estoqueService.CriarProduto(nome, quantidade, 0);
                    MessageBox.Show("Produto cadastrado e compra registrada no histórico!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimparCampos()
        {
            txtID.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}