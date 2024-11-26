using FelineForce.Models;
using FelineForce.Services;
using FelineForce.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ERP_com_relatorio
{
    public partial class frmCadastroCliente : Form
    {
        private readonly IClienteService _clienteService;
        private Guid? ClienteId;
        private Form form;
        public frmCadastroCliente(Form Form, IClienteService clienteService, Guid? Id, string Nome = null, string CPF = null, string Telefone = null, string Endereco = null)
        {
            InitializeComponent();
            form = Form;
            _clienteService = clienteService;
            if (Id != null)
            {
                ClienteId = Id;
                txtNome.Text = Nome;
                txtEmail.Text = CPF;
                txtTelefone.Text = Telefone;
                txtEndereco.Text = Endereco;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.Trim();
            var email = txtEmail.Text.Trim();
            var telefone = txtTelefone.Text.Trim();
            var endereco = txtEndereco.Text.Trim();

            try
            {
                if (ClienteId.HasValue) // Atualização
                {
                    // Recupera o cliente pelo ID para garantir que existe
                    var clienteExistente = await _clienteService.ObterClientePorId(ClienteId.Value);

                    if (clienteExistente == null)
                    {
                        MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Atualiza os campos
                    clienteExistente.Nome = nome;
                    clienteExistente.CPF = email;
                    clienteExistente.Telefone = telefone;
                    clienteExistente.Endereco = endereco;

                    // Chama o método de atualização
                    await _clienteService.AtualizarCliente(clienteExistente);

                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Criação
                {
                    await _clienteService.CriarCliente(nome, email, telefone, endereco);
                    MessageBox.Show("Cliente salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Fecha o formulário atual
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frmCadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            (form as frmClientes).OnChildFormClosed();
            form.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
