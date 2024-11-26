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
    public partial class CadastroEstoque : Form
    {
        IEstoqueService _estoqueService;
        private Form form;
        public CadastroEstoque(Form Form, IEstoqueService estoqueService)
        {
            InitializeComponent();
            form = Form;
            _estoqueService = estoqueService;
        }

        private void CadastroEstoque_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Garante que o formulário anterior será trazido ao foco
            form.Show();
            form.Focus();

            // Atualiza os dados no formulário anterior
            if (form is frmEstoque estoqueForm)
            {
                estoqueForm.OnChildFormClosed();
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var precoInput = textBox1.Text; // Entrada do usuário
            var quantidadeInput = textBox2.Text; // Entrada do usuário

            try
            {
                // Tenta converter o preço para float
                if (!float.TryParse(precoInput, out float preco))
                {
                    MessageBox.Show("Por favor, insira um valor válido para o preço.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Arredonda o preço para duas casas decimais
                preco = (float)Math.Round(preco, 2);

                // Tenta converter a quantidade para inteiro
                if (!int.TryParse(quantidadeInput, out int quantidade))
                {
                    MessageBox.Show("Por favor, insira um valor válido para a quantidade.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Salva o produto no banco de dados
                await _estoqueService.CriarProduto(nome, quantidade, preco);

                MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
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
