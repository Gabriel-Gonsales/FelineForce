using FelineForce.Models;
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
    public partial class frmPagamento : Form
    {
        private Form form;
        private Venda _venda;
        private readonly IVendaService _vendaService;
        public frmPagamento(Form Form, Venda venda, IVendaService vendaService)
        {
            InitializeComponent();
            form = Form;
            _venda = venda;
            _vendaService = vendaService;
        }

        private void cbxCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.Enabled = cbxCPF.Checked;
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            txtCPF.Text = _venda.CPFCliente;
            txtTotal.Text = _venda.TotalCompra.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private async void btnProsseguir_Click(object sender, EventArgs e)
        {
            try
            {
                // Salva a venda no banco
                await _vendaService.CriarVenda(_venda);

                MessageBox.Show("Venda realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fecha o formulário de pagamento e o anterior
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao finalizar a venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtRecebido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Converte o valor recebido e o total
                var recebidoStr = txtRecebido.Text.Replace("R$", "").Trim();
                var totalStr = txtTotal.Text.Replace("R$", "").Trim();

                if (decimal.TryParse(recebidoStr, out decimal recebido) &&
                    decimal.TryParse(totalStr, out decimal total))
                {
                    // Calcula o troco
                    var troco = recebido - total;

                    // Atualiza o campo txtTroco
                    txtTroco.Text = troco >= 0 ? troco.ToString("C") : "R$ 0,00";
                }
                else
                {
                    // Limpa o campo txtTroco caso a entrada seja inválida
                    txtTroco.Text = "R$ 0,00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular o troco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
