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
    public partial class frmGatos : Form
    {
        private readonly IGatoService _gatoService;
        Form form;
        string id, nome, cores, cpf;
        public frmGatos(Form form, IGatoService gatoService)
        {
            InitializeComponent();
            this.form = form;
            _gatoService = gatoService;
        }

        private async void frmGatos_Load(object sender, EventArgs e)
        {
            grdGatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var gatos = await _gatoService.BuscarGatosComDadosDoTutorAsync();
            // Limpa as colunas existentes
            grdGatos.Columns.Clear();

            // Adiciona as colunas manualmente (caso queira personalizar)
            grdGatos.Columns.Add("Id", "Id");
            grdGatos.Columns.Add("Nome", "Nome");
            grdGatos.Columns.Add("Cor", "Cor");
            grdGatos.Columns.Add("NomeTutor", "Nome do tutor");
            grdGatos.Columns.Add("CPFTutor", "CPF do tutor");

            // Preenche o DataGridView com os dados de gatos
            foreach (var gato in gatos)
            {
                grdGatos.Rows.Add(gato.Id, gato.Nome, gato.Cor, gato.Tutor.Nome, gato.Tutor.CPF);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastraGato frmCadastraGato = new frmCadastraGato(this, _gatoService, null, null, null, null);
            frmCadastraGato.Show();
            this.Hide();
        }

        public async void OnChildFormClosed()
        {
            var gatos = await _gatoService.BuscarGatosComDadosDoTutorAsync();
            // Limpa as colunas existentes
            grdGatos.Columns.Clear();

            // Adiciona as colunas manualmente (caso queira personalizar)
            grdGatos.Columns.Add("Id", "Id");
            grdGatos.Columns.Add("Nome", "Nome");
            grdGatos.Columns.Add("Cor", "Cor");
            grdGatos.Columns.Add("NomeTutor", "Nome do tutor");
            grdGatos.Columns.Add("CPFTutor", "CPF do tutor");

            // Preenche o DataGridView com os dados de gatos
            foreach (var gato in gatos)
            {
                grdGatos.Rows.Add(gato.Id, gato.Nome, gato.Cor, gato.Tutor.Nome, gato.Tutor.CPF);
            }
        }
        private void frmGatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (grdGatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um gato para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém a linha selecionada
            var selectedRow = grdGatos.SelectedRows[0];

            // Obtém o ID do gato da célula correspondente
            var gatoIdCell = selectedRow.Cells["Id"];
            var nome = selectedRow.Cells["Nome"].Value.ToString() ?? "";
            var cores = selectedRow.Cells["Cor"].Value.ToString() ?? "";
            var cpf = selectedRow.Cells["CPFTutor"].Value.ToString() ?? "";
            if (gatoIdCell == null || gatoIdCell.Value == null)
            {
                MessageBox.Show("Não foi possível identificar o gato selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Converte o valor da célula para Guid
            if (!Guid.TryParse(gatoIdCell.Value.ToString(), out Guid gatoId))
            {
                MessageBox.Show("ID do gato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chama o serviço para excluir o gato
            frmCadastraGato frmCadastraGato = new frmCadastraGato(this, _gatoService, gatoId, nome, cores, cpf);
            frmCadastraGato.Show();
            this.Hide();
        }

        private void grdGatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                var gatos = await _gatoService.BuscarGatosComDadosDoTutorAsync();
                // Limpa as colunas existentes
                grdGatos.Columns.Clear();

                // Adiciona as colunas manualmente (caso queira personalizar)
                grdGatos.Columns.Add("Id", "Id");
                grdGatos.Columns.Add("Nome", "Nome");
                grdGatos.Columns.Add("Cor", "Cor");
                grdGatos.Columns.Add("NomeTutor", "Nome do tutor");
                grdGatos.Columns.Add("CPFTutor", "CPF do tutor");

                // Preenche o DataGridView com os dados de gatos
                foreach (var gato in gatos)
                {
                    grdGatos.Rows.Add(gato.Id, gato.Nome, gato.Cor, gato.Tutor.Nome, gato.Tutor.CPF);
                }
            }
        }

        private async void btnProcurar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.Trim();

            // Chama o método do service para buscar gatos
            var gatos = await _gatoService.BuscarGatosAsync(pesquisa);

            // Limpa as colunas existentes
            grdGatos.Columns.Clear();

            // Adiciona as colunas manualmente (caso queira personalizar)
            grdGatos.Columns.Add("Id", "Id");
            grdGatos.Columns.Add("Nome", "Nome");
            grdGatos.Columns.Add("Cor", "Cor");
            grdGatos.Columns.Add("NomeTutor", "Nome do tutor");
            grdGatos.Columns.Add("CPFTutor", "CPF do tutor");

            // Preenche o DataGridView com os dados de gatos
            foreach (var gato in gatos)
            {
                grdGatos.Rows.Add(gato.Id, gato.Nome, gato.Cor, gato.Tutor.Nome, gato.Tutor.CPF);
            }
        }
    }
}
