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
    public partial class frmCadastraGato : Form
    {
        Form form;
        Guid? id;
        private readonly IGatoService _gatoService;
        public frmCadastraGato(Form Form, IGatoService gatoService)
        {
            form = Form;
            InitializeComponent(); 
            _gatoService = gatoService;
        }

        public frmCadastraGato(Form Form, IGatoService gatoService, Guid? Id, string nome, string cores, string cpf)
        {
            InitializeComponent();
            txtCores.Text = cores;
            txtNome.Text = nome;
            form = Form;
            id = Id;
            _gatoService = gatoService;
        }

        private void frmCadastraGato_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            (form as frmGatos).OnChildFormClosed();
            this.Close();
        }

        private void frmCadastraGato_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void txtCores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.Trim();
            var cor = txtCores.Text.Trim();
            var cpf = txtCPF.Text.Trim();

            var clienteQuery = await _gatoService.BuscarClienteCPF(cpf);
            var cliente = clienteQuery.FirstOrDefault();
            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (id.HasValue) // Atualização
                {
                    // Recupera o cliente pelo ID para garantir que existe
                    var gatoExistente = await _gatoService.ObterGatoPorId(id.Value);

                    if (gatoExistente == null)
                    {
                        MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Atualiza os campos
                    gatoExistente.Nome = nome;

                    // Chama o método de atualização
                    await _gatoService.AtualizarGato(gatoExistente);

                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Criação
                {

                    await _gatoService.CriarGato(nome, cor, cpf, cliente);
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
    }
}
