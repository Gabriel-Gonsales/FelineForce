using FelineForce.Migrations;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ERP_com_relatorio
{
    public partial class frmClientes : Form
    {
        private readonly IClienteService _clienteService;
        Form form;
        string nome;
        string email;
        string telefone;
        string endereco;
        public frmClientes(Form form, IClienteService clienteService)
        {
            InitializeComponent();
            this.form = form;
            _clienteService = clienteService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void Clientes_Load(object sender, EventArgs e)
        {
            grdClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var clientes = await _clienteService.BuscarClientesAsync(txtPesquisa.Text);
            // Limpa as colunas existentes
            grdClientes.Columns.Clear();

            // Adiciona as colunas manualmente (caso queira personalizar)
            grdClientes.Columns.Add("Id", "Id");
            grdClientes.Columns.Add("Nome", "Nome");
            grdClientes.Columns.Add("Email", "Email");
            grdClientes.Columns.Add("CPF", "CPF");
            grdClientes.Columns.Add("Telefone", "Telefone");
            grdClientes.Columns.Add("Endereco", "Endereco");

            // Preenche o DataGridView com os dados de clientes
            foreach (var cliente in clientes)
            {
                grdClientes.Rows.Add(cliente.Id, cliente.Nome, cliente.Email, cliente.CPF, cliente.Telefone, cliente.Endereco);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente(this, _clienteService, null, null, null, null, null);
            frmCadastroCliente.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
        public async void OnChildFormClosed()
        {
            var clientes = await _clienteService.BuscarClientesAsync(txtPesquisa.Text);
            // Limpa as colunas existentes
            grdClientes.Columns.Clear();

            grdClientes.Columns.Add("Id", "Id");
            grdClientes.Columns.Add("Nome", "Nome");
            grdClientes.Columns.Add("Email", "Email");
            grdClientes.Columns.Add("CPF", "CPF");
            grdClientes.Columns.Add("Telefone", "Telefone");
            grdClientes.Columns.Add("Endereco", "Endereco");

            // Preenche o DataGridView com os dados de clientes
            foreach (var cliente in clientes)
            {
                grdClientes.Rows.Add(cliente.Id, cliente.Nome,cliente.Email, cliente.CPF, cliente.Telefone, cliente.Endereco);
            }
        }

        private async void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                var clientes = await _clienteService.BuscarClientesAsync(txtPesquisa.Text);

                // Desvincula o DataGridView para manipulação manual das colunas
                grdClientes.DataSource = null;

                // Limpa as colunas existentes
                grdClientes.Columns.Clear();

                grdClientes.Columns.Add("Id", "Id");
                grdClientes.Columns.Add("Nome", "Nome");
                grdClientes.Columns.Add("Email", "Email");
                grdClientes.Columns.Add("CPF", "CPF");
                grdClientes.Columns.Add("Telefone", "Telefone");
                grdClientes.Columns.Add("Endereco", "Endereco");
                // Preenche o DataGridView com os dados de clientes
                foreach (var cliente in clientes)
                {
                    grdClientes.Rows.Add(cliente.Id, cliente.Nome, cliente.Email, cliente.CPF, cliente.Telefone, cliente.Endereco);
                }
            }
        }

        private async void btnProcurar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.Trim();

            // Chama o método do service para buscar clientes
            var clientes = await _clienteService.BuscarClientesAsync(pesquisa);

            // Atualiza o DataGridView com os resultados
            grdClientes.DataSource = clientes.ToList(); // Caso o DataGridView exija uma lista explícita
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async Task AtualizarTabelaClientes()
        {
            var clientes = await _clienteService.BuscarClientesAsync(txtPesquisa.Text);

            // Limpa as colunas existentes
            grdClientes.DataSource = null;
            grdClientes.Rows.Clear();
            grdClientes.Columns.Clear();

            // Adiciona as colunas manualmente (caso queira personalizar)
            grdClientes.Columns.Add("Id", "Id"); // Adiciona a coluna para o GUID
            grdClientes.Columns.Add("Nome", "Nome");
            grdClientes.Columns.Add("Email", "Email");
            grdClientes.Columns.Add("CPF", "CPF");
            grdClientes.Columns.Add("Telefone", "Telefone");
            grdClientes.Columns.Add("Endereco", "Endereco");

            // Preenche o DataGridView com os dados de clientes
            foreach (var cliente in clientes)
            {
                grdClientes.Rows.Add(cliente.Id, cliente.Nome, cliente.Email, cliente.CPF, cliente.Telefone, cliente.Endereco);
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se há uma linha selecionada
                if (grdClientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um cliente para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtém a linha selecionada
                var selectedRow = grdClientes.SelectedRows[0];

                // Obtém o ID do cliente da célula correspondente
                var clienteIdCell = selectedRow.Cells["Id"]; // Substitua "Id" pelo nome da coluna correspondente ao GUID no DataGridView
                if (clienteIdCell == null || clienteIdCell.Value == null)
                {
                    MessageBox.Show("Não foi possível identificar o cliente selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Converte o valor da célula para Guid
                if (!Guid.TryParse(clienteIdCell.Value.ToString(), out Guid clienteId))
                {
                    MessageBox.Show("ID do cliente inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Chama o serviço para excluir o cliente
                await _clienteService.ExcluirCliente(clienteId);

                // Exibe mensagem de sucesso
                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza os dados no DataGridView
                await AtualizarTabelaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (grdClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém a linha selecionada
            var selectedRow = grdClientes.SelectedRows[0];

            // Obtém o ID do cliente da célula correspondente
            var clienteIdCell = selectedRow.Cells["Id"];
            var nome = selectedRow.Cells["Nome"].Value.ToString() ?? "";
            var email = selectedRow.Cells["Email"].Value.ToString() ?? "";
            var telefone = selectedRow.Cells["Telefone"].Value.ToString() ?? "";
            var endereco = selectedRow.Cells["Endereco"].Value.ToString() ?? "";
            if (clienteIdCell == null || clienteIdCell.Value == null)
            {
                MessageBox.Show("Não foi possível identificar o cliente selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Converte o valor da célula para Guid
            if (!Guid.TryParse(clienteIdCell.Value.ToString(), out Guid clienteId))
            {
                MessageBox.Show("ID do cliente inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chama o serviço para excluir o cliente
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente(this, _clienteService, clienteId, nome, email, telefone, endereco);
            frmCadastroCliente.Show();
            this.Hide();
        }
    }
}
