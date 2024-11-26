using FelineForce.Migrations;
using FelineForce.Models;
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
    public partial class frmVenda : Form
    {
        private Form form;
        private readonly IVendaService _vendaService;
        private readonly IEstoqueService _estoqueService;
        private bool isUpdatingCells = false;
        decimal totalExportar = 0;
        public frmVenda(Form Form, IVendaService vendaService, IEstoqueService estoqueService)
        {
            InitializeComponent();
            form = Form;
            _vendaService = vendaService;
            _estoqueService = estoqueService;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            grdAgendamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdAgendamentos.Columns.Clear();
            grdAgendamentos.Columns.Add("Id", "Id");
            grdAgendamentos.Columns.Add("Item", "Item");
            grdAgendamentos.Columns.Add("Quantidade", "Quantidade");
            grdAgendamentos.Columns.Add("Preço/Unidade", "Preço/Unidade");
            grdAgendamentos.Columns.Add("Total", "Total");
            foreach (DataGridViewRow row in grdAgendamentos.Rows)
            {
                row.Cells["Item"].Value = "";
                row.Cells["Quantidade"].Value = 0; // Define o valor padrão
            }
        }

        private void frmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            try
            {
                // Prepara os itens da venda
                var itensVenda = new List<ItemVenda>();
                foreach (DataGridViewRow row in grdAgendamentos.Rows)
                {
                    if (row.Cells["Item"].Value != null && row.Cells["Quantidade"].Value != null)
                    {
                        var quantidadeObj = row.Cells["Quantidade"].Value;
                        var nomeProduto = row.Cells["Item"].Value.ToString();
                        var totalItem = row.Cells["Total"].Value;
                        var Id = row.Cells["Id"].Value.ToString();

                        var totalObj = row.Cells["Total"].Value;

                        // Remove "R$" e outros caracteres não numéricos antes da conversão
                        string totalString = totalObj?.ToString().Replace("R$", "").Trim();

                        if (int.TryParse(quantidadeObj.ToString(), out int quantidade) && decimal.TryParse(totalString.ToString(), out decimal totalI) && quantidade > 0 && Guid.TryParse(Id, out Guid prodId))
                        {
                            itensVenda.Add(new ItemVenda
                            {
                                Quantidade = quantidade,
                                Nome = nomeProduto,
                                Total = totalI,
                                ItemProdId = prodId,
                            });
                        }
                    }
                }

                if (!itensVenda.Any())
                {
                    MessageBox.Show("Nenhum item válido foi encontrado na venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcula o total
                decimal total = itensVenda.Sum(item => item.Total); // Ajuste para acessar o preço do item

                // Cria a venda
                var venda = new Venda
                {
                    TotalCompra = totalExportar,
                    CPFCliente = txtCPF.Text,
                    Itens = itensVenda
                };

                // Abre o formulário de pagamento passando os dados da venda
                frmPagamento frmPagamento = new frmPagamento(this, venda, _vendaService);
                frmPagamento.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar a venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontos_TextChanged(object sender, EventArgs e)
        {
            AtualizarTxtTotalFinal();
        }

        private void txtTotalFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdAgendamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void grdAgendamentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isUpdatingCells) return; // Evita reentrância

            try
            {
                isUpdatingCells = true; // Marca que estamos atualizando células programaticamente

                var itemColumnItem = grdAgendamentos.Columns["Item"];
                var itemColumnQuantidade = grdAgendamentos.Columns["Quantidade"];

                // Verifica se a célula modificada é relevante
                if (((itemColumnItem != null && e.ColumnIndex == itemColumnItem.Index) || itemColumnQuantidade != null) && e.RowIndex >= 0)
                {
                    if (itemColumnItem != null)
                    {
                        var itemName = grdAgendamentos.Rows[e.RowIndex].Cells["Item"].Value?.ToString();

                        if (!string.IsNullOrEmpty(itemName))
                        {
                            // Busca o produto pelo nome
                            var produtos = await _estoqueService.BuscarProdutosAsync(itemName);

                            if (produtos != null && produtos.Any())
                            {
                                var produto = produtos.First();

                                // Atualiza o preço/unidade
                                grdAgendamentos.Rows[e.RowIndex].Cells["Preço/Unidade"].Value = produto.Preco.ToString("C");
                                grdAgendamentos.Rows[e.RowIndex].Cells["Id"].Value = produto.Id.ToString();

                                // Define "Quantidade" como 0, se não tiver valor
                                grdAgendamentos.Rows[e.RowIndex].Cells["Quantidade"].Value ??= 0;

                                // Atualiza o total
                                AtualizarTotal(e.RowIndex);
                            }
                            else
                            {
                                // Produto não encontrado
                                grdAgendamentos.Rows[e.RowIndex].Cells["Preço/Unidade"].Value = null;
                                MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                if(itemColumnQuantidade != null && grdAgendamentos.Columns["Preço/Unidade"] != null)
                {
                    // Recalcula o total se as colunas "Quantidade" ou "Preço/Unidade" forem alteradas
                    if (e.ColumnIndex == grdAgendamentos.Columns["Quantidade"].Index ||
                        e.ColumnIndex == grdAgendamentos.Columns["Preço/Unidade"].Index)
                    {
                        AtualizarTotal(e.RowIndex);
                    }
                }
            }
            finally
            {
                isUpdatingCells = false; // Libera a flag para permitir futuras alterações
            }
        }

        // Método para atualizar o valor na coluna "Total"
        private void AtualizarTotal(int rowIndex)
        {
            try
            {
                // Obtém a quantidade e o preço/unidade
                var quantidadeObj = grdAgendamentos.Rows[rowIndex].Cells["Quantidade"].Value ?? 0;
                var precoObj = grdAgendamentos.Rows[rowIndex].Cells["Preço/Unidade"].Value;

                // Converte os valores para numéricos
                if (decimal.TryParse(quantidadeObj.ToString(), out decimal quantidade) &&
                    decimal.TryParse(precoObj?.ToString().Replace("R$", "").Trim(), out decimal preco))
                {
                    // Calcula o total
                    grdAgendamentos.Rows[rowIndex].Cells["Total"].Value = (quantidade * preco).ToString("C");
                }
                else
                {
                    // Caso algum valor não seja válido, define o total como vazio
                    grdAgendamentos.Rows[rowIndex].Cells["Total"].Value = null;
                }

                // Atualiza o valor de txtTotal
                AtualizarTxtTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular o total: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarTxtTotal()
        {
            try
            {
                decimal totalGeral = 0;

                foreach (DataGridViewRow row in grdAgendamentos.Rows)
                {
                    var totalObj = row.Cells["Total"].Value;

                    if (decimal.TryParse(totalObj?.ToString().Replace("R$", "").Trim(), out decimal total))
                    {
                        totalGeral += total;
                    }
                }

                // Atualiza o txtTotal com o valor calculado
                txtTotal.Text = totalGeral.ToString("C");

                // Também atualiza txtTotalFinal considerando o desconto
                AtualizarTxtTotalFinal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o total geral: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarTxtTotalFinal()
        {
            try
            {
                var totalObj = txtTotal.Text.Replace("R$", "").Trim();
                var descontoObj = txtDescontos.Text.Replace("R$", "").Trim();

                if (decimal.TryParse(totalObj, out decimal total) &&
                    decimal.TryParse(descontoObj, out decimal desconto))
                {
                    var totalFinal = total - desconto;
                    totalExportar = totalFinal;
                    txtTotalFinal.Text = totalFinal.ToString("C");
                }
                else
                {
                    // Define como vazio caso os valores não sejam válidos
                    txtTotalFinal.Text = "R$ 0,00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o total final: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
